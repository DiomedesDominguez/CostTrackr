using System.Linq.Expressions;
using System.Text.RegularExpressions;

namespace DNMOFT.CostTrackr.DataAccess;
/// <summary>
/// Provides extension methods for sorting IQueryable collections based on property names.
/// </summary>
public static class OrderByExtensions
{
    /// <summary>
    /// Sorts the elements of a sequence in ascending order based on a specified property.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="source">The sequence to sort.</param>
    /// <param name="property">The name of the property to sort by.</param>
    /// <returns>An <see cref="IOrderedQueryable{T}"/> that contains the sorted elements.</returns>
    private static IOrderedQueryable<T>? OrderBy<T>(this IQueryable<T> source, string property)
    {
        return ApplyOrder(source, property, "OrderBy");
    }

    /// <summary>
    /// Sorts the elements of a sequence in descending order based on a specified property.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="source">The sequence to sort.</param>
    /// <param name="property">The name of the property to sort by.</param>
    /// <returns>An <see cref="IOrderedQueryable{T}"/> that contains the sorted elements.</returns>
    private static IOrderedQueryable<T>? OrderByDescending<T>(this IQueryable<T> source, string property)
    {
        return ApplyOrder(source, property, "OrderByDescending");
    }

    /// <summary>
    /// Applies the specified ordering to the elements of a sequence based on a specified property and method name.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="source">The sequence to apply the ordering to.</param>
    /// <param name="property">The name of the property to sort by.</param>
    /// <param name="methodName">The name of the ordering method to apply.</param>
    /// <returns>An <see cref="IOrderedQueryable{T}"/> that contains the sorted elements.</returns>
    private static IOrderedQueryable<T>? ApplyOrder<T>(IQueryable<T> source, string property, string methodName)
    {
        var props = property.Split('.');
        var type = typeof(T);
        var arg = Expression.Parameter(type, "x");
        Expression expr = arg;
        foreach (var prop in props)
        {
            // use reflection (not ComponentModel) to mirror LINQ
            var pi = type.GetProperty(prop);
#pragma warning disable CS8604 // Possible null reference argument.
            expr = Expression.Property(expr, pi);
#pragma warning restore CS8604 // Possible null reference argument.
            type = pi.PropertyType;
        }
        var delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
        var lambda = Expression.Lambda(delegateType, expr, arg);

        var result = typeof(Queryable).GetMethods().Single(
                method => method.Name == methodName
                          && method.IsGenericMethodDefinition
                          && method.GetGenericArguments().Length == 2
                          && method.GetParameters().Length == 2)
            .MakeGenericMethod(typeof(T), type)
            .Invoke(null, [source, lambda]);
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.
        return (IOrderedQueryable<T>)result;
#pragma warning restore CS8600 // Converting null literal or possible null value to non-nullable type.
    }

    /// <summary>
    /// Performs a subsequent ordering of the elements in a sequence in ascending order based on a specified property.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="source">The sequence to sort.</param>
    /// <param name="property">The name of the property to sort by.</param>
    /// <returns>An <see cref="IOrderedQueryable{T}"/> that contains the sorted elements.</returns>
    private static IOrderedQueryable<T>? ThenBy<T>(this IOrderedQueryable<T> source, string property)
    {
        return ApplyOrder(source, property, "ThenBy");
    }

    /// <summary>
    /// Performs a subsequent ordering of the elements in a sequence in descending order based on a specified property.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="source">The sequence to sort.</param>
    /// <param name="property">The name of the property to sort by.</param>
    /// <returns>An <see cref="IOrderedQueryable{T}"/> that contains the sorted elements.</returns>
    private static IOrderedQueryable<T>? ThenByDescending<T>(this IOrderedQueryable<T> source, string property)
    {
        return ApplyOrder(source, property, "ThenByDescending");
    }

    /// <summary>
    /// Sorts the elements of a sequence based on a comma-separated list of property names.
    /// </summary>
    /// <typeparam name="T">The type of the elements in the sequence.</typeparam>
    /// <param name="source">The sequence to sort.</param>
    /// <param name="value">A comma-separated list of property names to sort by.</param>
    /// <returns>An <see cref="IOrderedQueryable{T}"/> that contains the sorted elements.</returns>
    public static IOrderedQueryable<T> SortBy<T>(this IQueryable<T> source, string value)
    {
        var properties = value.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

        IOrderedQueryable<T>? result = null;
        for (var i = 0; i < properties.Length; i++)
        {
            var property = properties[i].Trim();
            var descending = property.Contains(" DESC", StringComparison.OrdinalIgnoreCase);

            property = Regex.Replace(property, " DESC| ASC", "", RegexOptions.IgnoreCase).Replace(" ", "");

            if (i == 0)
                result = descending ? source.OrderByDescending(property) : source.OrderBy(property);
            else
#pragma warning disable CS8604 // Possible null reference argument.
                result = descending ? result.ThenByDescending(property) : result.ThenBy(property);
#pragma warning restore CS8604 // Possible null reference argument.
        }
#pragma warning disable CS8603 // Possible null reference return.
        return result;
#pragma warning restore CS8603 // Possible null reference return.
    }
}
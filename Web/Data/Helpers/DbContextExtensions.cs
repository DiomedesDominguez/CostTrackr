using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace DNMOFT.CostTrackr.Web.Data
{
    public static class DbContextExtensions
    {
        
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            foreach (var element in source)
                action(element);
        }
        private static IOrderedQueryable<T> OrderBy<T>(this IQueryable<T> source, string property)
        {
            return ApplyOrder(source, property, "OrderBy");
        }

        private static IOrderedQueryable<T> OrderByDescending<T>(this IQueryable<T> source, string property)
        {
            return ApplyOrder(source, property, "OrderByDescending");
        }
        private static IOrderedQueryable<T> ApplyOrder<T>(IQueryable<T> source, string property, string methodName)
        {
            var props = property.Split('.');
            var type = typeof(T);
            var arg = Expression.Parameter(type, "x");
            Expression expr = arg;
            foreach (var prop in props)
            {
                // use reflection (not ComponentModel) to mirror LINQ
                var pi = type.GetProperty(prop);
                expr = Expression.Property(expr, pi);
                type = pi.PropertyType;
            }
            var delegateType = typeof(Func<,>).MakeGenericType(typeof(T), type);
            var lambda = Expression.Lambda(delegateType, expr, arg);

            var result = typeof(Queryable).GetMethods().FirstOrDefault(
                    method => method.Name == methodName
                              && method.IsGenericMethodDefinition
                              && method.GetGenericArguments().Length == 2
                              && method.GetParameters().Length == 2)
                .MakeGenericMethod(typeof(T), type)
                .Invoke(null, new object[] { source, lambda });
            return (IOrderedQueryable<T>)result;
        }
        public static IOrderedQueryable<T> SortBy<T>(this IQueryable<T> source, string value)
        {
            var properties = value.Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            IOrderedQueryable<T> result = null;
            for (var i = 0; i < properties.Length; i++)
            {
                var property = properties[i].Trim();
                var descending = property.ToUpper().Contains(" DESC");

                property = property.Replace(" DESC", string.Empty)
                    .Replace(" ASC", string.Empty)
                    .Replace(" ", string.Empty);
                if (i == 0)
                    result = descending ? source.OrderByDescending(property) : source.OrderBy(property);
                else
                    result = descending ? result.ThenByDescending(property) : result.ThenBy(property);
            }
            return result;
        }

        private static IOrderedQueryable<T> ThenBy<T>(this IOrderedQueryable<T> source, string property)
        {
            return ApplyOrder(source, property, "ThenBy");
        }

        private static IOrderedQueryable<T> ThenByDescending<T>(this IOrderedQueryable<T> source, string property)
        {
            return ApplyOrder(source, property, "ThenByDescending");
        }
    }
}
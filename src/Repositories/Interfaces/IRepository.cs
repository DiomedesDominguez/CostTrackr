using System.Linq.Expressions;
using DNMOFT.CostTrackr.DataAccess.Interfaces;

namespace DNMOFT.CostTrackr.Repositories.Interfaces
{
    /// <summary>
    /// Represents a generic repository interface for accessing and manipulating entities.
    /// </summary>
    /// <typeparam name="TE">The entity type.</typeparam>
    public interface IRepository<TE> : IDisposable
        where TE : class, IBaseEntity, new()
    {
        /// <summary>
        /// Adds or updates the specified entity.
        /// </summary>
        /// <param name="model">The entity to add or update.</param>
        /// <returns>The added or updated entity.</returns>
        TE AddOrUpdate(TE model);

        /// <summary>
        /// Adds or updates a collection of entities.
        /// </summary>
        /// <param name="models">The collection of entities to add or update.</param>
        /// <returns>The added or updated entities.</returns>
        IEnumerable<TE> AddOrUpdateBulk(IEnumerable<TE> models);

        /// <summary>
        /// Deletes the specified entity.
        /// </summary>
        /// <param name="model">The entity to delete.</param>
        void Delete(TE model);

        /// <summary>
        /// Deletes a collection of entities.
        /// </summary>
        /// <param name="models">The collection of entities to delete.</param>
        void DeleteBulk(IEnumerable<TE> models);

        /// <summary>
        /// Counts the number of entities that satisfy the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate to filter the entities.</param>
        /// <returns>The number of entities that satisfy the predicate.</returns>
        long Count(Expression<Func<TE, bool>>? predicate = null);

        /// <summary>
        /// Gets the entity with the specified ID.
        /// </summary>
        /// <param name="id">The ID of the entity to get.</param>
        /// <returns>The entity with the specified ID, or null if not found.</returns>
        TE? GetById(long id);

        /// <summary>
        /// Executes a stored procedure and returns the result as a collection of entities.
        /// </summary>
        /// <param name="parameters">The parameters to pass to the stored procedure.</param>
        /// <returns>The result of the stored procedure as a collection of entities.</returns>
        IQueryable<TE> GetBySp(params object[] parameters);

        /// <summary>
        /// Executes a stored procedure.
        /// </summary>
        /// <param name="storedProcedure">The name of the stored procedure to execute.</param>
        /// <param name="parameters">The parameters to pass to the stored procedure.</param>
        void ExecuteSp(string storedProcedure, params object[] parameters);

        /// <summary>
        /// Gets the first entity that satisfies the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate to filter the entities.</param>
        /// <returns>The first entity that satisfies the predicate, or null if not found.</returns>
        TE Get(Expression<Func<TE, bool>>? predicate = null);

        /// <summary>
        /// Gets a collection of entities that satisfy the specified predicate.
        /// </summary>
        /// <param name="predicate">The predicate to filter the entities.</param>
        /// <param name="maximumRows">The maximum number of rows to return.</param>
        /// <param name="startRowIndex">The index of the first row to return.</param>
        /// <param name="sortExpression">The sort expression to order the entities.</param>
        /// <returns>A collection of entities that satisfy the predicate.</returns>
        IQueryable<TE> Get(Expression<Func<TE, bool>>? predicate = null, int maximumRows = 0, int startRowIndex = 0, string? sortExpression = null);
    }
}
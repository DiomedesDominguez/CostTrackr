using System.Linq.Expressions;
using DNMOFT.CostTrackr.DataAccess.Interfaces;

namespace DNMOFT.CostTrackr.Repositories.Interfaces
{
    public interface IRepository<TE> : IDisposable
        where TE : class, IBaseEntity, new()
    {
        TE AddOrUpdate(TE model);
        IEnumerable<TE> AddOrUpdateBulk(IEnumerable<TE> models);
        void Delete(TE model);
        void DeleteBulk(IEnumerable<TE> models);
        long Count(Expression<Func<TE, bool>>? predicate = null);
        TE GetById(long id);
        IQueryable<TE> GetBySp(params object[] parameters);
        void ExecuteSp(string storedProcedure, params object[] parameters);
        TE Get(Expression<Func<TE, bool>>? predicate = null);
        IQueryable<TE> Get(Expression<Func<TE, bool>>? predicate = null, int maximumRows = 0, int startRowIndex = 0, string? sortExpression = null);
    }
}
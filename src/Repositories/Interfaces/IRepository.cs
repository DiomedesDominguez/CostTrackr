using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using DNMOFT.CostTrackr.DataAccess.Interfaces;

namespace DNMOFT.CostTrackr.Repositories.Interfaces
{
    public interface IRepository<TE> : IDisposable
        where TE : class, IBaseEntity, new()
    {
        TE AddOrUpdate(TE model);
        long Count(Expression<Func<TE, bool>>? predicate = null);
        void Delete(long id);
        void ExecuteSp(string storedProcedure, params object[] parameters);
        IQueryable<TE> Get(Expression<Func<TE, bool>>? predicate = null, int maximumRows = 0, int startRowIndex = 0,
            string? sortExpression = null);
        TE GetById(long id);
        IQueryable<TE> GetBySp(string storedProcedure, params object[] parameters);
    }
}
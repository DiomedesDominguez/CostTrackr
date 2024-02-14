namespace DNMOFT.CostTrackr.Repositories.Base;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Enums;
using DNMOFT.CostTrackr.DataAccess.Interfaces;
using DNMOFT.CostTrackr.Repositories.Interfaces;
using LinqKit;
using Microsoft.EntityFrameworkCore;

public class BaseRepository<TE> : IRepository<TE>
        where TE : class, IBaseEntity, new()
{
    protected readonly ApplicationDbContext _dbContext;
    internal DbSet<TE> DbSet;
    public BaseRepository(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
        DbSet = _dbContext.Set<TE>();
    }

    public TE AddOrUpdate(TE model)
    {
        model = EntityAnalizer(model);

        _dbContext.SaveChanges();
        return model;
    }

    private TE EntityAnalizer(TE model)
    {
        var isNew = model.Id == 0;
        if (isNew)
        {
            model.CreatedAt = DateTime.Now;
            DbSet.Add(model);
        }
        else
            DbSet.Update(model);

        return model;
    }

    public IEnumerable<TE> AddOrUpdateBulk(IEnumerable<TE> models)
    {
        foreach (var model in models)
        {
            EntityAnalizer(model);
        }

        _dbContext.SaveChanges();

        return models;
    }

    public long Count(Expression<Func<TE, bool>>? predicate = null)
    {
        return DbSet.LongCount(StateExpression(predicate));
    }

    public void Delete(TE model)
    {
        model.RecordState = RecordState.Eliminado;
        model.LastModifiedAt = DateTime.Now;

        _dbContext.SaveChanges();
    }

    public void DeleteBulk(IEnumerable<TE> models)
    {
        foreach (var model in models)
        {
            model.RecordState = RecordState.Eliminado;
            model.LastModifiedAt = DateTime.Now;
        }

        _dbContext.SaveChanges();
    }

    private bool disposed = false;
    public void Dispose(bool disposing)
    {
        if (!disposed)
        {
            if (disposing)
            {
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
                DbSet = null;
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
                _dbContext.Dispose();
            }
            disposed = true;
        }
    }
    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }
    ~BaseRepository()
    {
        Dispose(false);
    }

    public void ExecuteSp(string storedProcedure, params object[] parameters)
    {
        throw new NotImplementedException();
    }

    public TE Get(Expression<Func<TE, bool>>? predicate = null)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TE> Get(Expression<Func<TE, bool>>? predicate = null, int maximumRows = 0, int startRowIndex = 0, string? sortExpression = null)
    {
        throw new NotImplementedException();
    }

    public TE GetById(long id)
    {
        throw new NotImplementedException();
    }

    public IQueryable<TE> GetBySp(params object[] parameters)
    {
        throw new NotImplementedException();
    }
    private Expression<Func<TE, bool>> StateExpression(Expression<Func<TE, bool>>? predicate = null)
    {
        predicate ??= PredicateBuilder.New<TE>();

        return predicate;
    }
}

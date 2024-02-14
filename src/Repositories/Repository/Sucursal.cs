namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing Sucursal entities.
/// </summary>
public class SucursalRepository:BaseRepository<mSucursal>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SucursalRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public SucursalRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

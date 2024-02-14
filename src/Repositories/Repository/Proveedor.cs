namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing Proveedor entities.
/// </summary>
public class ProveedorRepository: BaseRepository<mProveedor>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProveedorRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ProveedorRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

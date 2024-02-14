using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing TipoProveedor entities.
/// </summary>
public class TipoProveedorRepository : BaseRepository<mTipoProveedor>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TipoProveedorRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public TipoProveedorRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

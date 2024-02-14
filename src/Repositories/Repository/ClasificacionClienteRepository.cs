using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing ClasificacionCliente entities.
/// </summary>
public class ClasificacionClienteRepository : BaseRepository<mClasificacionCliente>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClasificacionClienteRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ClasificacionClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing Zona entities.
/// </summary>
public class ZonaRepository : BaseRepository<mZona>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ZonaRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ZonaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

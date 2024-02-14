using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing transportation entities.
/// </summary>
public class TransporteRepository : BaseRepository<mTransporte> 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransporteRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public TransporteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

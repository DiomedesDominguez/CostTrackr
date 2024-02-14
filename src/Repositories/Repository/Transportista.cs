using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing Transportista entities.
/// </summary>
public class TransportistaRepository : BaseRepository<mTransportista>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TransportistaRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public TransportistaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

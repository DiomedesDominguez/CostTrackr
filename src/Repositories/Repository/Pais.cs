using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing Pais entities.
/// </summary>
public class PaisRepository : BaseRepository<mPais>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PaisRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public PaisRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

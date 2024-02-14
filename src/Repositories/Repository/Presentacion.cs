namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing Presentacion entities.
/// </summary>
public class PresentacionRepository: BaseRepository<mPresentacion>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PresentacionRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public PresentacionRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

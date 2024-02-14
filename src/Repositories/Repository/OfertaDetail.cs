namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing OfertaDetail entities.
/// </summary>
public class OfertaDetailRepository: BaseRepository<mOfertaDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OfertaDetailRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public OfertaDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
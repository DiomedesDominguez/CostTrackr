namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing Oferta entities.
/// </summary>
public class OfertaRepository: BaseRepository<mOferta>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OfertaRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public OfertaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
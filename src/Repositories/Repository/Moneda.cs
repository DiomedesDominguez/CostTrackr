namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing Moneda entities.
/// </summary>
public class MonedaRepository: BaseRepository<mMoneda>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MonedaRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public MonedaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
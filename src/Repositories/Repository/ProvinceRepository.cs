using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing provinces.
/// </summary>
public class ProvinceRepository: BaseRepository<mProvince>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProvinceRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ProvinceRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

/// <summary>
/// Represents a repository for managing Municipality entities.
/// </summary>
public class MunicipalyRepository: BaseRepository<mMunicipality>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="MunicipalyRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public MunicipalyRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

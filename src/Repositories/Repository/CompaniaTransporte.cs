namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing CompaniaTransporte entities.
/// </summary>
public class CompaniaTransporteRepository: BaseRepository<mCompaniaTransporte>
{
    /// <summary>
    /// Initializes a new instance of the CompaniaTransporteRepository class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public CompaniaTransporteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

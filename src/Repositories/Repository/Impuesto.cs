namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing Impuesto entities.
/// </summary>
public class ImpuestoRepository: BaseRepository<mImpuesto>
{
    /// <summary>
    /// Initializes a new instance of the ImpuestoRepository class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ImpuestoRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
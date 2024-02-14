namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing ProductoFamilia entities.
/// </summary>
public class ProductoFamiliaRepository: BaseRepository<mProductoFamilia>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductoFamiliaRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ProductoFamiliaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

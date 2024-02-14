namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

/// <summary>
/// Represents a repository for managing Producto entities.
/// </summary>
public class ProductoRepository: BaseRepository<mProducto>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ProductoRepository"/> class.
    /// </summary>
    /// <param name="dbContext">The application database context.</param>
    public ProductoRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

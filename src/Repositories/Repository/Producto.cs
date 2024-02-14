namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class ProductoRepository: BaseRepository<mProducto>
{
    public ProductoRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

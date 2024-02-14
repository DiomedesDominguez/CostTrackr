namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class ProductoFamiliaRepository: BaseRepository<mProductoFamilia>
{
    public ProductoFamiliaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

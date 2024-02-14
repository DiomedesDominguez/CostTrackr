namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class ImpuestoRepository: BaseRepository<mImpuesto>
{
    public ImpuestoRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
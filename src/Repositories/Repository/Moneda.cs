namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class MonedaRepository: BaseRepository<mMoneda>
{
    public MonedaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
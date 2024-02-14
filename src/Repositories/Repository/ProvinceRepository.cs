using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class ProvinceRepository: BaseRepository<mProvince>
{
    public ProvinceRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

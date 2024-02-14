using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class MunicipalyRepository: BaseRepository<mMunicipality>
{
    public MunicipalyRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

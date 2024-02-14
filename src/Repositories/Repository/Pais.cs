using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.Map;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class PaisRepository : BaseRepository<mPais>
{
    public PaisRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

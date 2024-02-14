using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class ZonaRepository : BaseRepository<mZona>
{
    public ZonaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

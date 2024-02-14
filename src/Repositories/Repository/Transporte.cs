using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class TransporteRepository : BaseRepository<mTransporte> 
{
    public TransporteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

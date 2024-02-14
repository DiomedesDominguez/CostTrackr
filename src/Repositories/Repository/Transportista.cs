using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class TransportistaRepository : BaseRepository<mTransportista>
{
    public TransportistaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class SucursalRepository:BaseRepository<mSucursal>
{
    public SucursalRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class ProveedorRepository: BaseRepository<mProveedor>
{
    public ProveedorRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

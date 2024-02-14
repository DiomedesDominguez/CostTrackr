using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class TipoProveedorRepository : BaseRepository<mTipoProveedor>
{
    public TipoProveedorRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

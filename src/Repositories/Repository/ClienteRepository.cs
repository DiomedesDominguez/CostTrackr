namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class ClienteRepository: BaseRepository<mCliente>
{
    public ClienteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
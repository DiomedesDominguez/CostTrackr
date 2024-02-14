namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class OfertaRepository: BaseRepository<mOferta>
{
    public OfertaRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
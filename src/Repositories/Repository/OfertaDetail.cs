namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class OfertaDetailRepository: BaseRepository<mOfertaDetail>
{
    public OfertaDetailRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}
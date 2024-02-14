namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class PresentacionRepository: BaseRepository<mPresentacion>
{
    public PresentacionRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

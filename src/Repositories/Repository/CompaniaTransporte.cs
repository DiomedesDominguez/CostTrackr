﻿namespace DNMOFT.CostTrackr.Repositories;
using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;
public class CompaniaTransporteRepository: BaseRepository<mCompaniaTransporte>
{
    public CompaniaTransporteRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

﻿using DNMOFT.CostTrackr.DataAccess;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.Repositories.Base;

namespace DNMOFT.CostTrackr.Repositories;

public class VendedorRepository : BaseRepository<mVendedor>
{
    public VendedorRepository(ApplicationDbContext dbContext) : base(dbContext)
    {
    }
}

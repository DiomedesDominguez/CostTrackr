using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.DataAccess.Entities.Base.Identity;
using DNMOFT.CostTrackr.DataAccess.Helpers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DNMOFT.CostTrackr.DataAccess
{
    public partial class ApplicationDbContext : IdentityDbContext<mUser, mRole, long, mUserClaim, mUserRole, mUserLogin, mRoleClaim, mUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        

        public long UserId { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.SetDefaults();
        }
    }
}
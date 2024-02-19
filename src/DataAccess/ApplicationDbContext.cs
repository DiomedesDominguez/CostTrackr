using DNMOFT.CostTrackr.DataAccess.Entities.Identity;
using DNMOFT.CostTrackr.DataAccess.Helpers;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DNMOFT.CostTrackr.DataAccess
{
    /// <summary>
    /// Represents the database context for the application.
    /// </summary>
    public partial class ApplicationDbContext : IdentityDbContext<mUser, mRole, long, mUserClaim, mUserRole, mUserLogin, mRoleClaim, mUserToken>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ApplicationDbContext"/> class.
        /// </summary>
        /// <param name="options">The options for configuring the database context.</param>
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {                        
            modelBuilder.HasPostgresExtension("postgis");

            modelBuilder.SetDefaults();
        }
    }
}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DNMOFT.CostTrackR.Web.Data.Entities.Identity;
using DNMOFT.CostTrackR.Web.Data.Helpers;

namespace DNMOFT.CostTrackR.Web.Data;

public class ApplicationDbContext : IdentityDbContext<mUser, mRole, long, mUserClaim, mUserRole, mUserLogin, mRoleClaim, mUserToken>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public DbSet<mUser> Users { get; set; }
    public DbSet<mUserRole> UserRoles { get; set; }
    public DbSet<mUserClaim> UserClaims { get; set; }
    public DbSet<mUserLogin> UserLogins { get; set; }
    public DbSet<mUserToken> UserTokens { get; set; }
    public DbSet<mRole> Roles { get; set; }
    public DbSet<mRoleClaim> RoleClaims { get; set; }
    public long UserId { get; set; }

    public override int SaveChanges()
    {
        
        return base.SaveChanges();
    }

    override protected void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.SetDefaults();
    }
}

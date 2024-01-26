using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DNMOFT.CostTrackR.Web.Data.Entities.Identity;

namespace DNMOFT.CostTrackR.Web.Data;

public class ApplicationDbContext : IdentityDbContext<mUser, mRole, long, mUserClaim, mUserRole, mUserLogin, mRoleClaim, mUserToken>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public new DbSet<mUser> Users { get; set; }
    public new DbSet<mUserRole> UserRoles { get; set; }
    public new DbSet<mUserClaim> UserClaims { get; set; }
    public new DbSet<mUserLogin> UserLogins { get; set; }
    public new DbSet<mUserToken> UserTokens { get; set; }
    public new DbSet<mRole> Roles { get; set; }
    public new DbSet<mRoleClaim> RoleClaims { get; set; }
    public long UserId { get; set; }

    public override int SaveChanges()
    {
        
        return base.SaveChanges();
    }
}

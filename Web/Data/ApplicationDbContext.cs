using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DNMOFT.CostTrackR.Web.Data.Entities.Identity;
using DNMOFT.CostTrackR.Web.Data.Helpers;
using Web.Data.Entities.App;

namespace DNMOFT.CostTrackR.Web.Data;

public class ApplicationDbContext : IdentityDbContext<mUser, mRole, long, mUserClaim, mUserRole, mUserLogin, mRoleClaim, mUserToken>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }
    public override DbSet<mUser> Users { get; set; }
    public override DbSet<mUserRole> UserRoles { get; set; }
    public override DbSet<mUserClaim> UserClaims { get; set; }
    public override DbSet<mUserLogin> UserLogins { get; set; }
    public override DbSet<mUserToken> UserTokens { get; set; }
    public override DbSet<mRole> Roles { get; set; }
    public override DbSet<mRoleClaim> RoleClaims { get; set; }

    public DbSet<mImpuesto> Impuestos { get; set; }
    public DbSet<mPresentacion> Presentacions { get; set; }
    public DbSet<mProducto> Productos { get; set; }
    public DbSet<mProveedor> Proveedors { get; set; }
    public DbSet<mProductoFamilia> ProductoFamilias { get; set; }
    public DbSet<mTipoProveedor> TipoProveedors { get; set; }
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

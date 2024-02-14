using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.DataAccess.Entities.Base.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DNMOFT.CostTrackr.DataAccess
{
    public class ApplicationDbContext : IdentityDbContext<mUser, mRole, long, mUserClaim, mUserRole, mUserLogin, mRoleClaim, mUserToken>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public override DbSet<mUser> Users { get; set; }
        public override DbSet<mUserRole> UserRoles { get; set; }
        public override DbSet<mUserClaim> UserClaims { get; set; }
        public override DbSet<mUserLogin> UserLogins { get; set; }
        public override DbSet<mUserToken> UserTokens { get; set; }
        public override DbSet<mRole> Roles { get; set; }
        public override DbSet<mRoleClaim> RoleClaims { get; set; }

        public DbSet<mAlmacen> Almacenes { get; set; }
        public DbSet<mCliente> Clientes { get; set; }
        public DbSet<mClasificacionCliente> ClasificacionClientes { get; set; }
        public DbSet<mCompaniaTransporte> CompaniaTransportes { get; set; }
        public DbSet<mImpuesto> Impuestos { get; set; }
        public DbSet<mMoneda> Monedas { get; set; }
        public DbSet<mProveedor> Proveedores { get; set; }
        public DbSet<mSucursal> Sucursales { get; set; }
        public DbSet<mOferta> Ofertas { get; set; }
        public DbSet<mOrden> Ordenes { get; set; }
        public DbSet<mOrdenDetail> OrdenDetails { get; set; }
        public DbSet<mProducto> Productos { get; set; }
        public DbSet<mProductoFamilia> ProductoFamilias { get; set; }
        public DbSet<mPresentacion> Presentacions { get; set; }
        public DbSet<mTipoProveedor> TipoProveedores { get; set; }
        public DbSet<mTransporte> Transportes { get; set; }
        public DbSet<mTransportista> Transportistas { get; set; }
        public DbSet<mVendedor> Vendedores { get; set; }
        public DbSet<mZona> Zonas { get; set; }

        public long UserId { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.SetDefaults();
        }
    }
}
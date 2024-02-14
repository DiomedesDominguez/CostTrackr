using DNMOFT.CostTrackr.DataAccess.Entities.App;
using DNMOFT.CostTrackr.DataAccess.Entities.Base.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DNMOFT.CostTrackr.DataAccess
{
    /// <summary>
    /// Represents the DbContext class for accessing the database tables.
    /// </summary>
    public partial class ApplicationDbContext : IdentityDbContext<mUser, mRole, long, mUserClaim, mUserRole, mUserLogin, mRoleClaim, mUserToken>
    {
        /// <summary>
        /// Gets or sets the DbSet for the 'Users' table.
        /// </summary>
        public override DbSet<mUser> Users { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'UserRoles' table.
        /// </summary>
        public override DbSet<mUserRole> UserRoles { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'UserClaims' table.
        /// </summary>
        public override DbSet<mUserClaim> UserClaims { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'UserLogins' table.
        /// </summary>
        public override DbSet<mUserLogin> UserLogins { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'UserTokens' table.
        /// </summary>
        public override DbSet<mUserToken> UserTokens { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Roles' table.
        /// </summary>
        public override DbSet<mRole> Roles { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'RoleClaims' table.
        /// </summary>
        public override DbSet<mRoleClaim> RoleClaims { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Almacenes' table.
        /// </summary>
        public DbSet<mAlmacen> Almacenes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Clientes' table.
        /// </summary>
        public DbSet<mCliente> Clientes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'ClasificacionClientes' table.
        /// </summary>
        public DbSet<mClasificacionCliente> ClasificacionClientes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'CompaniaTransportes' table.
        /// </summary>
        public DbSet<mCompaniaTransporte> CompaniaTransportes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Impuestos' table.
        /// </summary>
        public DbSet<mImpuesto> Impuestos { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Monedas' table.
        /// </summary>
        public DbSet<mMoneda> Monedas { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Proveedores' table.
        /// </summary>
        public DbSet<mProveedor> Proveedores { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Sucursales' table.
        /// </summary>
        public DbSet<mSucursal> Sucursales { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Ofertas' table.
        /// </summary>
        public DbSet<mOferta> Ofertas { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Ordenes' table.
        /// </summary>
        public DbSet<mOrden> Ordenes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'OrdenDetails' table.
        /// </summary>
        public DbSet<mOrdenDetail> OrdenDetails { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Productos' table.
        /// </summary>
        public DbSet<mProducto> Productos { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'ProductoFamilias' table.
        /// </summary>
        public DbSet<mProductoFamilia> ProductoFamilias { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Presentacions' table.
        /// </summary>
        public DbSet<mPresentacion> Presentacions { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'TipoProveedores' table.
        /// </summary>
        public DbSet<mTipoProveedor> TipoProveedores { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Transportes' table.
        /// </summary>
        public DbSet<mTransporte> Transportes { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Transportistas' table.
        /// </summary>
        public DbSet<mTransportista> Transportistas { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Vendedores' table.
        /// </summary>
        public DbSet<mVendedor> Vendedores { get; set; }

        /// <summary>
        /// Gets or sets the DbSet for the 'Zonas' table.
        /// </summary>
        public DbSet<mZona> Zonas { get; set; }
    }
}
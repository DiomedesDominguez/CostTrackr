using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DNMOFT.CostTrackr.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mClasificacionesClientes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(550)", maxLength: 550, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mClasificacionesClientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mCompaniasTransportes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "character varying(7)", maxLength: 7, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mCompaniasTransportes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mImpuestos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Tasa = table.Column<decimal>(type: "numeric", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mImpuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mMonedas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Simbolo = table.Column<string>(type: "text", nullable: false),
                    ISO = table.Column<string>(type: "text", nullable: false),
                    EsPrimaria = table.Column<bool>(type: "boolean", nullable: false),
                    Tasa = table.Column<decimal>(type: "numeric", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mMonedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mPaises",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mPaises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mPresentaciones",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Alto = table.Column<decimal>(type: "numeric", nullable: false),
                    Ancho = table.Column<decimal>(type: "numeric", nullable: false),
                    Cantidad = table.Column<short>(type: "smallint", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    Largo = table.Column<decimal>(type: "numeric", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Peso = table.Column<decimal>(type: "numeric", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mPresentaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mProductosFamilias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mProductosFamilias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClaimType = table.Column<string>(type: "text", nullable: false),
                    ClaimValue = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mSucursales",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    Referencia = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mSucursales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mTiposProveedores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mTiposProveedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mTransportes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Alto = table.Column<decimal>(type: "numeric", nullable: false),
                    Ancho = table.Column<decimal>(type: "numeric", nullable: false),
                    Capacidad = table.Column<decimal>(type: "numeric", nullable: false),
                    Largo = table.Column<decimal>(type: "numeric", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mTransportes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClaimType = table.Column<string>(type: "text", nullable: false),
                    ClaimValue = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mUserLogins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LoginProvider = table.Column<string>(type: "varchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    ProviderKeyET = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUserLogins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "varchar(128)", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "varchar(128)", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "varchar(128)", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "varchar(128)", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mUsersRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUsersRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mUserTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    LoginProvider = table.Column<string>(type: "varchar(450)", nullable: false),
                    Name = table.Column<string>(type: "varchar(450)", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUserTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mVendedores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Codigo = table.Column<string>(type: "character varying(19)", maxLength: 19, nullable: false),
                    Direccion = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Documento = table.Column<string>(type: "character varying(23)", maxLength: 23, nullable: false),
                    Email = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Telefono1 = table.Column<string>(type: "text", nullable: false),
                    Telefono2 = table.Column<string>(type: "text", nullable: false),
                    Telefono3 = table.Column<string>(type: "text", nullable: false),
                    TipoDocumento = table.Column<int>(type: "integer", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mVendedores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mClientes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClasificacionClienteId = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "character varying(19)", maxLength: 19, nullable: false),
                    CondicionPago = table.Column<byte>(type: "smallint", nullable: false),
                    Contacto = table.Column<string>(type: "text", nullable: false),
                    Documento = table.Column<string>(type: "character varying(23)", maxLength: 23, nullable: false),
                    Email = table.Column<string>(type: "character varying(75)", maxLength: 75, nullable: false),
                    LimiteCredito = table.Column<decimal>(type: "numeric", nullable: false),
                    Nombres = table.Column<string>(type: "character varying(40)", maxLength: 40, nullable: false),
                    Telefono1 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Telefono2 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    Telefono3 = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    TipoDocumento = table.Column<int>(type: "integer", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    Referencia = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mClientes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mClientes_mClasificacionesClientes_ClasificacionClienteId",
                        column: x => x.ClasificacionClienteId,
                        principalTable: "mClasificacionesClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mOfertas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cantidad = table.Column<long>(type: "bigint", nullable: false),
                    ClasificacionClienteId = table.Column<long>(type: "bigint", nullable: false),
                    Desde = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Disponibles = table.Column<long>(type: "bigint", nullable: false),
                    Hasta = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Nota = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mOfertas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mOfertas_mClasificacionesClientes_ClasificacionClienteId",
                        column: x => x.ClasificacionClienteId,
                        principalTable: "mClasificacionesClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mProvincias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountryId = table.Column<long>(type: "bigint", nullable: true),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mProvincias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mProvincias_mPaises_CountryId",
                        column: x => x.CountryId,
                        principalTable: "mPaises",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "mProductos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AplicaImpuesto = table.Column<bool>(type: "boolean", nullable: false),
                    AplicaOferta = table.Column<bool>(type: "boolean", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    ContabilidadId = table.Column<string>(type: "text", nullable: false),
                    CuentaContable = table.Column<string>(type: "text", nullable: false),
                    Descripcion = table.Column<string>(type: "text", nullable: false),
                    DescripcionContabilidad = table.Column<string>(type: "text", nullable: false),
                    ImpuestoId = table.Column<long>(type: "bigint", nullable: true),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    PresentacionId = table.Column<long>(type: "bigint", nullable: false),
                    ProductoFamiliaId = table.Column<long>(type: "bigint", nullable: true),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mProductos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mProductos_mImpuestos_ImpuestoId",
                        column: x => x.ImpuestoId,
                        principalTable: "mImpuestos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_mProductos_mPresentaciones_PresentacionId",
                        column: x => x.PresentacionId,
                        principalTable: "mPresentaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mProductos_mProductosFamilias_ProductoFamiliaId",
                        column: x => x.ProductoFamiliaId,
                        principalTable: "mProductosFamilias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "mProveedores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AplicaRetencionImpuesto = table.Column<bool>(type: "boolean", nullable: false),
                    Contacto = table.Column<string>(type: "character varying(60)", maxLength: 60, nullable: false),
                    Documento = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "character varying(150)", maxLength: 150, nullable: false),
                    ImpuestoId = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    Telefono1 = table.Column<string>(type: "text", nullable: false),
                    Telefono2 = table.Column<string>(type: "text", nullable: false),
                    Telefono3 = table.Column<string>(type: "text", nullable: false),
                    TipoDocumento = table.Column<int>(type: "integer", nullable: false),
                    TipoProveedorId = table.Column<long>(type: "bigint", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    Referencia = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mProveedores_mImpuestos_ImpuestoId",
                        column: x => x.ImpuestoId,
                        principalTable: "mImpuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mProveedores_mTiposProveedores_TipoProveedorId",
                        column: x => x.TipoProveedorId,
                        principalTable: "mTiposProveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mTransportistas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    AnioTransporte = table.Column<short>(type: "smallint", nullable: false),
                    CedulaAsistente1 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    CedulaAsistente2 = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    CedulaConductor = table.Column<string>(type: "character varying(11)", maxLength: 11, nullable: false),
                    CompaniaTransporteId = table.Column<long>(type: "bigint", nullable: true),
                    CondicionServicio = table.Column<int>(type: "integer", nullable: false),
                    Ficha = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    Flota = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    GpsTrackingNumber = table.Column<string>(type: "character varying(23)", maxLength: 23, nullable: false),
                    MarcaTransporte = table.Column<string>(type: "text", nullable: false),
                    MovilAsistente1 = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    MovilAsistente2 = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NombreAsistente1 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NombreAsistente2 = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Personal = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    Placa = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    TieneGps = table.Column<bool>(type: "boolean", nullable: false),
                    TransporteId = table.Column<long>(type: "bigint", nullable: true),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mTransportistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mTransportistas_mCompaniasTransportes_CompaniaTransporteId",
                        column: x => x.CompaniaTransporteId,
                        principalTable: "mCompaniasTransportes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_mTransportistas_mTransportes_TransporteId",
                        column: x => x.TransporteId,
                        principalTable: "mTransportes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "mOrdenes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClienteId = table.Column<long>(type: "bigint", nullable: false),
                    ClienteNombre = table.Column<string>(type: "text", nullable: false),
                    Entregar = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Nota = table.Column<string>(type: "text", nullable: false),
                    Numero = table.Column<string>(type: "text", nullable: false),
                    VendedorId = table.Column<long>(type: "bigint", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mOrdenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mOrdenes_mClientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "mClientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mOrdenes_mVendedores_VendedorId",
                        column: x => x.VendedorId,
                        principalTable: "mVendedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mMunicipios",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ProvinceId = table.Column<long>(type: "bigint", nullable: true),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mMunicipios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mMunicipios_mProvincias_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "mProvincias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "mOfertasDetalles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cantidad = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    Impuesto = table.Column<decimal>(type: "numeric", nullable: false),
                    Medida = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    OfertaId = table.Column<long>(type: "bigint", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    ProductoId = table.Column<long>(type: "bigint", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mOfertasDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mOfertasDetalles_mOfertas_OfertaId",
                        column: x => x.OfertaId,
                        principalTable: "mOfertas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mOfertasDetalles_mProductos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "mProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mOrdenesDetalles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cantidad = table.Column<long>(type: "bigint", nullable: false),
                    Descuento = table.Column<decimal>(type: "numeric", nullable: false),
                    Impuesto = table.Column<decimal>(type: "numeric", nullable: false),
                    Medida = table.Column<string>(type: "text", nullable: false),
                    Nombre = table.Column<string>(type: "text", nullable: false),
                    OrdenId = table.Column<long>(type: "bigint", nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    ProductoId = table.Column<long>(type: "bigint", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mOrdenesDetalles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mOrdenesDetalles_mOrdenes_OrdenId",
                        column: x => x.OrdenId,
                        principalTable: "mOrdenes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mOrdenesDetalles_mProductos_ProductoId",
                        column: x => x.ProductoId,
                        principalTable: "mProductos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mAlmacenes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    MunicipioId = table.Column<long>(type: "bigint", nullable: false),
                    Codigo = table.Column<string>(type: "character varying(19)", maxLength: 19, nullable: false),
                    Descripcion = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Direccion = table.Column<string>(type: "text", nullable: false),
                    Referencia = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mAlmacenes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mAlmacenes_mMunicipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "mMunicipios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mZonas",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    EsPredefinido = table.Column<bool>(type: "boolean", nullable: false),
                    MunicipioId = table.Column<long>(type: "bigint", nullable: true),
                    ProvinciaId = table.Column<long>(type: "bigint", nullable: true),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<int>(type: "integer", nullable: false),
                    LastModifiedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    LastModifiedBy = table.Column<long>(type: "bigint", nullable: false),
                    SucursalId = table.Column<long>(type: "bigint", nullable: false),
                    Nombre = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: false),
                    Codigo = table.Column<string>(type: "text", nullable: false),
                    Tipo = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mZonas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mZonas_mMunicipios_MunicipioId",
                        column: x => x.MunicipioId,
                        principalTable: "mMunicipios",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_mZonas_mProvincias_ProvinciaId",
                        column: x => x.ProvinciaId,
                        principalTable: "mProvincias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_mAlmacenes_MunicipioId",
                table: "mAlmacenes",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_mClientes_ClasificacionClienteId",
                table: "mClientes",
                column: "ClasificacionClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_mMunicipios_ProvinceId",
                table: "mMunicipios",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_mOfertas_ClasificacionClienteId",
                table: "mOfertas",
                column: "ClasificacionClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_mOfertasDetalles_OfertaId",
                table: "mOfertasDetalles",
                column: "OfertaId");

            migrationBuilder.CreateIndex(
                name: "IX_mOfertasDetalles_ProductoId",
                table: "mOfertasDetalles",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_mOrdenes_ClienteId",
                table: "mOrdenes",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_mOrdenes_VendedorId",
                table: "mOrdenes",
                column: "VendedorId");

            migrationBuilder.CreateIndex(
                name: "IX_mOrdenesDetalles_OrdenId",
                table: "mOrdenesDetalles",
                column: "OrdenId");

            migrationBuilder.CreateIndex(
                name: "IX_mOrdenesDetalles_ProductoId",
                table: "mOrdenesDetalles",
                column: "ProductoId");

            migrationBuilder.CreateIndex(
                name: "IX_mProductos_ImpuestoId",
                table: "mProductos",
                column: "ImpuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_mProductos_PresentacionId",
                table: "mProductos",
                column: "PresentacionId");

            migrationBuilder.CreateIndex(
                name: "IX_mProductos_ProductoFamiliaId",
                table: "mProductos",
                column: "ProductoFamiliaId");

            migrationBuilder.CreateIndex(
                name: "IX_mProveedores_ImpuestoId",
                table: "mProveedores",
                column: "ImpuestoId");

            migrationBuilder.CreateIndex(
                name: "IX_mProveedores_TipoProveedorId",
                table: "mProveedores",
                column: "TipoProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_mProvincias_CountryId",
                table: "mProvincias",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_mTransportistas_CompaniaTransporteId",
                table: "mTransportistas",
                column: "CompaniaTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_mTransportistas_TransporteId",
                table: "mTransportistas",
                column: "TransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_mZonas_MunicipioId",
                table: "mZonas",
                column: "MunicipioId");

            migrationBuilder.CreateIndex(
                name: "IX_mZonas_ProvinciaId",
                table: "mZonas",
                column: "ProvinciaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mAlmacenes");

            migrationBuilder.DropTable(
                name: "mMonedas");

            migrationBuilder.DropTable(
                name: "mOfertasDetalles");

            migrationBuilder.DropTable(
                name: "mOrdenesDetalles");

            migrationBuilder.DropTable(
                name: "mProveedores");

            migrationBuilder.DropTable(
                name: "mRoleClaims");

            migrationBuilder.DropTable(
                name: "mRoles");

            migrationBuilder.DropTable(
                name: "mSucursales");

            migrationBuilder.DropTable(
                name: "mTransportistas");

            migrationBuilder.DropTable(
                name: "mUserClaims");

            migrationBuilder.DropTable(
                name: "mUserLogins");

            migrationBuilder.DropTable(
                name: "mUsers");

            migrationBuilder.DropTable(
                name: "mUsersRoles");

            migrationBuilder.DropTable(
                name: "mUserTokens");

            migrationBuilder.DropTable(
                name: "mZonas");

            migrationBuilder.DropTable(
                name: "mOfertas");

            migrationBuilder.DropTable(
                name: "mOrdenes");

            migrationBuilder.DropTable(
                name: "mProductos");

            migrationBuilder.DropTable(
                name: "mTiposProveedores");

            migrationBuilder.DropTable(
                name: "mCompaniasTransportes");

            migrationBuilder.DropTable(
                name: "mTransportes");

            migrationBuilder.DropTable(
                name: "mMunicipios");

            migrationBuilder.DropTable(
                name: "mClientes");

            migrationBuilder.DropTable(
                name: "mVendedores");

            migrationBuilder.DropTable(
                name: "mImpuestos");

            migrationBuilder.DropTable(
                name: "mPresentaciones");

            migrationBuilder.DropTable(
                name: "mProductosFamilias");

            migrationBuilder.DropTable(
                name: "mProvincias");

            migrationBuilder.DropTable(
                name: "mClasificacionesClientes");

            migrationBuilder.DropTable(
                name: "mPaises");
        }
    }
}

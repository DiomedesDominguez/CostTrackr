﻿// <auto-generated />
using System;
using DNMOFT.CostTrackR.Web.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DNMOFT.CostTrackR.Web.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(256)");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("mRoles", (string)null);
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mRoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("mRoleClaims", (string)null);
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUser", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(128)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("varchar(15)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("SecurityStamp")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("varchar(128)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("mUsers", (string)null);
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("mUserClaims", (string)null);
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserLogin", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("varchar(450)");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("ProviderDisplayName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("ProviderKeyET")
                        .HasColumnType("timestamp with time zone");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("mUserLogins", (string)null);
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserRole", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<long>("RoleId")
                        .HasColumnType("bigint");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .HasColumnType("bigint");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("mUsersRoles", (string)null);
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserToken", b =>
                {
                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("varchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("varchar(450)");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("mUserTokens", (string)null);
                });

            modelBuilder.Entity("Web.Data.Entities.App.mImpuesto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.Property<decimal>("Tasa")
                        .HasColumnType("numeric");

                    b.HasKey("Id");

                    b.ToTable("mImpuestos", (string)null);
                });

            modelBuilder.Entity("Web.Data.Entities.App.mPresentacion", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<decimal>("Alto")
                        .HasColumnType("numeric");

                    b.Property<decimal>("Ancho")
                        .HasColumnType("numeric");

                    b.Property<short>("Cantidad")
                        .HasColumnType("smallint");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Largo")
                        .HasColumnType("numeric");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Peso")
                        .HasColumnType("numeric");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.HasKey("Id");

                    b.ToTable("mPresentaciones", (string)null);
                });

            modelBuilder.Entity("Web.Data.Entities.App.mProducto", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("AplicaImpuesto")
                        .HasColumnType("boolean");

                    b.Property<bool>("AplicaOferta")
                        .HasColumnType("boolean");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<long?>("ImpuestoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<decimal>("Precio")
                        .HasColumnType("numeric");

                    b.Property<long?>("PresentacionId")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProductoFamiliaId")
                        .HasColumnType("bigint");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.HasKey("Id");

                    b.HasIndex("ImpuestoId");

                    b.HasIndex("PresentacionId");

                    b.HasIndex("ProductoFamiliaId");

                    b.ToTable("mProductos", (string)null);
                });

            modelBuilder.Entity("Web.Data.Entities.App.mProductoFamilia", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("character varying(200)");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.HasKey("Id");

                    b.ToTable("mProductoFamilias", (string)null);
                });

            modelBuilder.Entity("Web.Data.Entities.App.mProveedor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<bool>("AplicaRetencionImpuesto")
                        .HasColumnType("boolean");

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<string>("Contacto")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Documento")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Telefono1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefono2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Telefono3")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<byte>("TipoDocumento")
                        .HasColumnType("smallint");

                    b.Property<long>("TipoProveedorId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("TipoProveedorId");

                    b.ToTable("mProveedores", (string)null);
                });

            modelBuilder.Entity("Web.Data.Entities.App.mTipoProveedor", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnOrder(0);

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<string>("ClientIp")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(15)
                        .HasColumnType("character varying(15)")
                        .HasDefaultValueSql("'127.0.0.1'");

                    b.Property<DateTime>("Created")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("CreatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("character varying(120)");

                    b.Property<long>("ImpuestoId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("LastUpdated")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp with time zone")
                        .HasDefaultValueSql("CURRENT_TIMESTAMP");

                    b.Property<long>("LastUpdatedBy")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasDefaultValueSql("1");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<byte>("RecordState")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("smallint")
                        .HasDefaultValueSql("1");

                    b.HasKey("Id");

                    b.HasIndex("ImpuestoId");

                    b.ToTable("mTipoProveedores", (string)null);
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mRoleClaim", b =>
                {
                    b.HasOne("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserClaim", b =>
                {
                    b.HasOne("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserLogin", b =>
                {
                    b.HasOne("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserRole", b =>
                {
                    b.HasOne("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUserToken", b =>
                {
                    b.HasOne("DNMOFT.CostTrackR.Web.Data.Entities.Identity.mUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Web.Data.Entities.App.mProducto", b =>
                {
                    b.HasOne("Web.Data.Entities.App.mImpuesto", "Impuesto")
                        .WithMany()
                        .HasForeignKey("ImpuestoId");

                    b.HasOne("Web.Data.Entities.App.mPresentacion", "Presentacion")
                        .WithMany()
                        .HasForeignKey("PresentacionId");

                    b.HasOne("Web.Data.Entities.App.mProductoFamilia", "ProductoFamilia")
                        .WithMany()
                        .HasForeignKey("ProductoFamiliaId");

                    b.Navigation("Impuesto");

                    b.Navigation("Presentacion");

                    b.Navigation("ProductoFamilia");
                });

            modelBuilder.Entity("Web.Data.Entities.App.mProveedor", b =>
                {
                    b.HasOne("Web.Data.Entities.App.mTipoProveedor", "TipoProveedor")
                        .WithMany()
                        .HasForeignKey("TipoProveedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TipoProveedor");
                });

            modelBuilder.Entity("Web.Data.Entities.App.mTipoProveedor", b =>
                {
                    b.HasOne("Web.Data.Entities.App.mImpuesto", "Impuesto")
                        .WithMany()
                        .HasForeignKey("ImpuestoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Impuesto");
                });
#pragma warning restore 612, 618
        }
    }
}

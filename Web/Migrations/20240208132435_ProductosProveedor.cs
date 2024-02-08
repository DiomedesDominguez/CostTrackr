using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DNMOFT.CostTrackR.Web.Migrations
{
    /// <inheritdoc />
    public partial class ProductosProveedor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUserTokens",
                type: "smallint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUsersRoles",
                type: "smallint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUsers",
                type: "smallint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUserLogins",
                type: "smallint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUserClaims",
                type: "smallint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mRoles",
                type: "smallint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mRoleClaims",
                type: "smallint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(byte),
                oldType: "smallint");

            migrationBuilder.CreateTable(
                name: "mImpuestos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Tasa = table.Column<decimal>(type: "numeric", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mImpuestos", x => x.Id);
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
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mPresentaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mProductoFamilias",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mProductoFamilias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mTipoProveedores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Descripcion = table.Column<string>(type: "character varying(120)", maxLength: 120, nullable: false),
                    Nombre = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    ImpuestoId = table.Column<long>(type: "bigint", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mTipoProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mTipoProveedores_mImpuestos_ImpuestoId",
                        column: x => x.ImpuestoId,
                        principalTable: "mImpuestos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ImpuestoId = table.Column<long>(type: "bigint", nullable: true),
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Precio = table.Column<decimal>(type: "numeric", nullable: false),
                    PresentacionId = table.Column<long>(type: "bigint", nullable: true),
                    ProductoFamiliaId = table.Column<long>(type: "bigint", nullable: true),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
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
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_mProductos_mProductoFamilias_ProductoFamiliaId",
                        column: x => x.ProductoFamiliaId,
                        principalTable: "mProductoFamilias",
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
                    Nombre = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Telefono1 = table.Column<string>(type: "text", nullable: false),
                    Telefono2 = table.Column<string>(type: "text", nullable: false),
                    Telefono3 = table.Column<string>(type: "text", nullable: false),
                    TipoDocumento = table.Column<byte>(type: "smallint", nullable: false),
                    TipoProveedorId = table.Column<long>(type: "bigint", nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mProveedores", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mProveedores_mTipoProveedores_TipoProveedorId",
                        column: x => x.TipoProveedorId,
                        principalTable: "mTipoProveedores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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
                name: "IX_mProveedores_TipoProveedorId",
                table: "mProveedores",
                column: "TipoProveedorId");

            migrationBuilder.CreateIndex(
                name: "IX_mTipoProveedores_ImpuestoId",
                table: "mTipoProveedores",
                column: "ImpuestoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mProductos");

            migrationBuilder.DropTable(
                name: "mProveedores");

            migrationBuilder.DropTable(
                name: "mPresentaciones");

            migrationBuilder.DropTable(
                name: "mProductoFamilias");

            migrationBuilder.DropTable(
                name: "mTipoProveedores");

            migrationBuilder.DropTable(
                name: "mImpuestos");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUserTokens",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUsersRoles",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUsers",
                type: "smallint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUserLogins",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mUserClaims",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mRoles",
                type: "smallint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<byte>(
                name: "RecordState",
                table: "mRoleClaims",
                type: "smallint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "smallint",
                oldDefaultValueSql: "1");
        }
    }
}

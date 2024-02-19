using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NetTopologySuite.Geometries;

#nullable disable

namespace DNMOFT.CostTrackr.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class Puntos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mZonas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mZonas",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mZonas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mZonas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mZonas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mZonas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mZonas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<MultiPolygon>(
                name: "Coordenadas",
                table: "mZonas",
                type: "geography",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mVendedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mVendedores",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mVendedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mVendedores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mVendedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mVendedores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mVendedores",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUserTokens",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUserTokens",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUserTokens",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUserTokens",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUsersRoles",
                type: "integer",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUsersRoles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUsersRoles",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUsers",
                type: "integer",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUsers",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUsers",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUsers",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUserLogins",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUserLogins",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUserLogins",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUserLogins",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUserClaims",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUserClaims",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUserClaims",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUserClaims",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mTransportistas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mTransportistas",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mTransportistas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mTransportistas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mTransportistas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mTransportistas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mTransportistas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mTransportes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mTransportes",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mTransportes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mTransportes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mTransportes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mTransportes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mTransportes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mTiposProveedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mTiposProveedores",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mTiposProveedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mTiposProveedores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mTiposProveedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mTiposProveedores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mTiposProveedores",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mSucursales",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mSucursales",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mSucursales",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mSucursales",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mSucursales",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mSucursales",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mSucursales",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<Point>(
                name: "Coordenadas",
                table: "mSucursales",
                type: "geography",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mRoles",
                type: "integer",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mRoles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mRoles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mRoles",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mRoleClaims",
                type: "integer",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mRoleClaims",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mRoleClaims",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mRoleClaims",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProvincias",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProvincias",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProvincias",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProvincias",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProvincias",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProvincias",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProvincias",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<MultiPolygon>(
                name: "Coordenadas",
                table: "mProvincias",
                type: "geography",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProveedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProveedores",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProveedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProveedores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProveedores",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProveedores",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProveedores",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<Point>(
                name: "Coordenadas",
                table: "mProveedores",
                type: "geography",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProductosFamilias",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProductosFamilias",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProductosFamilias",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProductosFamilias",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProductosFamilias",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProductosFamilias",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProductosFamilias",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProductos",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProductos",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProductos",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProductos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProductos",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProductos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProductos",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mPresentaciones",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mPresentaciones",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mPresentaciones",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mPresentaciones",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mPresentaciones",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mPresentaciones",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mPresentaciones",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mPaises",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mPaises",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mPaises",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mPaises",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mPaises",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mPaises",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mPaises",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<MultiPolygon>(
                name: "Coordenadas",
                table: "mPaises",
                type: "geography",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOrdenesDetalles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOrdenesDetalles",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOrdenesDetalles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOrdenesDetalles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOrdenesDetalles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOrdenesDetalles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOrdenesDetalles",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOrdenes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOrdenes",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOrdenes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOrdenes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOrdenes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOrdenes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOrdenes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOfertasDetalles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOfertasDetalles",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOfertasDetalles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOfertasDetalles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOfertasDetalles",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOfertasDetalles",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOfertasDetalles",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOfertas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOfertas",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOfertas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOfertas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOfertas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOfertas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOfertas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mMunicipios",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mMunicipios",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mMunicipios",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mMunicipios",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mMunicipios",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mMunicipios",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mMunicipios",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<MultiPolygon>(
                name: "Coordenadas",
                table: "mMunicipios",
                type: "geography",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mMonedas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mMonedas",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mMonedas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mMonedas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mMonedas",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mMonedas",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mMonedas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mImpuestos",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mImpuestos",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mImpuestos",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mImpuestos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mImpuestos",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mImpuestos",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mImpuestos",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mCompaniasTransportes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mCompaniasTransportes",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mCompaniasTransportes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mCompaniasTransportes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mCompaniasTransportes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mCompaniasTransportes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mCompaniasTransportes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mClientes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mClientes",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mClientes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mClientes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mClientes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mClientes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mClientes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<Point>(
                name: "Coordenadas",
                table: "mClientes",
                type: "geography",
                nullable: true);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mClasificacionesClientes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mClasificacionesClientes",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mClasificacionesClientes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mClasificacionesClientes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mClasificacionesClientes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mClasificacionesClientes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mClasificacionesClientes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mAlmacenes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "0",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mAlmacenes",
                type: "integer",
                nullable: false,
                defaultValueSql: "Activo",
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mAlmacenes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mAlmacenes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mAlmacenes",
                type: "bigint",
                nullable: false,
                defaultValueSql: "1",
                oldClrType: typeof(long),
                oldType: "bigint");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mAlmacenes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mAlmacenes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                defaultValueSql: "'127.0.0.1'",
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<Point>(
                name: "Coordenadas",
                table: "mAlmacenes",
                type: "geography",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mZonas");

            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mSucursales");

            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mProvincias");

            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mProveedores");

            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mPaises");

            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mMunicipios");

            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mClientes");

            migrationBuilder.DropColumn(
                name: "Coordenadas",
                table: "mAlmacenes");

            migrationBuilder.AlterDatabase()
                .OldAnnotation("Npgsql:PostgresExtension:postgis", ",,");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mZonas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mZonas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mZonas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mZonas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mZonas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mZonas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mZonas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mVendedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mVendedores",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mVendedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mVendedores",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mVendedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mVendedores",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mVendedores",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUserTokens",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUserTokens",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUserTokens",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUserTokens",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUsersRoles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUsersRoles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUsersRoles",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUsers",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUsers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUsers",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUsers",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUserLogins",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUserLogins",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUserLogins",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUserLogins",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mUserClaims",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mUserClaims",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mUserClaims",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mUserClaims",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mTransportistas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mTransportistas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mTransportistas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mTransportistas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mTransportistas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mTransportistas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mTransportistas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mTransportes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mTransportes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mTransportes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mTransportes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mTransportes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mTransportes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mTransportes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mTiposProveedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mTiposProveedores",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mTiposProveedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mTiposProveedores",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mTiposProveedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mTiposProveedores",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mTiposProveedores",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mSucursales",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mSucursales",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mSucursales",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mSucursales",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mSucursales",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mSucursales",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mSucursales",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mRoles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mRoles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mRoles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mRoles",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mRoleClaims",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "LastUpdatedBy",
                table: "mRoleClaims",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mRoleClaims",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mRoleClaims",
                type: "varchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProvincias",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProvincias",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProvincias",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProvincias",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProvincias",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProvincias",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProvincias",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProveedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProveedores",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProveedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProveedores",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProveedores",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProveedores",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProveedores",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProductosFamilias",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProductosFamilias",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProductosFamilias",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProductosFamilias",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProductosFamilias",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProductosFamilias",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProductosFamilias",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mProductos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mProductos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mProductos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mProductos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mProductos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mProductos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mProductos",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mPresentaciones",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mPresentaciones",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mPresentaciones",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mPresentaciones",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mPresentaciones",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mPresentaciones",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mPresentaciones",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mPaises",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mPaises",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mPaises",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mPaises",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mPaises",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mPaises",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mPaises",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOrdenesDetalles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOrdenesDetalles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOrdenesDetalles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOrdenesDetalles",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOrdenesDetalles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOrdenesDetalles",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOrdenesDetalles",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOrdenes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOrdenes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOrdenes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOrdenes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOrdenes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOrdenes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOrdenes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOfertasDetalles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOfertasDetalles",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOfertasDetalles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOfertasDetalles",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOfertasDetalles",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOfertasDetalles",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOfertasDetalles",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mOfertas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mOfertas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mOfertas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mOfertas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mOfertas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mOfertas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mOfertas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mMunicipios",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mMunicipios",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mMunicipios",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mMunicipios",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mMunicipios",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mMunicipios",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mMunicipios",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mMonedas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mMonedas",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mMonedas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mMonedas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mMonedas",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mMonedas",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mMonedas",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mImpuestos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mImpuestos",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mImpuestos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mImpuestos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mImpuestos",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mImpuestos",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mImpuestos",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mCompaniasTransportes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mCompaniasTransportes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mCompaniasTransportes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mCompaniasTransportes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mCompaniasTransportes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mCompaniasTransportes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mCompaniasTransportes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mClientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mClientes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mClientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mClientes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mClientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mClientes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mClientes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mClasificacionesClientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mClasificacionesClientes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mClasificacionesClientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mClasificacionesClientes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mClasificacionesClientes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mClasificacionesClientes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mClasificacionesClientes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");

            migrationBuilder.AlterColumn<long>(
                name: "SucursalId",
                table: "mAlmacenes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "0");

            migrationBuilder.AlterColumn<int>(
                name: "RecordState",
                table: "mAlmacenes",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer",
                oldDefaultValueSql: "Activo");

            migrationBuilder.AlterColumn<long>(
                name: "LastModifiedBy",
                table: "mAlmacenes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "LastModifiedAt",
                table: "mAlmacenes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<long>(
                name: "CreatedBy",
                table: "mAlmacenes",
                type: "bigint",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldDefaultValueSql: "1");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedAt",
                table: "mAlmacenes",
                type: "timestamp with time zone",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "timestamp with time zone",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");

            migrationBuilder.AlterColumn<string>(
                name: "ClientIp",
                table: "mAlmacenes",
                type: "character varying(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(15)",
                oldMaxLength: 15,
                oldDefaultValueSql: "'127.0.0.1'");
        }
    }
}

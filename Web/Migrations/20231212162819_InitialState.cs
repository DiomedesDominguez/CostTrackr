using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DNMOFT.CostTrackr.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialState : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "text", nullable: false),
                    ClaimValue = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", nullable: false),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaimType = table.Column<string>(type: "text", nullable: false),
                    ClaimValue = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginProvider = table.Column<string>(type: "varchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "varchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    ProviderKeyET = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "varchar(128)", nullable: false),
                    NormalizedEmail = table.Column<string>(type: "varchar(128)", nullable: false),
                    NormalizedUserName = table.Column<string>(type: "varchar(128)", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "varchar(128)", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
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
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginProvider = table.Column<string>(type: "varchar(450)", nullable: false),
                    Name = table.Column<string>(type: "varchar(450)", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "tinyint", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "SYSDATETIME()"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUserTokens", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mRoleClaims");

            migrationBuilder.DropTable(
                name: "mRoles");

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
        }
    }
}

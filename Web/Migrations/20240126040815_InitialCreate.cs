using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DNMOFT.CostTrackR.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "mRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    NormalizedName = table.Column<string>(type: "varchar(256)", maxLength: 256, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "mUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: false),
                    Email = table.Column<string>(type: "varchar(128)", maxLength: 256, nullable: false),
                    NormalizedEmail = table.Column<string>(type: "varchar(128)", maxLength: 256, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "varchar(128)", maxLength: 256, nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: false),
                    PhoneNumber = table.Column<string>(type: "varchar(15)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "text", nullable: false),
                    UserName = table.Column<string>(type: "varchar(128)", maxLength: 256, nullable: false),
                    ClientIp = table.Column<string>(type: "character varying(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
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
                name: "mRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClaimType = table.Column<string>(type: "text", nullable: false),
                    ClaimValue = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mRoleClaims_mRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "mRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ClaimType = table.Column<string>(type: "text", nullable: false),
                    ClaimValue = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_mUserClaims_mUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "mUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    ProviderKeyET = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_mUserLogins_mUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "mUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mUsersRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUsersRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_mUsersRoles_mRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "mRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_mUsersRoles_mUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "mUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "mUserTokens",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "varchar(450)", nullable: false),
                    Name = table.Column<string>(type: "varchar(450)", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: false),
                    ClientIp = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, defaultValueSql: "'127.0.0.1'"),
                    Created = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    CreatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1"),
                    RecordState = table.Column<byte>(type: "smallint", nullable: false, defaultValueSql: "1"),
                    LastUpdated = table.Column<DateTime>(type: "timestamp with time zone", nullable: false, defaultValueSql: "CURRENT_TIMESTAMP"),
                    LastUpdatedBy = table.Column<long>(type: "bigint", nullable: false, defaultValueSql: "1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_mUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_mUserTokens_mUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "mUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_mRoleClaims_RoleId",
                table: "mRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "mRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mUserClaims_UserId",
                table: "mUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_mUserLogins_UserId",
                table: "mUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "mUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "mUsers",
                column: "NormalizedUserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_mUsersRoles_RoleId",
                table: "mUsersRoles",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "mRoleClaims");

            migrationBuilder.DropTable(
                name: "mUserClaims");

            migrationBuilder.DropTable(
                name: "mUserLogins");

            migrationBuilder.DropTable(
                name: "mUsersRoles");

            migrationBuilder.DropTable(
                name: "mUserTokens");

            migrationBuilder.DropTable(
                name: "mRoles");

            migrationBuilder.DropTable(
                name: "mUsers");
        }
    }
}

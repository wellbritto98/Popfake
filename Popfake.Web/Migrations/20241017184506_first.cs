using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Popfake.Web.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "text", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: false),
                    RegisteredAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastLoginAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    RefreshToken = table.Column<string>(type: "text", nullable: false),
                    TokenExpiredAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    TokenCreatedAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    UserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "character varying(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Examples",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Nickname = table.Column<string>(type: "text", nullable: false),
                    IsConfirmed = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Examples", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    ClaimType = table.Column<string>(type: "text", nullable: true),
                    ClaimValue = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    ProviderKey = table.Column<string>(type: "text", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "text", nullable: true),
                    UserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    RoleId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "text", nullable: false),
                    LoginProvider = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Value = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7210", null, "Admin", "ADMIN" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", null, "Player", "PLAYER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2b665870-4139-4d36-9233-0b41cd0f26af", 0, "b6eaf083-d67a-4748-a4f8-62f3419dd94b", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEOlvjRR0CE/gJBTE0OcrHxFMq6cdFcXXjLMXoGt55nZM0im/B2aq5Kw4rdsCmb1ZHw==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 4, 497, DateTimeKind.Local).AddTicks(5844), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1" },
                    { "39566a1f-91f3-4708-96dd-38fc12a78707", 0, "d31e092b-68d4-4c58-8c67-1dc2754ca679", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEDnBuIAs9TuETfE3jXb1UFGDwsetVN2oFEpGXPaPDHePQGTieV8ueRi7oLVoXtDngg==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 4, 651, DateTimeKind.Local).AddTicks(9230), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3" },
                    { "54c179bd-540c-46a1-b4ce-fdea68c26ebc", 0, "17987e02-115e-4007-ac82-71fed3bded63", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEAIB6k/1PyJOiS+0q9pysJHeCFZShoV0HUYZQUspr1/Wekm8njY0Z8U6cD1j2Dlfwg==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 5, 285, DateTimeKind.Local).AddTicks(9692), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11" },
                    { "5e662d08-1502-4d1c-b60a-4b9e768a58ef", 0, "beec3b5f-7409-4a84-bca6-d6eb349a7e38", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAECb5MV/oA3DXEQDO/+sT3rSuMWaGF03K9GTNQQKBCRaDvDCO4sS6VACqt7BUJH9idQ==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 5, 222, DateTimeKind.Local).AddTicks(5885), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10" },
                    { "73c95ae4-9fb7-42c4-84d4-52feb684c5bf", 0, "42f7625c-777d-483e-9232-e39c3ada0efa", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEDS0yTODfidTbo3uXZ/MxDlt51IAxxug5BEZr/wnaOOMs0EqPQAEq9jUDLNwwrrQxA==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 5, 354, DateTimeKind.Local).AddTicks(8570), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12" },
                    { "b8eab33b-95b4-4c41-a61e-b983c63c333b", 0, "00372b98-f418-434f-a7ae-da39cae60453", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEPgI2B2HolUXi8UZTwW8hPjUsnHmj4l/9vl34Y72T1F2rxU7nXeq8yx/bWizUZY/zA==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 4, 810, DateTimeKind.Local).AddTicks(2743), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5" },
                    { "becc1b23-3b7b-4fee-8d20-a901af8fb9f4", 0, "8aae7036-2df6-4bf6-9df4-636c7fcbf9fd", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEDakM2kWXK7NGY7+fkoW/aSkfPIE6mBG02KFFR7kulFmF8X7+N226p034148HVN8RA==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 5, 56, DateTimeKind.Local).AddTicks(5706), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8" },
                    { "c0922dcb-bcff-46e2-9776-aa3a85771bea", 0, "3312575b-2121-4584-a0b8-e13bc9f231e3", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEHcZrW2PODsMPSyiISOjHDlFGH1tfrJ9OFFTNREiw3klIyrWuU5m/b+u9NirVo6oMw==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 4, 888, DateTimeKind.Local).AddTicks(8278), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6" },
                    { "c3eafd02-5d0a-4bf5-ad7e-cd6ff4b72dff", 0, "c7c01fa5-e87b-4de9-b90f-5810fa23cca2", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEHZG7c958pVDTK/CtcLtCLNUtdXqWyTaUboY+2mnNksQYYPwn5XZNoZ0HVVZELY3Dw==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 4, 969, DateTimeKind.Local).AddTicks(2437), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7" },
                    { "e0ec491f-7364-4bc4-9bbd-4c4feb1a0d59", 0, "ca999c77-5bea-42ef-9010-59f9583354ee", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEHFdhhbCv8VbrzipUjsYMAjFSQqihnpP92wEnAb2jRS/xebTfPd6vSRM5X6tq/IEcA==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 4, 570, DateTimeKind.Local).AddTicks(5468), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2" },
                    { "e5131fbe-d6bd-4909-b776-01a5080608c6", 0, "c5ebe607-d97f-4db0-a8a4-ae386c5012c9", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEBe7Ck+Zvmo/CPkffnpD9YZuftKN3A7oIst/TCzEJOwAyLubNV6P+s9WS0vxHS15eQ==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 4, 726, DateTimeKind.Local).AddTicks(9639), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4" },
                    { "effe6692-97c6-4857-a91e-4f1a1c168331", 0, "9d35e97c-d777-4919-b534-3cb1bd02fe04", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEM7SIHdffYIZZNePmzntGNyU2qJZMeJCNgB6THyQynwugDC45ioqPK3ZnkYU6nosoA==", null, false, "", new DateTime(2024, 10, 17, 15, 45, 5, 137, DateTimeKind.Local).AddTicks(7106), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9" }
                });

            migrationBuilder.InsertData(
                table: "Examples",
                columns: new[] { "Id", "IsConfirmed", "Name", "Nickname" },
                values: new object[,]
                {
                    { 1, true, "Example1", "Example1Nickname" },
                    { 2, true, "Example2", "Example2Nickname" },
                    { 3, true, "Example3", "Example3Nickname" },
                    { 4, true, "Example4", "Example4Nickname" },
                    { 5, true, "Example5", "Example5Nickname" },
                    { 6, true, "Example6", "Example6Nickname" },
                    { 7, true, "Example7", "Example7Nickname" },
                    { 8, true, "Example8", "Example8Nickname" },
                    { 9, true, "Example9", "Example9Nickname" },
                    { 10, true, "Example10", "Example10Nickname" },
                    { 11, true, "Example11", "Example11Nickname" },
                    { 12, true, "Example12", "Example12Nickname" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2b665870-4139-4d36-9233-0b41cd0f26af" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "39566a1f-91f3-4708-96dd-38fc12a78707" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "54c179bd-540c-46a1-b4ce-fdea68c26ebc" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5e662d08-1502-4d1c-b60a-4b9e768a58ef" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "73c95ae4-9fb7-42c4-84d4-52feb684c5bf" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b8eab33b-95b4-4c41-a61e-b983c63c333b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "becc1b23-3b7b-4fee-8d20-a901af8fb9f4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c0922dcb-bcff-46e2-9776-aa3a85771bea" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c3eafd02-5d0a-4bf5-ad7e-cd6ff4b72dff" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e0ec491f-7364-4bc4-9bbd-4c4feb1a0d59" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e5131fbe-d6bd-4909-b776-01a5080608c6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "effe6692-97c6-4857-a91e-4f1a1c168331" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Examples");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}

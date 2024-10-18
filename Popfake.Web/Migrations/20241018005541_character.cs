using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Popfake.Web.Migrations
{
    /// <inheritdoc />
    public partial class character : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2a2d279a-312a-483a-bc9e-33862dd314c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2b92c805-9fdc-462a-91f3-160725d6765e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3b7e8c8a-6ce8-44ae-911c-7abc11d395ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4ca05bdf-b135-487c-8c0b-ef4fc57c7814" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5069fa6d-2fff-4bba-96a0-e426d1a79b9b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7e57f799-713e-4bf4-953f-945b3204ff77" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9f575272-747a-44db-8bbb-f8bb561bf27c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b4612ab7-ea68-4643-ba51-ef57811cc1b4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ca5292db-af9b-436b-bee0-1442c5a063d6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dd4ea94b-6d5a-47c2-834d-6a9afd6dfd25" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f0fdb552-87ae-436d-9513-fa7ffc8eee86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fe704b79-6812-402d-aef4-5a73ed73a1a6" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2a2d279a-312a-483a-bc9e-33862dd314c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2b92c805-9fdc-462a-91f3-160725d6765e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b7e8c8a-6ce8-44ae-911c-7abc11d395ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ca05bdf-b135-487c-8c0b-ef4fc57c7814");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5069fa6d-2fff-4bba-96a0-e426d1a79b9b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7e57f799-713e-4bf4-953f-945b3204ff77");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9f575272-747a-44db-8bbb-f8bb561bf27c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4612ab7-ea68-4643-ba51-ef57811cc1b4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca5292db-af9b-436b-bee0-1442c5a063d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dd4ea94b-6d5a-47c2-834d-6a9afd6dfd25");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f0fdb552-87ae-436d-9513-fa7ffc8eee86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe704b79-6812-402d-aef4-5a73ed73a1a6");

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    UserId = table.Column<string>(type: "text", nullable: false),
                    FirstName = table.Column<string>(type: "text", nullable: false),
                    LastName = table.Column<string>(type: "text", nullable: false),
                    Age = table.Column<int>(type: "integer", nullable: false),
                    Gender = table.Column<string>(type: "text", nullable: false),
                    BirthAt = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    BirthCityId = table.Column<int>(type: "integer", nullable: false),
                    CurrentLocationId = table.Column<int>(type: "integer", nullable: false),
                    Money = table.Column<decimal>(type: "numeric(20,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Cities_BirthCityId",
                        column: x => x.BirthCityId,
                        principalTable: "Cities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Characters_Locations_CurrentLocationId",
                        column: x => x.CurrentLocationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "16efe0d6-0861-4158-8d79-8fd843df1b43", 0, "d18a2b28-8d6e-4857-af8a-2a617cb0460b", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEEitTwxH9IpuV2Gw82qW+RBlE8lgTmpthzAiwlTbmQzcpoNrzCj8i8d3C/AEVwUTBQ==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 700, DateTimeKind.Local).AddTicks(8806), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6" },
                    { "26785317-8588-41cc-b7d6-306baee8f701", 0, "8be3b3ab-9c76-4a66-be7c-f332c4518084", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEIJ8uWfsPWK69Wso0IdZrFny4suKpdOvdVgyR2Y2Hk6Daw6PEt5XoTtjCHsrt1do/g==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 993, DateTimeKind.Local).AddTicks(838), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9" },
                    { "369e8d26-827d-4f6e-8c75-a400067a9862", 0, "9615ea48-1d6d-437a-82ea-dfc5d3e8702d", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEFpBEJceMXVcd2z0B8W9wb16pkcAZz3siNFdtdfEpZ3GyLu0VwxfD1TFi9Y+L64pog==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 323, DateTimeKind.Local).AddTicks(9130), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2" },
                    { "4ecc5574-10bb-4990-98e0-4b3d9f617ea4", 0, "dde2eb87-7a2b-44fb-8fce-a056a2f57500", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEDUeZojQTOmNzakpw2ohLroHcMAb0Ibys8Y9f55oDuDICtRXTY87mMg5mwhpwFOK2A==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 899, DateTimeKind.Local).AddTicks(7839), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8" },
                    { "63a85d3f-8277-49f9-b7e8-81cf048e9a14", 0, "0f8ac778-809a-494c-a49c-6568f9d0b472", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEB85Eo9OHr7udUDZ7BvVW0exo+92iDoX/oEkkD+KQyeRHySdtWvwR7+HADbmOgtmdw==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 40, 79, DateTimeKind.Local).AddTicks(3872), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10" },
                    { "716a0d58-9ad1-4baf-a7d5-b88bd482115b", 0, "c07d2b83-62b6-4c48-a2ad-8ddedfdcdd8f", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEGbVsFoHpgXWMicubhc2k78thLBK/dwgPfMyUfsWgssQVTmaBrNIFwBeMOaGSmmAMg==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 805, DateTimeKind.Local).AddTicks(9042), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7" },
                    { "8558a099-c184-426c-aea8-fe3b5ff21096", 0, "c6c0ec49-6999-49d5-86c9-4ee646b3c407", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEIXcJ+0/CU0PjV94uh44vifKjW8fI9Mg4zz/lW9+FwR7VbjkklXEiEdLOZq+nbZREw==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 598, DateTimeKind.Local).AddTicks(4286), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5" },
                    { "8d23cbfa-0874-49e1-9aa8-bbc005ef466d", 0, "a2fb56ca-c9ad-4780-9a24-f25e29646018", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEHyjzK7dG+4OZUNAGhVRP7H4uLITF8fcpl6ahZ2U8eNQNLEF58eicwFK1fRlkKlQQQ==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 513, DateTimeKind.Local).AddTicks(8803), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4" },
                    { "8ff855ad-2ae1-494c-baf3-0f11a4a1b98c", 0, "4de07bfa-eb8a-4680-94e4-38ba34f3ab2b", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEA4SXzIxVe13cFi/EaIsNPeDqsATjmElq4+l5uhFSW/fOArK9fuXcFJNjkya0Zd+/Q==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 40, 167, DateTimeKind.Local).AddTicks(2554), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11" },
                    { "b6b8f43a-53b1-4594-bd9b-4820b87740f6", 0, "cc5a568e-f109-40d1-a8b3-5fa997684cde", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEInL7rbOAy3c3lvebbPGgdqQPyutCgXexMFEv1I4KTe7egeYddwqIdCrhjbwlpkJ9A==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 237, DateTimeKind.Local).AddTicks(404), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1" },
                    { "c020e8a0-0c2c-4f0f-a891-56a4bc84a316", 0, "16cc6165-6978-4c62-ac2a-98cbe11f909e", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEA059jQ8LYNKpzrFkK94rfWrlzNVurYq3ytuvYRdb3dMZhqdoWHc+32LZBDfMfFupw==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 39, 420, DateTimeKind.Local).AddTicks(3100), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3" },
                    { "d03337a6-136f-4b63-b2a3-a13c789066b8", 0, "a172b600-d3c3-4fe1-8465-03ba3764c46b", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEJfWH9I3uF4bGOCjKJHg7Brj9yoPZfNQBesc4sd6HSbDij4EScfg4lbH3lItwE/XvQ==", null, false, "", new DateTime(2024, 10, 17, 21, 55, 40, 260, DateTimeKind.Local).AddTicks(4690), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "16efe0d6-0861-4158-8d79-8fd843df1b43" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "26785317-8588-41cc-b7d6-306baee8f701" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "369e8d26-827d-4f6e-8c75-a400067a9862" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4ecc5574-10bb-4990-98e0-4b3d9f617ea4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "63a85d3f-8277-49f9-b7e8-81cf048e9a14" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "716a0d58-9ad1-4baf-a7d5-b88bd482115b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8558a099-c184-426c-aea8-fe3b5ff21096" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8d23cbfa-0874-49e1-9aa8-bbc005ef466d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8ff855ad-2ae1-494c-baf3-0f11a4a1b98c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b6b8f43a-53b1-4594-bd9b-4820b87740f6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c020e8a0-0c2c-4f0f-a891-56a4bc84a316" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d03337a6-136f-4b63-b2a3-a13c789066b8" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Characters_BirthCityId",
                table: "Characters",
                column: "BirthCityId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_CurrentLocationId",
                table: "Characters",
                column: "CurrentLocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_UserId",
                table: "Characters",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "16efe0d6-0861-4158-8d79-8fd843df1b43" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "26785317-8588-41cc-b7d6-306baee8f701" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "369e8d26-827d-4f6e-8c75-a400067a9862" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4ecc5574-10bb-4990-98e0-4b3d9f617ea4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "63a85d3f-8277-49f9-b7e8-81cf048e9a14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "716a0d58-9ad1-4baf-a7d5-b88bd482115b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8558a099-c184-426c-aea8-fe3b5ff21096" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8d23cbfa-0874-49e1-9aa8-bbc005ef466d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8ff855ad-2ae1-494c-baf3-0f11a4a1b98c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b6b8f43a-53b1-4594-bd9b-4820b87740f6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c020e8a0-0c2c-4f0f-a891-56a4bc84a316" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d03337a6-136f-4b63-b2a3-a13c789066b8" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "16efe0d6-0861-4158-8d79-8fd843df1b43");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "26785317-8588-41cc-b7d6-306baee8f701");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "369e8d26-827d-4f6e-8c75-a400067a9862");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ecc5574-10bb-4990-98e0-4b3d9f617ea4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63a85d3f-8277-49f9-b7e8-81cf048e9a14");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "716a0d58-9ad1-4baf-a7d5-b88bd482115b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8558a099-c184-426c-aea8-fe3b5ff21096");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d23cbfa-0874-49e1-9aa8-bbc005ef466d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ff855ad-2ae1-494c-baf3-0f11a4a1b98c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6b8f43a-53b1-4594-bd9b-4820b87740f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c020e8a0-0c2c-4f0f-a891-56a4bc84a316");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d03337a6-136f-4b63-b2a3-a13c789066b8");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2a2d279a-312a-483a-bc9e-33862dd314c4", 0, "a0f015f5-1f48-47e5-ad96-2ef3bc1c3934", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEMhfNt/92WIuEKt8tXnW3VD7P2tWK69s+5JfgJToicZ+6SDDxnFFfU/hDN47wJQyGQ==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 19, 521, DateTimeKind.Local).AddTicks(3478), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3" },
                    { "2b92c805-9fdc-462a-91f3-160725d6765e", 0, "8c477ed1-ccc9-4a43-8f93-bc2cad4d9b20", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEAj4+W88JgIWcqloUN9UneARfLsebR4KoTUqenL4XPxnB7wNJE9CiQyUJ5cLiZdfZQ==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 19, 723, DateTimeKind.Local).AddTicks(6994), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4" },
                    { "3b7e8c8a-6ce8-44ae-911c-7abc11d395ce", 0, "12fe616f-7169-4b90-ad7e-bb19609f960d", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEBe9wwmRU1VCPWcyGE2tEvP9VllfAYEdQO/jc0Xw/gWBxI5lbPQ15kH8uCP/9n6JBA==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 19, 291, DateTimeKind.Local).AddTicks(8052), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1" },
                    { "4ca05bdf-b135-487c-8c0b-ef4fc57c7814", 0, "f0ef6883-e651-46f2-8201-2c3a0d3fab73", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEAvZxE9ZiusV4LRA3siR5n1XUN1rqM31v8YD93Ybqn5XoNx6WP/mcCbayHjVoNTBGw==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 19, 952, DateTimeKind.Local).AddTicks(2157), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6" },
                    { "5069fa6d-2fff-4bba-96a0-e426d1a79b9b", 0, "a55ce246-3d54-4eb1-bc80-e9450de91b59", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEOTJq8CZJ+YLNFQs1D/AZGr1iX1oZNf8jcFNmFJUEO8lxHI3fopaIxGmKEggTNt6jw==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 20, 362, DateTimeKind.Local).AddTicks(1593), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10" },
                    { "7e57f799-713e-4bf4-953f-945b3204ff77", 0, "247b222a-aaa5-4dba-b65a-006d4d73c6d5", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEEzeTs67uXFVgXgMy4r137DpUxCR9fToMwyzned+NJ3agI7DgwYxgYWrOIOlVW0cog==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 19, 839, DateTimeKind.Local).AddTicks(9870), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5" },
                    { "9f575272-747a-44db-8bbb-f8bb561bf27c", 0, "bc855fb6-0879-477b-9c57-d8d091121509", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEIVjODHb7MiyCgd/azwPFc6pzZ46gv1YKdM7yDVlR3SPLdLnYnizt/A832PnOieSLg==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 20, 592, DateTimeKind.Local).AddTicks(177), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11" },
                    { "b4612ab7-ea68-4643-ba51-ef57811cc1b4", 0, "64f2d626-2616-48de-94a3-4aaa3625a4d0", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEHhQDMaplup25n7gPEcjKkIsMlaPN5E5ZnKCp3Opjj8mVE7q4n2lvIRYOm52DMKX4g==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 19, 392, DateTimeKind.Local).AddTicks(453), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2" },
                    { "ca5292db-af9b-436b-bee0-1442c5a063d6", 0, "68d6c286-b0d3-43a3-bd97-dd2d15e11c71", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEGe3UMUiEKHVBw+zUezsqqrSuV+8gqy5xn+zdmnMvHB7FEyywcmSzo2NOPshV5PB2w==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 20, 218, DateTimeKind.Local).AddTicks(3016), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9" },
                    { "dd4ea94b-6d5a-47c2-834d-6a9afd6dfd25", 0, "379aac84-74b3-4f50-8d73-81beeee3ebe3", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEBgCCB6oC0q9929SeaczCiHCB0gr9ZJUnnEDVd5TZM+NwVkRn+PRz0jIf6PH4X4GzA==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 20, 795, DateTimeKind.Local).AddTicks(372), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12" },
                    { "f0fdb552-87ae-436d-9513-fa7ffc8eee86", 0, "582acad3-2ae1-4173-a5a0-75e9e472c2f3", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEEn8dTMJJZcr84pUqftM+VD6ExbG6qOmRFEicgoMnap9GWC5qsOLP1JikMlWE3U37g==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 20, 39, DateTimeKind.Local).AddTicks(7303), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7" },
                    { "fe704b79-6812-402d-aef4-5a73ed73a1a6", 0, "b45135f1-d428-444e-819d-a481cf268e36", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEDZP7P8nEKydpHbbNovTq8pblifSVTgcBh7WQJDft/DbBFu8mxKY755LkPxgWzbfxQ==", null, false, "", new DateTime(2024, 10, 17, 21, 36, 20, 142, DateTimeKind.Local).AddTicks(9433), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2a2d279a-312a-483a-bc9e-33862dd314c4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2b92c805-9fdc-462a-91f3-160725d6765e" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3b7e8c8a-6ce8-44ae-911c-7abc11d395ce" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "4ca05bdf-b135-487c-8c0b-ef4fc57c7814" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "5069fa6d-2fff-4bba-96a0-e426d1a79b9b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7e57f799-713e-4bf4-953f-945b3204ff77" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "9f575272-747a-44db-8bbb-f8bb561bf27c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b4612ab7-ea68-4643-ba51-ef57811cc1b4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ca5292db-af9b-436b-bee0-1442c5a063d6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dd4ea94b-6d5a-47c2-834d-6a9afd6dfd25" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f0fdb552-87ae-436d-9513-fa7ffc8eee86" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "fe704b79-6812-402d-aef4-5a73ed73a1a6" }
                });
        }
    }
}

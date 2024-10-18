using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Popfake.Web.Migrations
{
    /// <inheritdoc />
    public partial class seeders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Examples",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Examples",
                keyColumn: "Id",
                keyValue: 12);

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

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Locations",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "CompanyShareholders",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "integer", nullable: false),
                    CompanyId = table.Column<int>(type: "integer", nullable: false),
                    Shares = table.Column<int>(type: "integer", nullable: false),
                    IsPresident = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyShareholders", x => new { x.CharacterId, x.CompanyId });
                    table.ForeignKey(
                        name: "FK_CompanyShareholders_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CompanyShareholders_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09dff3e7-6075-4574-bbaa-33542ac27232", 0, "1e41deff-741a-4ce2-89d8-fb91a590cb46", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAELtAcsVCNB5ZhFOwdjK+bzqkHsHezMae/Xw4YEAVP4q/XX5X7aNcDMNm1t2isgkQrw==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 977, DateTimeKind.Local).AddTicks(7397), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12" },
                    { "1", 0, "c02b4ff6-8743-43c3-99ff-74c7be914726", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "userunique1@email.com", true, null, false, null, "User One", "USERUNIQUE1@EMAIL.COM", "USERUNIQUE1", "AQAAAAIAAYagAAAAEOs9qjl2vhsV3tEYrsIaVD5fO/JsL0VPtfncutbvXhYs/avFgkoxw0ITGJjEUc8fvQ==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 17, 51, DateTimeKind.Local).AddTicks(3948), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "userunique1" },
                    { "14ad6a2b-61f9-4616-bbc1-807f9cc4f6ee", 0, "64e1641d-3c33-44a3-b6ed-295a7003bdbb", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEGLpzYuHJ3e9+R11r9pd10puKkW6iy8u5Ajow7Crgnb/n8sxMbdImhp/GvG+G1aO+w==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 658, DateTimeKind.Local).AddTicks(9267), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8" },
                    { "1c4a2486-1bf7-434a-b8db-cbdbda4db39f", 0, "f8ca7c93-ce36-44cc-b5b8-110da0ebe6d9", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEIj+q5zqPLhpzOLqq/i20dBZJsdQ8+zCYJO4NQUXFfevS1eRX26TVkSDzXK1QBZPgw==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 907, DateTimeKind.Local).AddTicks(4304), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11" },
                    { "2", 0, "d8f61ffe-cd75-4285-9f21-30530157b029", new DateTime(1985, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "userunique2@email.com", true, null, false, null, "User Two", "USERUNIQUE2@EMAIL.COM", "USERUNIQUE2", "AQAAAAIAAYagAAAAEEJUTGdiVrsjyIPc8ppIqzNcecNnB4FUaey/RD0zKUGCX3YaDdTDLSUlPmOzUio7lg==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 17, 120, DateTimeKind.Local).AddTicks(4181), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "userunique2" },
                    { "2095afb8-6d22-4449-a267-083ac1de4af6", 0, "97c72ffb-04c5-42aa-a579-06681bc7b0e5", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEPEAjKZABJ28dHz9iESYPMnzFTI+UgPJ++GCGAO50fkvbH876aetVRvfB71OSAllDg==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 569, DateTimeKind.Local).AddTicks(1608), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7" },
                    { "3", 0, "5fe6e981-7cda-44df-a2d3-9e56cacfa43b", new DateTime(1990, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "userunique3@email.com", true, null, false, null, "User Three", "USERUNIQUE3@EMAIL.COM", "USERUNIQUE3", "AQAAAAIAAYagAAAAEE/TWo9kKZx7ZEtqY2fFNES5Cb684VQUOJvrFteFVneCjM0AD14PLICrAq1p/ZZM0w==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 17, 187, DateTimeKind.Local).AddTicks(9036), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "userunique3" },
                    { "4", 0, "e8733d88-2d67-44a8-8d87-0a325499f617", new DateTime(1995, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "userunique4@email.com", true, null, false, null, "User Four", "USERUNIQUE4@EMAIL.COM", "USERUNIQUE4", "AQAAAAIAAYagAAAAEE/Qg6vX1/LxXXob0Ceq4X3EGHhHvejTDdaBuAB9utEDSQMjPWe2OQJiw6pPzXxpRw==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 17, 258, DateTimeKind.Local).AddTicks(7269), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "userunique4" },
                    { "63008a46-2e3c-47b5-b282-2f930e964840", 0, "b94cc6ec-2360-40b1-bf71-3683dbae0a24", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAECYqu67XNCiVwqdKMdvi9EZpTYE7W3BrLlAvV97rf2v9WEg5YYg6h/hTYDxhizViAA==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 486, DateTimeKind.Local).AddTicks(4182), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6" },
                    { "70479475-148c-443f-a852-bbd62044b6ca", 0, "9466fdac-7c65-4c89-bc3b-4662d1b27507", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEISV2TzHjgosQHWjWARNLH8roVEjsG+4bED3EmGUWW1UqAwzQpzqZ8q3D8jKjvopAA==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 313, DateTimeKind.Local).AddTicks(264), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4" },
                    { "80d9a8b9-01ac-415b-b418-ec1e963fc168", 0, "14d1cce4-3e39-4c26-aa7c-9580401234b2", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEDxTvk+aqtCA9Hax5e8Sifo4sllwkTtXKjHqzX+RqpRLQKaK4DDenWmD9derEhhn5w==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 744, DateTimeKind.Local).AddTicks(5749), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9" },
                    { "b5b165ab-2089-4a3f-a9f4-c200756a6efe", 0, "43e69c5f-1b17-4989-bc7d-f90074f534bc", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEAFOCjL2v//WgbfalCE62IZ2JGXeA8XwT1j4yZb+5xvu/ukKIEdEHLfXt5bzPRXXXg==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 833, DateTimeKind.Local).AddTicks(8399), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10" },
                    { "d4b943d6-01fa-403e-820d-b78291d1c059", 0, "75310ebc-1a0d-435e-8517-419e2a9a14b1", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEN4GenvhWlZqdTqdviiblRgqDYRe9sLobkHI5qysKfunBmMIrdenmF/ZnX1o0R215w==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 229, DateTimeKind.Local).AddTicks(3146), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3" },
                    { "d8fdef36-1a8b-44e5-9715-66fc0748d53c", 0, "2adbddc3-c523-4e64-84d5-62ff376dff73", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEACNnl7Q3gLplhAsTS3KsbE/dwv81noWvQ7R/bUT48amvEzqUkDos0E2e0zS+gvCxw==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 395, DateTimeKind.Local).AddTicks(4739), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5" },
                    { "e24652cd-8923-42ac-a983-8f240311c4c6", 0, "30b1c05c-1526-4383-bf10-6a97b4571413", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEPkeOyGnQij2C+IPKcYBdZWwAWXt58Y68KjV6/gXYjGK5+2y70K8UPdjUgGcBe9+ZA==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 65, DateTimeKind.Local).AddTicks(777), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1" },
                    { "f450ee56-e379-49f4-b8b1-031d04ae680b", 0, "8dad03aa-a10f-4f92-b4ed-ed5848f65d51", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEIHSEmR1ZTmkXhgNOQOW4nvQYRH+yW7tXNKS2CbJwftnk5W6IWqWO6NhMfx7KJVKsQ==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 153, DateTimeKind.Local).AddTicks(3838), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2" }
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Name", "Timezone" },
                values: new object[] { 1, "Rio de Janeiro", "America/Sao_Paulo" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "09dff3e7-6075-4574-bbaa-33542ac27232" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "14ad6a2b-61f9-4616-bbc1-807f9cc4f6ee" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1c4a2486-1bf7-434a-b8db-cbdbda4db39f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2095afb8-6d22-4449-a267-083ac1de4af6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "63008a46-2e3c-47b5-b282-2f930e964840" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "70479475-148c-443f-a852-bbd62044b6ca" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "80d9a8b9-01ac-415b-b418-ec1e963fc168" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b5b165ab-2089-4a3f-a9f4-c200756a6efe" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d4b943d6-01fa-403e-820d-b78291d1c059" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d8fdef36-1a8b-44e5-9715-66fc0748d53c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e24652cd-8923-42ac-a983-8f240311c4c6" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f450ee56-e379-49f4-b8b1-031d04ae680b" }
                });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "Id", "CityId", "CompanyType", "Money", "Name" },
                values: new object[] { 1, 1, 0, 1000000000m, "Prefeitura do Rio de Janeiro" });

            migrationBuilder.InsertData(
                table: "Locations",
                columns: new[] { "Id", "CityId", "CompanyId", "Money", "Name", "Quality", "Type", "TypeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1000000m, "Praia de Copacabana", 5, 0, 0 },
                    { 2, 1, 1, 1000000m, "Parque do Flamengo", 5, 0, 1 },
                    { 3, 1, 1, 1000000m, "Parque Olímpico", 5, 0, 2 },
                    { 4, 1, 1, 1000000m, "Academia de Ginástica", 5, 0, 3 },
                    { 5, 1, 1, 1000000m, "Hotel Copacabana Palace", 5, 0, 4 },
                    { 6, 1, 1, 1000000m, "Restaurante Fasano", 5, 0, 5 },
                    { 7, 1, 1, 1000000m, "Loja de Artigos Esportivos", 5, 0, 6 },
                    { 8, 1, 1, 1000000m, "Centro de Treinamento", 5, 0, 7 }
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "Id", "Age", "BirthAt", "BirthCityId", "CurrentLocationId", "FirstName", "Gender", "LastName", "Money", "UserId" },
                values: new object[,]
                {
                    { 1, 25, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "John", "Male", "Doe", 0m, "1" },
                    { 2, 22, new DateTime(2024, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Jane", "Female", "Doe", 0m, "1" },
                    { 3, 30, new DateTime(2024, 10, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Bob", "Male", "Smith", 0m, "1" },
                    { 4, 28, new DateTime(2024, 10, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Alice", "Female", "Johnson", 0m, "2" },
                    { 5, 33, new DateTime(2024, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Charlie", "Male", "Brown", 0m, "2" },
                    { 6, 35, new DateTime(2024, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Dave", "Male", "Wilson", 0m, "2" },
                    { 7, 21, new DateTime(2024, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Emily", "Female", "Davis", 0m, "3" },
                    { 8, 27, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Frank", "Male", "Miller", 0m, "3" },
                    { 9, 19, new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Grace", "Female", "Lee", 0m, "3" },
                    { 10, 23, new DateTime(2024, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Hank", "Male", "Taylor", 0m, "4" },
                    { 11, 26, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Ivy", "Female", "White", 0m, "4" },
                    { 12, 32, new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "Jack", "Male", "Black", 0m, "4" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Locations_CityId",
                table: "Locations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyShareholders_CompanyId",
                table: "CompanyShareholders",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Cities_CityId",
                table: "Locations",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Cities_CityId",
                table: "Locations");

            migrationBuilder.DropTable(
                name: "CompanyShareholders");

            migrationBuilder.DropIndex(
                name: "IX_Locations_CityId",
                table: "Locations");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "09dff3e7-6075-4574-bbaa-33542ac27232" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "14ad6a2b-61f9-4616-bbc1-807f9cc4f6ee" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "1c4a2486-1bf7-434a-b8db-cbdbda4db39f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2095afb8-6d22-4449-a267-083ac1de4af6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "63008a46-2e3c-47b5-b282-2f930e964840" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "70479475-148c-443f-a852-bbd62044b6ca" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "80d9a8b9-01ac-415b-b418-ec1e963fc168" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b5b165ab-2089-4a3f-a9f4-c200756a6efe" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d4b943d6-01fa-403e-820d-b78291d1c059" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d8fdef36-1a8b-44e5-9715-66fc0748d53c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e24652cd-8923-42ac-a983-8f240311c4c6" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "f450ee56-e379-49f4-b8b1-031d04ae680b" });

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09dff3e7-6075-4574-bbaa-33542ac27232");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "14ad6a2b-61f9-4616-bbc1-807f9cc4f6ee");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1c4a2486-1bf7-434a-b8db-cbdbda4db39f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2095afb8-6d22-4449-a267-083ac1de4af6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "63008a46-2e3c-47b5-b282-2f930e964840");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70479475-148c-443f-a852-bbd62044b6ca");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80d9a8b9-01ac-415b-b418-ec1e963fc168");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5b165ab-2089-4a3f-a9f4-c200756a6efe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4b943d6-01fa-403e-820d-b78291d1c059");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d8fdef36-1a8b-44e5-9715-66fc0748d53c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e24652cd-8923-42ac-a983-8f240311c4c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f450ee56-e379-49f4-b8b1-031d04ae680b");

            migrationBuilder.DeleteData(
                table: "Locations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Locations");

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
        }
    }
}

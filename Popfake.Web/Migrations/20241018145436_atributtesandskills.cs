using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Popfake.Web.Migrations
{
    /// <inheritdoc />
    public partial class atributtesandskills : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "09dff3e7-6075-4574-bbaa-33542ac27232");

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
                keyValue: "2095afb8-6d22-4449-a267-083ac1de4af6");

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

            migrationBuilder.CreateTable(
                name: "Atributtes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atributtes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CharacterAtributtes",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "integer", nullable: false),
                    AtributteId = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterAtributtes", x => new { x.CharacterId, x.AtributteId });
                    table.ForeignKey(
                        name: "FK_CharacterAtributtes_Atributtes_AtributteId",
                        column: x => x.AtributteId,
                        principalTable: "Atributtes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterAtributtes_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterSkills",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "integer", nullable: false),
                    SkillId = table.Column<int>(type: "integer", nullable: false),
                    Level = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterSkills", x => new { x.CharacterId, x.SkillId });
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Characters_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterSkills_Skills_SkillId",
                        column: x => x.SkillId,
                        principalTable: "Skills",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "206e480f-1528-497a-9a13-8d0251196545", "AQAAAAIAAYagAAAAEA7jXJB5nU8IWP2hqs5ZkgBe/j4Wrd86i8/0hh6ZwCN6Wt15nPfjOhDSeEjCaE+xGg==", new DateTime(2024, 10, 18, 11, 54, 35, 247, DateTimeKind.Local).AddTicks(6249) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "58e6bf90-228c-4051-8b20-3d8c675b45cc", "AQAAAAIAAYagAAAAEFUQXzivtj2lK2ynE+vR7Jj7GDncSECFlAuvWGs3Mnvdsglc47xIEZwjosqJSBhlQg==", new DateTime(2024, 10, 18, 11, 54, 35, 308, DateTimeKind.Local).AddTicks(4165) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "825cc49f-a85c-47a2-b36c-3df5c3da32f8", "AQAAAAIAAYagAAAAEJwviJAw8HOvQB+BLyccUgbbX5cMGWOV4PuJjgtyB/xYjIZtkw0BKpThSQpHAEJIUw==", new DateTime(2024, 10, 18, 11, 54, 35, 366, DateTimeKind.Local).AddTicks(3045) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "749ddb91-db94-4cfb-a8bf-7be09bc5d146", "AQAAAAIAAYagAAAAENJKC6/PLJ6wGyFLZVrh628So3cvcKC9luad7R56MOfuABcPfuMVdmJGjsn1KW1wBg==", new DateTime(2024, 10, 18, 11, 54, 35, 428, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2d23296f-2d6b-482f-9261-018a2b23489b", 0, "e0e14bec-992d-4df0-84d7-837d34800437", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEHlFgK4+/6g2JcQzO+GRRTEGXM7NwuiKEeRWpxfjCeEk+gZdIEAVyw1QFJi3tpb7sg==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 779, DateTimeKind.Local).AddTicks(5428), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6" },
                    { "3cfeecb7-434f-48f0-8ec5-1be786b86f36", 0, "f0b9352d-4b37-4bb5-a447-0db7abb37034", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEIo53ZkxR96xc7zDNa2sKy5vE+qfwEO5bt+ePU7UhXLNNU1drqRDveDTtZcEYv6jVA==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 447, DateTimeKind.Local).AddTicks(2995), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2" },
                    { "470407c6-94ce-4425-8a8a-680a48b3d686", 0, "14dad133-49ff-4e84-bdd5-66fbce1b5676", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEE9+8KCWuD4Swdkw697mDeSPpquaLEC1sfJaBjCE6eJ05BW0PtFW+pnNfyPIdt+Flw==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 935, DateTimeKind.Local).AddTicks(2115), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8" },
                    { "7f83a912-ec7d-44e6-ac9b-dc1d0c8a72fc", 0, "d0b02aad-7d16-4ba6-9c2a-009f28462198", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEPSZUQQfcyIeF79Ajg18af+6NbERwJXkr4H+SnNNPlpBYwfVF8hIPYNMJ3REMmrlTw==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 857, DateTimeKind.Local).AddTicks(2409), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7" },
                    { "8ad43550-1163-426f-9c17-469c5427e1d5", 0, "957a25c4-b147-4285-accb-e69155d5b116", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEHpdFtV4id2wt1cQZjSxf6pZ6OX/Mt1p+XEVlGeoZHcn/k6HbOvkvlf3qX/wqpEw+g==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 695, DateTimeKind.Local).AddTicks(2417), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5" },
                    { "a2a394da-9e6f-4b69-86af-47e5e5d9aa19", 0, "393981a3-4b13-4cd3-a167-4aca59c5209e", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAEPL79g5gs/qrjfe9LOiRm4Jwz2jlwHZYAoJdmlxLne8d8gf8m/TKH9TQzTPe3tjH8g==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 359, DateTimeKind.Local).AddTicks(3521), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1" },
                    { "b3c48c94-b450-45c6-bac6-5e584080518d", 0, "9619331d-b470-46f5-8fd7-758891ded375", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEEFh5J9xteLomVYqiW95L0ips5XF9YEWquaV6W82/8h9dHBC8Rd8dtdKN2X74H9VFQ==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 605, DateTimeKind.Local).AddTicks(3899), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4" },
                    { "b5742a7e-0648-4d67-afb0-989c249b0f31", 0, "48ed864f-0c7c-478e-a26a-b980695f71a8", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAEHPLD5ZSck+qqM+2vSmMjywzp0PiyqmXplm32Ivoe4pds3cy2dM62cVqroFf+2WwhQ==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 998, DateTimeKind.Local).AddTicks(925), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9" },
                    { "c2f58402-3255-4a6c-a4cd-c6a8e28f98fc", 0, "c4209611-1754-47f2-bbfc-045ca6de4d20", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEACW1eCZMzGulp975Sj8zzMIOiHF1LDv0U4+jePfdzmyOH201lNU1ArGufTb94kWYQ==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 35, 188, DateTimeKind.Local).AddTicks(7768), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12" },
                    { "c7add045-8c50-472d-b556-533a665319ac", 0, "5c2b523c-a1b5-4ae5-b9e6-98278a12d7b3", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEMYBKKMBDMAeJWmf1Vnm3U9tGnu0sbqYJVCgtK7Oz242W2Rzd7MFSo4Jy5IIGRGpRA==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 35, 126, DateTimeKind.Local).AddTicks(3569), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11" },
                    { "d54607d2-7e13-44a6-9ead-aafa1ca2b1f4", 0, "40fc2284-f9d0-407f-b23a-0f5cfb1557bf", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEL+5bYO2v6ejkZdV6Mfb3HpTeaQM3xezvtQR1JEIKZcj+j6RqIo6s9HcuVCYLgcEzw==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 34, 535, DateTimeKind.Local).AddTicks(964), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3" },
                    { "e9e29f87-dc0d-4ce5-8261-d86c3ec85226", 0, "57780347-ff65-4c80-b6c5-a9b2b41715ad", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAENbMis92XN8M+y+r/jpHYWJk4vxdEMTJTcFJpHTZIZ3VFhGd66sskrwLKgO5jD5RTA==", null, false, "", new DateTime(2024, 10, 18, 11, 54, 35, 59, DateTimeKind.Local).AddTicks(1760), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10" }
                });

            migrationBuilder.InsertData(
                table: "Atributtes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "The ability to perform tasks with precision and agility.", "Dexterity" },
                    { 2, "The physical power and ability to perform tasks requiring muscular effort.", "Strength" },
                    { 3, "The ability to learn, understand, and apply knowledge.", "Intelligence" },
                    { 4, "The physical endurance and ability to withstand adversities.", "Constitution" },
                    { 5, "The ability to innovate and think in an original and inventive way.", "Creativity" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2d23296f-2d6b-482f-9261-018a2b23489b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3cfeecb7-434f-48f0-8ec5-1be786b86f36" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "470407c6-94ce-4425-8a8a-680a48b3d686" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7f83a912-ec7d-44e6-ac9b-dc1d0c8a72fc" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8ad43550-1163-426f-9c17-469c5427e1d5" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a2a394da-9e6f-4b69-86af-47e5e5d9aa19" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b3c48c94-b450-45c6-bac6-5e584080518d" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b5742a7e-0648-4d67-afb0-989c249b0f31" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c2f58402-3255-4a6c-a4cd-c6a8e28f98fc" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c7add045-8c50-472d-b556-533a665319ac" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d54607d2-7e13-44a6-9ead-aafa1ca2b1f4" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e9e29f87-dc0d-4ce5-8261-d86c3ec85226" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterAtributtes_AtributteId",
                table: "CharacterAtributtes",
                column: "AtributteId");

            migrationBuilder.CreateIndex(
                name: "IX_CharacterSkills_SkillId",
                table: "CharacterSkills",
                column: "SkillId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterAtributtes");

            migrationBuilder.DropTable(
                name: "CharacterSkills");

            migrationBuilder.DropTable(
                name: "Atributtes");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "2d23296f-2d6b-482f-9261-018a2b23489b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3cfeecb7-434f-48f0-8ec5-1be786b86f36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "470407c6-94ce-4425-8a8a-680a48b3d686" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "7f83a912-ec7d-44e6-ac9b-dc1d0c8a72fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "8ad43550-1163-426f-9c17-469c5427e1d5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "a2a394da-9e6f-4b69-86af-47e5e5d9aa19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b3c48c94-b450-45c6-bac6-5e584080518d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "b5742a7e-0648-4d67-afb0-989c249b0f31" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c2f58402-3255-4a6c-a4cd-c6a8e28f98fc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "c7add045-8c50-472d-b556-533a665319ac" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d54607d2-7e13-44a6-9ead-aafa1ca2b1f4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e9e29f87-dc0d-4ce5-8261-d86c3ec85226" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d23296f-2d6b-482f-9261-018a2b23489b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3cfeecb7-434f-48f0-8ec5-1be786b86f36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "470407c6-94ce-4425-8a8a-680a48b3d686");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f83a912-ec7d-44e6-ac9b-dc1d0c8a72fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ad43550-1163-426f-9c17-469c5427e1d5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a2a394da-9e6f-4b69-86af-47e5e5d9aa19");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b3c48c94-b450-45c6-bac6-5e584080518d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5742a7e-0648-4d67-afb0-989c249b0f31");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2f58402-3255-4a6c-a4cd-c6a8e28f98fc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7add045-8c50-472d-b556-533a665319ac");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d54607d2-7e13-44a6-9ead-aafa1ca2b1f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9e29f87-dc0d-4ce5-8261-d86c3ec85226");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "c02b4ff6-8743-43c3-99ff-74c7be914726", "AQAAAAIAAYagAAAAEOs9qjl2vhsV3tEYrsIaVD5fO/JsL0VPtfncutbvXhYs/avFgkoxw0ITGJjEUc8fvQ==", new DateTime(2024, 10, 17, 23, 14, 17, 51, DateTimeKind.Local).AddTicks(3948) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "d8f61ffe-cd75-4285-9f21-30530157b029", "AQAAAAIAAYagAAAAEEJUTGdiVrsjyIPc8ppIqzNcecNnB4FUaey/RD0zKUGCX3YaDdTDLSUlPmOzUio7lg==", new DateTime(2024, 10, 17, 23, 14, 17, 120, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "5fe6e981-7cda-44df-a2d3-9e56cacfa43b", "AQAAAAIAAYagAAAAEE/TWo9kKZx7ZEtqY2fFNES5Cb684VQUOJvrFteFVneCjM0AD14PLICrAq1p/ZZM0w==", new DateTime(2024, 10, 17, 23, 14, 17, 187, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "e8733d88-2d67-44a8-8d87-0a325499f617", "AQAAAAIAAYagAAAAEE/Qg6vX1/LxXXob0Ceq4X3EGHhHvejTDdaBuAB9utEDSQMjPWe2OQJiw6pPzXxpRw==", new DateTime(2024, 10, 17, 23, 14, 17, 258, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "09dff3e7-6075-4574-bbaa-33542ac27232", 0, "1e41deff-741a-4ce2-89d8-fb91a590cb46", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAELtAcsVCNB5ZhFOwdjK+bzqkHsHezMae/Xw4YEAVP4q/XX5X7aNcDMNm1t2isgkQrw==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 977, DateTimeKind.Local).AddTicks(7397), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12" },
                    { "14ad6a2b-61f9-4616-bbc1-807f9cc4f6ee", 0, "64e1641d-3c33-44a3-b6ed-295a7003bdbb", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEGLpzYuHJ3e9+R11r9pd10puKkW6iy8u5Ajow7Crgnb/n8sxMbdImhp/GvG+G1aO+w==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 658, DateTimeKind.Local).AddTicks(9267), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8" },
                    { "1c4a2486-1bf7-434a-b8db-cbdbda4db39f", 0, "f8ca7c93-ce36-44cc-b5b8-110da0ebe6d9", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAEIj+q5zqPLhpzOLqq/i20dBZJsdQ8+zCYJO4NQUXFfevS1eRX26TVkSDzXK1QBZPgw==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 907, DateTimeKind.Local).AddTicks(4304), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11" },
                    { "2095afb8-6d22-4449-a267-083ac1de4af6", 0, "97c72ffb-04c5-42aa-a579-06681bc7b0e5", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEPEAjKZABJ28dHz9iESYPMnzFTI+UgPJ++GCGAO50fkvbH876aetVRvfB71OSAllDg==", null, false, "", new DateTime(2024, 10, 17, 23, 14, 16, 569, DateTimeKind.Local).AddTicks(1608), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7" },
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
        }
    }
}

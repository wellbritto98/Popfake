using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Popfake.Web.Migrations
{
    /// <inheritdoc />
    public partial class avatarUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<string>(
                name: "AvatarUrl",
                table: "Characters",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "1980bd2b-e1b9-4555-b5b6-2b4074f21dfb", "AQAAAAIAAYagAAAAEEUVhMCZcOgAwsxclOMefETpHOKz3CBDwpOKYy0jvznPxl9k7zr0ic+LIu1pvw8hkg==", new DateTime(2024, 10, 21, 21, 49, 44, 469, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "2ef545f9-bc87-4fc4-94e5-00ea0f37bd19", "AQAAAAIAAYagAAAAEGpeq1rP4xLxOIQq7pn3V5VAMY3S0uOUdM5TNAwt5AWr41UnuyrLp/8tPFMOskMKFA==", new DateTime(2024, 10, 21, 21, 49, 44, 530, DateTimeKind.Local).AddTicks(5633) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "be526ec7-ec64-48a5-a150-9d81f4867ba4", "AQAAAAIAAYagAAAAEOItBhJsQkVIutGIacldf4eNbwYJqr7N7NBDY3e79cQ5PMSoKNVKyjIFSN62/MR6lQ==", new DateTime(2024, 10, 21, 21, 49, 44, 586, DateTimeKind.Local).AddTicks(8833) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredAt" },
                values: new object[] { "9fe056fd-a0f6-4b70-9708-2430c00e009d", "AQAAAAIAAYagAAAAEKvTyj3QXeGGCPR1VgqHuDcGUycvmUS9yFywa72RIpo1QVy6wnyeQ9LMvd9E6fsaSg==", new DateTime(2024, 10, 21, 21, 49, 44, 646, DateTimeKind.Local).AddTicks(3448) });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DataNascimento", "Email", "EmailConfirmed", "LastLoginAt", "LockoutEnabled", "LockoutEnd", "Nickname", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RegisteredAt", "SecurityStamp", "TokenCreatedAt", "TokenExpiredAt", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0730545a-e730-42d1-ad38-af79d72e726c", 0, "2098a207-e9e5-4b58-b6e9-0b0d1c2d6438", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user6@example.com", true, null, false, null, "User 6", "USER6@EXAMPLE.COM", "USER6", "AQAAAAIAAYagAAAAEEEdrYBcIwEJwSTdRrxwwE/G+sqIXaZonxjRLqPHLTxO3IkrZazGxFg6EtRYBfIpBQ==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 44, 0, DateTimeKind.Local).AddTicks(7845), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user6" },
                    { "3edce9ce-8819-4ec9-a68d-dd6925ad90f5", 0, "5aee532f-6452-40dd-bba8-29667d8130e2", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user5@example.com", true, null, false, null, "User 5", "USER5@EXAMPLE.COM", "USER5", "AQAAAAIAAYagAAAAEAKTND3rdbUBX3uvboSe/Bc8t1fXHxSQIeMrhsmFiS+0eV34oBapVSE9Hvsrr9rL3w==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 43, 935, DateTimeKind.Local).AddTicks(4217), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user5" },
                    { "80c9b350-192b-4d8f-89df-d8872ceed18f", 0, "d373c217-dcc3-4968-9b40-d3b8b2b326fb", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user1@example.com", true, null, false, null, "User 1", "USER1@EXAMPLE.COM", "USER1", "AQAAAAIAAYagAAAAECN+bXyOXSplMSAaxxyILAVWl9k1tY6WfupqK0eodtGRGosh13s6i1qSfN7X5s9+bg==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 43, 621, DateTimeKind.Local).AddTicks(9299), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user1" },
                    { "91c266f1-be7b-4f7a-86b8-d005a0fd3694", 0, "f9209ad5-6fa4-45e6-b122-76e697d010e6", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user9@example.com", true, null, false, null, "User 9", "USER9@EXAMPLE.COM", "USER9", "AQAAAAIAAYagAAAAELlN5hU+DCpI/SaJZfaHyhM4AWHLDjRGYeVHu4VHGDvKkqlyaOmpQTwQ0TnSO8NyCA==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 44, 232, DateTimeKind.Local).AddTicks(366), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user9" },
                    { "ab093ee2-c1fb-4114-9e57-0445d7e54055", 0, "8041cd95-16b1-4a17-8dd7-43e0c477e1f6", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user11@example.com", true, null, false, null, "User 11", "USER11@EXAMPLE.COM", "USER11", "AQAAAAIAAYagAAAAECl4fOnuslA556nhVcWPBdWTUoVRjaHQ7rVAQ4+leg94iKexaXoBd+6G3xNL7M0Uug==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 44, 352, DateTimeKind.Local).AddTicks(8471), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user11" },
                    { "ac7dcb36-96e4-4f2e-9187-936fae618a8b", 0, "03ee45a6-64ce-434f-a3b9-38f8c3b1b913", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user8@example.com", true, null, false, null, "User 8", "USER8@EXAMPLE.COM", "USER8", "AQAAAAIAAYagAAAAEKjnIPB2od4czxnagoVeFau4HJf96NvsHr9E+aO9QjUqSJoPyugo8ClzMyF0f1Vzqg==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 44, 157, DateTimeKind.Local).AddTicks(1735), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user8" },
                    { "ad666ca1-ff2b-4d09-a167-406b14da431f", 0, "04752f34-bf88-4c31-9ad8-e490add2a11f", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user3@example.com", true, null, false, null, "User 3", "USER3@EXAMPLE.COM", "USER3", "AQAAAAIAAYagAAAAEIGktG+zI+U4nmI7MRVm5pjCzVfhBT9+3JAAx5DTTqbUwzD/MCT36TaXcjbneBqilg==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 43, 762, DateTimeKind.Local).AddTicks(5978), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user3" },
                    { "bcd4ac43-2f0d-40aa-a084-8b02172e598b", 0, "18139850-c3a3-4c75-b1d6-365975fee013", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user7@example.com", true, null, false, null, "User 7", "USER7@EXAMPLE.COM", "USER7", "AQAAAAIAAYagAAAAEF69SBiGjILBDbFrBZSWaGW5yrzm9uXO1fvDK/GOC6OPVDW0enMcDlNlNJIZlAx2XQ==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 44, 88, DateTimeKind.Local).AddTicks(8500), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user7" },
                    { "d49e3a77-6b79-4a0b-9360-d3420a5750f7", 0, "1402803d-107f-4d53-9b0e-8cdaa72e3bc4", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user4@example.com", true, null, false, null, "User 4", "USER4@EXAMPLE.COM", "USER4", "AQAAAAIAAYagAAAAEMf4+rHGZ4g/c8oJSXjH/VI1CbIYwXTFuIkF/nvcqY9twGLR9qaaAfvdIfsmAObvqQ==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 43, 839, DateTimeKind.Local).AddTicks(220), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user4" },
                    { "dba541a5-0093-4e75-b566-4bb623bf48c0", 0, "5aacd5dd-d972-4918-9a57-8bd332eb0add", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user10@example.com", true, null, false, null, "User 10", "USER10@EXAMPLE.COM", "USER10", "AQAAAAIAAYagAAAAEEMwBK2I6SCMFK4m/7sBYbbKLbD14N4iG2n/nXmLWWh745ZPFgLH1D6CDZLXJg/2aw==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 44, 291, DateTimeKind.Local).AddTicks(8121), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user10" },
                    { "e06d6e84-822a-4485-a517-2754d05e2759", 0, "218e3181-bde4-406c-8d71-e02631e9f31e", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user2@example.com", true, null, false, null, "User 2", "USER2@EXAMPLE.COM", "USER2", "AQAAAAIAAYagAAAAEH2F/v3utaSxUTIUsiFDSRSqFJMe4m/HQ5/j8GxN98EQLHnM4zYejoy352OTVoVbFw==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 43, 697, DateTimeKind.Local).AddTicks(4823), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user2" },
                    { "e087eaa7-483b-4778-bde7-461ee495b049", 0, "2ae029b4-420a-4bb0-8293-62fcd6365fab", new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user12@example.com", true, null, false, null, "User 12", "USER12@EXAMPLE.COM", "USER12", "AQAAAAIAAYagAAAAEHBN3qmgP1V7iLPsF/hU5Iw9OX4YbttkTvpSUVhu45hmLwxgLHDLT0cZdK1WeKwLkg==", null, false, "", new DateTime(2024, 10, 21, 21, 49, 44, 411, DateTimeKind.Local).AddTicks(7072), "", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), false, "user12" }
                });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "M" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "F" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "M" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "F" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "M" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "M" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "F" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "M" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "F" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "M" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "F" });

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AvatarUrl", "Gender" },
                values: new object[] { "https://img.freepik.com/psd-gratuitas/ilustracao-3d-de-avatar-ou-perfil-humano_23-2150671122.jpg", "M" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0730545a-e730-42d1-ad38-af79d72e726c" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3edce9ce-8819-4ec9-a68d-dd6925ad90f5" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "80c9b350-192b-4d8f-89df-d8872ceed18f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "91c266f1-be7b-4f7a-86b8-d005a0fd3694" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ab093ee2-c1fb-4114-9e57-0445d7e54055" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ac7dcb36-96e4-4f2e-9187-936fae618a8b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ad666ca1-ff2b-4d09-a167-406b14da431f" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bcd4ac43-2f0d-40aa-a084-8b02172e598b" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d49e3a77-6b79-4a0b-9360-d3420a5750f7" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dba541a5-0093-4e75-b566-4bb623bf48c0" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e06d6e84-822a-4485-a517-2754d05e2759" },
                    { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e087eaa7-483b-4778-bde7-461ee495b049" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "0730545a-e730-42d1-ad38-af79d72e726c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "3edce9ce-8819-4ec9-a68d-dd6925ad90f5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "80c9b350-192b-4d8f-89df-d8872ceed18f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "91c266f1-be7b-4f7a-86b8-d005a0fd3694" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ab093ee2-c1fb-4114-9e57-0445d7e54055" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ac7dcb36-96e4-4f2e-9187-936fae618a8b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "ad666ca1-ff2b-4d09-a167-406b14da431f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "bcd4ac43-2f0d-40aa-a084-8b02172e598b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "d49e3a77-6b79-4a0b-9360-d3420a5750f7" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "dba541a5-0093-4e75-b566-4bb623bf48c0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e06d6e84-822a-4485-a517-2754d05e2759" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2c5e174e-3b0e-446f-86af-483d56fd7211", "e087eaa7-483b-4778-bde7-461ee495b049" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0730545a-e730-42d1-ad38-af79d72e726c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3edce9ce-8819-4ec9-a68d-dd6925ad90f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "80c9b350-192b-4d8f-89df-d8872ceed18f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "91c266f1-be7b-4f7a-86b8-d005a0fd3694");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ab093ee2-c1fb-4114-9e57-0445d7e54055");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ac7dcb36-96e4-4f2e-9187-936fae618a8b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad666ca1-ff2b-4d09-a167-406b14da431f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bcd4ac43-2f0d-40aa-a084-8b02172e598b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d49e3a77-6b79-4a0b-9360-d3420a5750f7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dba541a5-0093-4e75-b566-4bb623bf48c0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e06d6e84-822a-4485-a517-2754d05e2759");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e087eaa7-483b-4778-bde7-461ee495b049");

            migrationBuilder.DropColumn(
                name: "AvatarUrl",
                table: "Characters");

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

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 4,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 5,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 6,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 7,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 8,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 9,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 10,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 11,
                column: "Gender",
                value: "Female");

            migrationBuilder.UpdateData(
                table: "Characters",
                keyColumn: "Id",
                keyValue: 12,
                column: "Gender",
                value: "Male");

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
        }
    }
}

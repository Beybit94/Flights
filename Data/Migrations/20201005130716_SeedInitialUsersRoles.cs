using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SeedInitialUsersRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "848a7716-143d-49e7-913a-1a7ee1d90d94", "3e7be58d-8992-4a72-9b06-1ad8a7002c03", "admin", "ADMIN" },
                    { "c8c37a8b-e246-4013-9085-795fb0e17919", "560b67bd-4851-4841-ba90-8898f364678b", "manager", "MANAGER" },
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b4e863c7-4b83-485d-9547-3ff6244e0653", 0, "75e766a3-95c5-4ad5-9c9a-4ea798bbe85f", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN", "AQAAAAEAACcQAAAAELEim3t/v9orwN1cb7QqWHfj2Nny2UmZw8kB2PtXQcvTVjsX5ixNI2ET/jWyz0sDsw==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "admin" },
                    { "7c8ce7a1-566e-48df-bada-96943846cf38", 0, "cd9abc73-22f4-468e-9380-75d8cb5fd9af", "manager@gmail.com", true, false, null, "MANAGER@GMAIL.COM", "MANAGER", "AQAAAAEAACcQAAAAEI4+47/kYDaLnE0MpR9oIU3R9Cyc10m77WrvsQgfQ5Sop2WyuhLpHuM5bSdOv7MSuQ==", "XXXXXXXXXXXXX", true, "00000000-0000-0000-0000-000000000000", false, "manager" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "848a7716-143d-49e7-913a-1a7ee1d90d94");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c8c37a8b-e246-4013-9085-795fb0e17919");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7c8ce7a1-566e-48df-bada-96943846cf38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4e863c7-4b83-485d-9547-3ff6244e0653");
        }
    }
}

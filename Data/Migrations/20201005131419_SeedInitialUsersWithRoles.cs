using Microsoft.EntityFrameworkCore.Migrations;

namespace Data.Migrations
{
    public partial class SeedInitialUsersWithRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "b4e863c7-4b83-485d-9547-3ff6244e0653", "848a7716-143d-49e7-913a-1a7ee1d90d94" },
                    { "7c8ce7a1-566e-48df-bada-96943846cf38", "c8c37a8b-e246-4013-9085-795fb0e17919" },
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("delete from AspNetUserRoles");
        }
    }
}

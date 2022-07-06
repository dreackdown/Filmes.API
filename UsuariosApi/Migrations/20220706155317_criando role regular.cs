using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class criandoroleregular : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "585478de-6b2f-4a3a-8967-cabd961d996d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 99997, "177f8ca4-266d-4bb4-a0ea-d2c6833c1098", "regular", "REGULAR" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c610862c-889a-49c8-96fb-ce77c9120126", "AQAAAAEAACcQAAAAECxiXvklQ3Ar0CWJCwKe6OP0WprzKmCAxhy4SGKYXu/B+JPlXmDCqK8lYKcIeMUY+A==", "8d04980a-d04a-47c5-a843-f4b71620f0e0" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "26b54873-dc54-4731-840a-1d18dc4c9874");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2153f50-a893-4692-8afa-df130c4a1a7e", "AQAAAAEAACcQAAAAEHnC1q3PBzWipOhQj1MEZ4ko8DpkFsBJx4zaBTjMM1W7nbSIFZ/82XAF/GRMHNqPTQ==", "cc6ee5c6-b59f-49cc-842f-04b4b05206d9" });
        }
    }
}

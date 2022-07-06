using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UsuariosApi.Migrations
{
    public partial class addcustomidentityuser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DataNascimento",
                table: "AspNetUsers",
                type: "datetime",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "0a0827c5-82e9-4720-be99-a7ef67bdc94d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "f85ff17d-4581-4565-9cdc-197f541058fd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8435f667-c2c9-41b8-b69a-143978d03785", "AQAAAAEAACcQAAAAEE7CKBX8Htd/qC41GzFBpc5yXGIyJrHQEQiFxk7nr8duETlmCo/2gDOYnDzHn+wJDg==", "576791b4-2e7f-4945-85f8-b1496e764a3a" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNascimento",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99997,
                column: "ConcurrencyStamp",
                value: "177f8ca4-266d-4bb4-a0ea-d2c6833c1098");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 99999,
                column: "ConcurrencyStamp",
                value: "585478de-6b2f-4a3a-8967-cabd961d996d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 99999,
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c610862c-889a-49c8-96fb-ce77c9120126", "AQAAAAEAACcQAAAAECxiXvklQ3Ar0CWJCwKe6OP0WprzKmCAxhy4SGKYXu/B+JPlXmDCqK8lYKcIeMUY+A==", "8d04980a-d04a-47c5-a843-f4b71620f0e0" });
        }
    }
}

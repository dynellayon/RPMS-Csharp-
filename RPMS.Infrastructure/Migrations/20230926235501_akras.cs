using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class akras : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Akras",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Content Knowledge and Pedagogy (PPST Domain 1)" },
                    { 2, "Learning Environment (PPST Domain 2)" },
                    { 3, "Learning Environment (PPST Domain 2) - continuation" },
                    { 4, "Diversity of Learners, Curriculum and Planning, & Assessment and Reporting\r\n(PPST Domains 3, 4, and 5)" },
                    { 5, "Community Linkages and Professional Engagement & Personal Growth and\r\nProfessional Development (PPST Domains 6 & 7)" },
                    { 6, "Plus Factor" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9bc728d7-967a-4707-b28c-86da63d95d07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "9b51b624-dbab-4953-9b03-1374b5761cee");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "85258a4c-a820-4672-bb52-917a4081cd8c", "AQAAAAEAACcQAAAAELmIlJcHWEnKV3/sSQI9H1vn7xKhyZRso//mAF/lQA8pb4vNNt97ug37v6Gkc63xNw==", "78f8f8e6-c5b2-4a61-ae4b-bbe174ab78e2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12ea9be9-58b9-46b1-8f7e-a31c156a24f1", "AQAAAAEAACcQAAAAEEL5eAf3mItuiLqJY+qOBiy5YkmZeropwCPngNZsTGfk0nQuqDAel+h6BLb3T81o8Q==", "b6fa3e3e-a071-4f46-8708-55bb22c0d00d" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Akras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Akras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Akras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Akras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Akras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Akras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "a2518cad-fe3c-4bfe-93a7-75b38300afc6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "d19f238d-ce98-4854-ae8c-0325ab58d780");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bdb3b5d-0c8c-469c-87d9-5bfb8673f51b", "AQAAAAEAACcQAAAAEFMEVeEHDpxO3RTbhvpWqRk9g4tYhemjBjCxkcZzTc2nDao7RYQcXTLCfAOZNubKPw==", "e2eec1a8-eabf-45a1-aedd-ad3c784c0551" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16954046-76aa-4e39-b060-a233e8681552", "AQAAAAEAACcQAAAAEArUE86snp5YKdjNjOvX7nNXg4QcmOm+1bqyGEO0NCOIaa1T4kzSQElNngKm1kirmg==", "af7d1602-699c-4f93-8590-934509efbb47" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable



namespace RPMS.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Addposition : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PositionType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "adce9904-ebdc-45eb-b23b-daabc7f48c0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "08e5be89-519a-4cd7-a55b-22ed6af9434b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b2bd18d-b324-4da1-9be3-bc59837224bd", "AQAAAAEAACcQAAAAELRfVPHGW9/sT1GDn1JJBSggQrCFnJQOMENTGIwIzReh6sgZ/StksbEduqmCqnqJlQ==", "6554ca89-4c4a-4a6f-a1fd-87e9063e2dcc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f9eac5f4-b6c9-41d3-85ba-826c4018e4b3", "AQAAAAEAACcQAAAAEFevwsDN2YYleBw/bXHfYPcLYO1KiZfqDkjNDW5z4MJbtv6l3XgDhyV5vVRw9jsmtQ==", "41d2ab3c-acc0-4753-8fa0-9b78ef039f68" });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "PositionName", "PositionType" },
                values: new object[,]
                {
                    { 1, "Teacher I", "Proficient Teacher" },
                    { 2, "Teacher II", "Proficient Teacher" },
                    { 3, "Teacher III", "Proficient Teacher" },
                    { 4, "SPET I", "Proficient Teacher" },
                    { 5, "SPET II", "Proficient Teacher" },
                    { 6, "SPET III", "Proficient Teacher" },
                    { 7, "SPET IV", "Proficient Teacher" },
                    { 8, "SPET V", "Proficient Teacher" },
                    { 9, "INSTRUCTOR I", "Proficient Teacher" },
                    { 10, "INSTRUCTOR II", "Proficient Teacher" },
                    { 11, "Special Science Teacher I", "Proficient Teacher" },
                    { 12, "Special Science Teacher II", "Proficient Teacher" },
                    { 13, "Special Science Teacher III", "Proficient Teacher" },
                    { 14, "Special Science Teacher IV", "Proficient Teacher" },
                    { 15, "Special Science Teacher V", "Proficient Teacher" },
                    { 16, "Master Teacher I", "High Proficient Teacher" },
                    { 17, "Master Teacher II", "High Proficient Teacher" },
                    { 18, "Master Teacher III", "High Proficient Teacher" },
                    { 19, "Master Teacher IV", "High Proficient Teacher" },
                    { 20, "Master Teacher V", "High Proficient Teacher" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                column: "ConcurrencyStamp",
                value: "9cd21cc0-87c5-4c10-a907-5ebf40103391");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cbc43a8e-f7bb-4445-baaf-1add431ffbbf",
                column: "ConcurrencyStamp",
                value: "648e15ee-f246-409d-a21a-920809849bec");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e445865-a24d-4543-a6c6-9443d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec9248d4-c440-465b-998a-c646f666ca49", "AQAAAAEAACcQAAAAEEEg5l+DAYlU8fa00P0ztC6g1gFyY4hsAD1bppWNA8KglB9UoII6TOAiZujn2ogpcw==", "be49e2d9-2d0e-45a4-933c-1a22dce49145" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e224968-33e4-4652-b7b7-8574d048cdb9",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53d1173e-d44b-499d-ad19-b8526d7235c4", "AQAAAAEAACcQAAAAELwwT7/17I6jluVCkUBLrt1XzH/Y4LQZxwpcS0tTy01OdLBtVCE54vx0YVWC/wUADA==", "b72a4ab5-7e47-4344-9419-605cfced2b9c" });
        }
    }
}

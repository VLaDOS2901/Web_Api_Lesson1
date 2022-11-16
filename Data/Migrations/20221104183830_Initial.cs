using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matrixes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matrixes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monitors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ScreenSize = table.Column<double>(type: "float", nullable: false),
                    Display = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Refresh = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ImgLink = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MatrixId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monitors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Monitors_Matrixes_MatrixId",
                        column: x => x.MatrixId,
                        principalTable: "Matrixes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Matrixes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "LED" },
                    { 2, "IPS" },
                    { 3, "TFT" },
                    { 4, "OLED" }
                });

            migrationBuilder.InsertData(
                table: "Monitors",
                columns: new[] { "Id", "Display", "ImgLink", "MatrixId", "Name", "Price", "Refresh", "ScreenSize" },
                values: new object[,]
                {
                    { 1, "1920 x 1080", "https://m.media-amazon.com/images/I/71rXSVqET9L._AC_SX450_.jpg", 1, "Sceptre", 129.97, 60, 24.0 },
                    { 2, "1920 x 1080", "https://m.media-amazon.com/images/I/81QpkIctqPL._AC_SY450_.jpg", 2, "Acer", 129.99000000000001, 75, 21.5 },
                    { 3, "1920 x 1080", "https://m.media-amazon.com/images/I/81WrBJdJcIL._AC_SX522_.jpg", 3, "LG", 129.97, 60, 24.0 },
                    { 4, "1920 x 1080", "https://m.media-amazon.com/images/I/81j9OvhbxbL._AC_SY450_.jpg", 4, "Sceptre", 129.97, 60, 24.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Monitors_MatrixId",
                table: "Monitors",
                column: "MatrixId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Monitors");

            migrationBuilder.DropTable(
                name: "Matrixes");
        }
    }
}

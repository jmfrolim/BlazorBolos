using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorBolos.Migrations
{
    /// <inheritdoc />
    public partial class inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Bolos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagemUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Preco = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolos", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Bolos",
                columns: new[] { "Id", "Descricao", "ImagemUrl", "Nome", "Preco" },
                values: new object[,]
                {
                    { 1, "Bolo1 ", "bolo1.jpg", "Bolo1", 25.45m },
                    { 2, "Bolo2 Descricao", "bolo2.jpg", "Bolo2", 21.0m },
                    { 3, "Bolo3 descricao", "bolo3.jpg", "Bolo3", 19.0m },
                    { 4, "Bolo4 descricao", "bolo4.jpg", "Bolo4", 34.75m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolos");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StoreCatalog.Migrations
{
    /// <inheritdoc />
    public partial class AddTablesToDatabase : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "graphicscards",
                columns: table => new
                {
                    GraphicsCardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MemorySize = table.Column<int>(type: "int", nullable: false),
                    MemoryType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_graphicscards", x => x.GraphicsCardId);
                });

            migrationBuilder.CreateTable(
                name: "motherboards",
                columns: table => new
                {
                    MotherboardId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Socket = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FormFactor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RAMSlots = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_motherboards", x => x.MotherboardId);
                });

            migrationBuilder.CreateTable(
                name: "processors",
                columns: table => new
                {
                    ProcessorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoreCount = table.Column<int>(type: "int", nullable: false),
                    ThreadCount = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_processors", x => x.ProcessorId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "graphicscards");

            migrationBuilder.DropTable(
                name: "motherboards");

            migrationBuilder.DropTable(
                name: "processors");
        }
    }
}

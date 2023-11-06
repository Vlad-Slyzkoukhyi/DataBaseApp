using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TT_GeeksForLess_Vladyslav_Slyzkoukhyi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CreatingDigitalImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourcesId = table.Column<int>(type: "int", nullable: false),
                    GraphicProductId = table.Column<int>(type: "int", nullable: false),
                    EvidenceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CreatingDigitalImages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Evidence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatingDigitalImagesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Evidence", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Evidence_CreatingDigitalImages_CreatingDigitalImagesId",
                        column: x => x.CreatingDigitalImagesId,
                        principalTable: "CreatingDigitalImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "GraphicProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProcessId = table.Column<int>(type: "int", nullable: false),
                    FinalProductId = table.Column<int>(type: "int", nullable: false),
                    CreatingDigitalImagesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GraphicProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GraphicProducts_CreatingDigitalImages_CreatingDigitalImagesId",
                        column: x => x.CreatingDigitalImagesId,
                        principalTable: "CreatingDigitalImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Resources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PrimaryResourcesId = table.Column<int>(type: "int", nullable: false),
                    SecondaryResourcesId = table.Column<int>(type: "int", nullable: false),
                    CreatingDigitalImagesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Resources_CreatingDigitalImages_CreatingDigitalImagesId",
                        column: x => x.CreatingDigitalImagesId,
                        principalTable: "CreatingDigitalImages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FinalProducts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicProductsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinalProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FinalProducts_GraphicProducts_GraphicProductsId",
                        column: x => x.GraphicProductsId,
                        principalTable: "GraphicProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Processes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GraphicProductsId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Processes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Processes_GraphicProducts_GraphicProductsId",
                        column: x => x.GraphicProductsId,
                        principalTable: "GraphicProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PrimarySources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourcesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrimarySources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrimarySources_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "SecondarySources",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ResourcesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SecondarySources", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SecondarySources_Resources_ResourcesId",
                        column: x => x.ResourcesId,
                        principalTable: "Resources",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Evidence_CreatingDigitalImagesId",
                table: "Evidence",
                column: "CreatingDigitalImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_FinalProducts_GraphicProductsId",
                table: "FinalProducts",
                column: "GraphicProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_GraphicProducts_CreatingDigitalImagesId",
                table: "GraphicProducts",
                column: "CreatingDigitalImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_PrimarySources_ResourcesId",
                table: "PrimarySources",
                column: "ResourcesId");

            migrationBuilder.CreateIndex(
                name: "IX_Processes_GraphicProductsId",
                table: "Processes",
                column: "GraphicProductsId");

            migrationBuilder.CreateIndex(
                name: "IX_Resources_CreatingDigitalImagesId",
                table: "Resources",
                column: "CreatingDigitalImagesId");

            migrationBuilder.CreateIndex(
                name: "IX_SecondarySources_ResourcesId",
                table: "SecondarySources",
                column: "ResourcesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Evidence");

            migrationBuilder.DropTable(
                name: "FinalProducts");

            migrationBuilder.DropTable(
                name: "PrimarySources");

            migrationBuilder.DropTable(
                name: "Processes");

            migrationBuilder.DropTable(
                name: "SecondarySources");

            migrationBuilder.DropTable(
                name: "GraphicProducts");

            migrationBuilder.DropTable(
                name: "Resources");

            migrationBuilder.DropTable(
                name: "CreatingDigitalImages");
        }
    }
}

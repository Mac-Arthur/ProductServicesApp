using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProductServicesApp.Migrations
{
    /// <inheritdoc />
    public partial class Add_CompanyProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Product_Company_CompanyId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_CompanyId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "CompanyId",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsExporter",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "IsImporter",
                table: "Product");

            migrationBuilder.CreateTable(
                name: "CompanyProduct",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: false),
                    IsExporter = table.Column<bool>(type: "bit", nullable: false),
                    IsImporter = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CompanyProduct", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CompanyProduct_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CompanyProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProduct_CompanyId",
                table: "CompanyProduct",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_CompanyProduct_ProductId",
                table: "CompanyProduct",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyProduct");

            migrationBuilder.AddColumn<int>(
                name: "CompanyId",
                table: "Product",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsExporter",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsImporter",
                table: "Product",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.CreateIndex(
                name: "IX_Product_CompanyId",
                table: "Product",
                column: "CompanyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Company_CompanyId",
                table: "Product",
                column: "CompanyId",
                principalTable: "Company",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

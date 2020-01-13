using Microsoft.EntityFrameworkCore.Migrations;

namespace BethanysPieShop.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pies",
                table: "Pies");

            migrationBuilder.RenameTable(
                name: "Pies",
                newName: "Pie");

            migrationBuilder.RenameIndex(
                name: "IX_Pies_CategoryId",
                table: "Pie",
                newName: "IX_Pie_CategoryId");

            migrationBuilder.AddColumn<string>(
                name: "GradeAverage",
                table: "Pie",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ProductDetailPieId",
                table: "Pie",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pie",
                table: "Pie",
                column: "PieId");

            migrationBuilder.CreateTable(
                name: "DbCommentary",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Text = table.Column<string>(nullable: true),
                    PieId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbCommentary", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DbCommentary_Pie_PieId",
                        column: x => x.PieId,
                        principalTable: "Pie",
                        principalColumn: "PieId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DbGrades",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Grade = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DbGrades", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pie_ProductDetailPieId",
                table: "Pie",
                column: "ProductDetailPieId");

            migrationBuilder.CreateIndex(
                name: "IX_DbCommentary_PieId",
                table: "DbCommentary",
                column: "PieId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pie_PieId",
                table: "OrderDetails",
                column: "PieId",
                principalTable: "Pie",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pie_Categories_CategoryId",
                table: "Pie",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pie_Pie_ProductDetailPieId",
                table: "Pie",
                column: "ProductDetailPieId",
                principalTable: "Pie",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Pie_PieId",
                table: "ShoppingCartItems",
                column: "PieId",
                principalTable: "Pie",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderDetails_Pie_PieId",
                table: "OrderDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Pie_Categories_CategoryId",
                table: "Pie");

            migrationBuilder.DropForeignKey(
                name: "FK_Pie_Pie_ProductDetailPieId",
                table: "Pie");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCartItems_Pie_PieId",
                table: "ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "DbCommentary");

            migrationBuilder.DropTable(
                name: "DbGrades");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pie",
                table: "Pie");

            migrationBuilder.DropIndex(
                name: "IX_Pie_ProductDetailPieId",
                table: "Pie");

            migrationBuilder.DropColumn(
                name: "GradeAverage",
                table: "Pie");

            migrationBuilder.DropColumn(
                name: "ProductDetailPieId",
                table: "Pie");

            migrationBuilder.RenameTable(
                name: "Pie",
                newName: "Pies");

            migrationBuilder.RenameIndex(
                name: "IX_Pie_CategoryId",
                table: "Pies",
                newName: "IX_Pies_CategoryId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pies",
                table: "Pies",
                column: "PieId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderDetails_Pies_PieId",
                table: "OrderDetails",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Pies_Categories_CategoryId",
                table: "Pies",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCartItems_Pies_PieId",
                table: "ShoppingCartItems",
                column: "PieId",
                principalTable: "Pies",
                principalColumn: "PieId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

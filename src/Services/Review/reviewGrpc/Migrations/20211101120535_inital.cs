using Microsoft.EntityFrameworkCore.Migrations;

namespace reviewGrpc.Migrations
{
    public partial class inital : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Explain = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_reviews", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loginReviews",
                columns: table => new
                {
                    LoginReviewID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LoginID = table.Column<int>(type: "int", nullable: false),
                    ReviewIDId = table.Column<int>(type: "int", nullable: true),
                    ProductID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loginReviews", x => x.LoginReviewID);
                    table.ForeignKey(
                        name: "FK_loginReviews_reviews_ReviewIDId",
                        column: x => x.ReviewIDId,
                        principalTable: "reviews",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_loginReviews_ReviewIDId",
                table: "loginReviews",
                column: "ReviewIDId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "loginReviews");

            migrationBuilder.DropTable(
                name: "reviews");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NutriGenius.Data.Migrations
{
    public partial class Second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_FoodCategories_FoodCategoryId",
                table: "Foods");

            migrationBuilder.DropTable(
                name: "FoodMeal");

            migrationBuilder.DropTable(
                name: "FoodPortion");

            migrationBuilder.DropTable(
                name: "MealUser");

            migrationBuilder.DropIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods");

            migrationBuilder.AddColumn<int>(
                name: "FoodId",
                table: "Portions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "UserMealFoodPortions",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    FoodId = table.Column<int>(type: "int", nullable: false),
                    PortionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMealFoodPortions", x => new { x.UserId, x.MealId, x.FoodId, x.PortionId });
                    table.ForeignKey(
                        name: "FK_UserMealFoodPortions_Foods_FoodId",
                        column: x => x.FoodId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMealFoodPortions_Meal_MealId",
                        column: x => x.MealId,
                        principalTable: "Meal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMealFoodPortions_Portions_PortionId",
                        column: x => x.PortionId,
                        principalTable: "Portions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMealFoodPortions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Portions_FoodId",
                table: "Portions",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFoodPortions_FoodId",
                table: "UserMealFoodPortions",
                column: "FoodId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFoodPortions_MealId",
                table: "UserMealFoodPortions",
                column: "MealId");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFoodPortions_PortionId",
                table: "UserMealFoodPortions",
                column: "PortionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Portions_Foods_FoodId",
                table: "Portions",
                column: "FoodId",
                principalTable: "Foods",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Portions_Foods_FoodId",
                table: "Portions");

            migrationBuilder.DropTable(
                name: "UserMealFoodPortions");

            migrationBuilder.DropIndex(
                name: "IX_Portions_FoodId",
                table: "Portions");

            migrationBuilder.DropColumn(
                name: "FoodId",
                table: "Portions");

            migrationBuilder.CreateTable(
                name: "FoodMeal",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "int", nullable: false),
                    MealsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodMeal", x => new { x.FoodsId, x.MealsId });
                    table.ForeignKey(
                        name: "FK_FoodMeal_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodMeal_Meal_MealsId",
                        column: x => x.MealsId,
                        principalTable: "Meal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodPortion",
                columns: table => new
                {
                    FoodsId = table.Column<int>(type: "int", nullable: false),
                    PortionsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodPortion", x => new { x.FoodsId, x.PortionsId });
                    table.ForeignKey(
                        name: "FK_FoodPortion_Foods_FoodsId",
                        column: x => x.FoodsId,
                        principalTable: "Foods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FoodPortion_Portions_PortionsId",
                        column: x => x.PortionsId,
                        principalTable: "Portions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MealUser",
                columns: table => new
                {
                    MealsId = table.Column<int>(type: "int", nullable: false),
                    UsersId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MealUser", x => new { x.MealsId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_MealUser_Meal_MealsId",
                        column: x => x.MealsId,
                        principalTable: "Meal",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MealUser_Users_UsersId",
                        column: x => x.UsersId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Foods_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodMeal_MealsId",
                table: "FoodMeal",
                column: "MealsId");

            migrationBuilder.CreateIndex(
                name: "IX_FoodPortion_PortionsId",
                table: "FoodPortion",
                column: "PortionsId");

            migrationBuilder.CreateIndex(
                name: "IX_MealUser_UsersId",
                table: "MealUser",
                column: "UsersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_FoodCategories_FoodCategoryId",
                table: "Foods",
                column: "FoodCategoryId",
                principalTable: "FoodCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

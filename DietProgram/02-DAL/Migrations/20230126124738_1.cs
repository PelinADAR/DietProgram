using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02_DAL.Migrations
{
    public partial class _1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Meal",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meal", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "SelectedFoodTransfers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<double>(type: "float", nullable: false),
                    Calory = table.Column<double>(type: "float", nullable: false),
                    MealId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    DailyCalory = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SelectedFoodTransfers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    Height = table.Column<decimal>(type: "decimal", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Calory = table.Column<double>(type: "float", nullable: false),
                    Portion = table.Column<double>(type: "float", nullable: false),
                    FoodCategoryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Food_FoodCategory_FoodCategoryID",
                        column: x => x.FoodCategoryID,
                        principalTable: "FoodCategory",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserMealFood",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "GetDate()"),
                    Portion = table.Column<int>(type: "int", nullable: false),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    FoodID = table.Column<int>(type: "int", nullable: false),
                    MealID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMealFood", x => x.ID);
                    table.ForeignKey(
                        name: "FK_UserMealFood_Food_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Food",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMealFood_Meal_MealID",
                        column: x => x.MealID,
                        principalTable: "Meal",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserMealFood_Users_UserID",
                        column: x => x.UserID,
                        principalTable: "Users",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "FoodCategory",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Meat Product" },
                    { 2, "Sea Product" },
                    { 3, "Milk Product" },
                    { 4, "Fruit" },
                    { 5, "VegeTable" },
                    { 6, "Pastry" },
                    { 7, "Dessert" },
                    { 8, "Drink" },
                    { 9, "Homemade Food" },
                    { 10, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Breakfast" },
                    { 2, "Lunch" },
                    { 3, "Dinner" },
                    { 4, "Snack" }
                });

            migrationBuilder.InsertData(
                table: "Food",
                columns: new[] { "ID", "Calory", "FoodCategoryID", "Name", "Portion" },
                values: new object[,]
                {
                    { 1, 250.0, 1, "Ribeye", 1.0 },
                    { 2, 223.0, 1, "Tendeloin", 1.0 },
                    { 3, 252.0, 1, "Chicken", 1.0 },
                    { 4, 170.0, 2, "Trout", 1.0 },
                    { 5, 150.0, 2, "Anchovy", 1.0 },
                    { 6, 400.0, 3, "Cheddar Cheese ", 1.0 },
                    { 7, 360.0, 3, "Hellim Cheese", 1.0 },
                    { 8, 42.0, 5, "Tomatoes", 1.0 },
                    { 9, 42.0, 5, "Carrot", 1.0 },
                    { 10, 58.0, 4, "Apple", 1.0 },
                    { 11, 75.0, 4, "Plum", 1.0 },
                    { 12, 83.0, 9, "Mashed Potatoes", 1.0 },
                    { 13, 185.0, 9, "Rice Pilaf", 1.0 },
                    { 14, 69.0, 6, "White Bread", 1.0 },
                    { 15, 63.0, 6, "Brown Bread", 1.0 },
                    { 16, 225.0, 6, "Pogaca", 1.0 },
                    { 17, 167.0, 5, "Avacado", 1.0 },
                    { 18, 307.0, 6, "Pasta", 1.0 },
                    { 19, 193.0, 7, "Ice Cream", 1.0 },
                    { 20, 431.0, 7, "Chocolate Cake", 1.0 },
                    { 21, 0.0, 8, "Water", 1.0 },
                    { 22, 122.0, 8, "Cola", 1.0 },
                    { 23, 84.0, 8, "Milk", 1.0 },
                    { 24, 115.0, 4, "Olive", 1.0 },
                    { 25, 545.0, 10, "Milk Chocolate", 1.0 },
                    { 26, 536.0, 10, "Cips", 1.0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Food_FoodCategoryID",
                table: "Food",
                column: "FoodCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFood_FoodID",
                table: "UserMealFood",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFood_MealID",
                table: "UserMealFood",
                column: "MealID");

            migrationBuilder.CreateIndex(
                name: "IX_UserMealFood_UserID",
                table: "UserMealFood",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SelectedFoodTransfers");

            migrationBuilder.DropTable(
                name: "UserMealFood");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Meal");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "FoodCategory");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderCookDeliver.Migrations
{
    public partial class Calendar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Calendar",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    mealId = table.Column<string>(nullable: true),
                    mealName = table.Column<string>(nullable: true),
                    description = table.Column<string>(nullable: true),
                    preparationTime = table.Column<int>(nullable: false),
                    pricePerServg = table.Column<double>(nullable: false),
                    ingredient_1 = table.Column<string>(nullable: true),
                    ingredient_2 = table.Column<string>(nullable: true),
                    ingredient_3 = table.Column<string>(nullable: true),
                    ingredient_4 = table.Column<string>(nullable: true),
                    ingredient_5 = table.Column<string>(nullable: true),
                    ingredient_6 = table.Column<string>(nullable: true),
                    ingredient_7 = table.Column<string>(nullable: true),
                    ingredient_8 = table.Column<string>(nullable: true),
                    ingredient_9 = table.Column<string>(nullable: true),
                    ingredient_10 = table.Column<string>(nullable: true),
                    ingredient_11 = table.Column<string>(nullable: true),
                    ingredient_12 = table.Column<string>(nullable: true),
                    ingredient_13 = table.Column<string>(nullable: true),
                    ingredient_14 = table.Column<string>(nullable: true),
                    ingredient_15 = table.Column<string>(nullable: true),
                    ingredient_16 = table.Column<string>(nullable: true),
                    ingredient_17 = table.Column<string>(nullable: true),
                    calPerServg = table.Column<double>(nullable: false),
                    totalFat = table.Column<double>(nullable: false),
                    saturatedFat = table.Column<double>(nullable: false),
                    transFat = table.Column<double>(nullable: false),
                    monoUnsatFat = table.Column<double>(nullable: false),
                    polyUnsatFat = table.Column<double>(nullable: false),
                    omega_3 = table.Column<double>(nullable: false),
                    omega_6 = table.Column<double>(nullable: false),
                    cholesterol = table.Column<double>(nullable: false),
                    totalCarb = table.Column<double>(nullable: false),
                    dietaryFiber = table.Column<double>(nullable: false),
                    sugar = table.Column<double>(nullable: false),
                    protein = table.Column<double>(nullable: false),
                    procedure = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calendar", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Calendar");
        }
    }
}

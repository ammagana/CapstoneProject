using Microsoft.EntityFrameworkCore.Migrations;

namespace OrderCookDeliver.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "mealId",
                table: "Calendar");

            migrationBuilder.AlterColumn<string>(
                name: "preparationTime",
                table: "Calendar",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "day",
                table: "Calendar",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "rotation",
                table: "Calendar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "day",
                table: "Calendar");

            migrationBuilder.DropColumn(
                name: "rotation",
                table: "Calendar");

            migrationBuilder.AlterColumn<int>(
                name: "preparationTime",
                table: "Calendar",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "mealId",
                table: "Calendar",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}

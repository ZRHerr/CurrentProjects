using Microsoft.EntityFrameworkCore.Migrations;

namespace TrackerTemplate.Migrations
{
    public partial class Finished : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ReturnFuelLevel",
                table: "ServiceBookLog",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "ReturnFuelLevel",
                table: "ServiceBookLog",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}

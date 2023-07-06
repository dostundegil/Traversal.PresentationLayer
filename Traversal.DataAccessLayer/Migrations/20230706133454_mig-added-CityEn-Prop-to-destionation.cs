using Microsoft.EntityFrameworkCore.Migrations;

namespace Traversal.DataAccessLayer.Migrations
{
    public partial class migaddedCityEnProptodestionation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CityEn",
                table: "Destinations",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityEn",
                table: "Destinations");
        }
    }
}

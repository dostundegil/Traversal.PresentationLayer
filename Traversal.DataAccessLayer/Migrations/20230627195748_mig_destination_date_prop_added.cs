using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Traversal.DataAccessLayer.Migrations
{
    public partial class mig_destination_date_prop_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DestinationDate",
                table: "Destinations",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DestinationDate",
                table: "Destinations");
        }
    }
}

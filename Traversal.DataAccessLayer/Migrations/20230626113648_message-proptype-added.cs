using Microsoft.EntityFrameworkCore.Migrations;

namespace Traversal.DataAccessLayer.Migrations
{
    public partial class messageproptypeadded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MessageType",
                table: "ContactsUses",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MessageType",
                table: "ContactsUses");
        }
    }
}

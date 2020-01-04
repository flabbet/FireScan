using Microsoft.EntityFrameworkCore.Migrations;

namespace FireScan.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Events",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Status = table.Column<string>(nullable: true),
                    SubName = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true),
                    Timestamp = table.Column<int>(nullable: false),
                    Votes = table.Column<int>(nullable: false),
                    Comments = table.Column<int>(nullable: false),
                    Link = table.Column<string>(nullable: true),
                    Title = table.Column<string>(nullable: true),
                    Author = table.Column<string>(nullable: true),
                    Uid = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    IconUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PrimaryId", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Events");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Blinks.Repo.Migrations
{
    public partial class tres : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planilhas",
                columns: table => new
                {
                    id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    media = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    client_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    campaign_id = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    campaign_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    clicks = table.Column<int>(type: "int", nullable: false),
                    impressions = table.Column<int>(type: "int", nullable: false),
                    investment = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planilhas", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planilhas");
        }
    }
}

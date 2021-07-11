using Microsoft.EntityFrameworkCore.Migrations;

namespace demo2.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ScenicSpots",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Status = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Toldescribe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Add = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Zipcode = table.Column<long>(type: "bigint", nullable: false),
                    Travellinginfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Opentime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Map = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gov = table.Column<int>(type: "int", nullable: false),
                    Px = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Py = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Orgclass = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Level = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Parkinginfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkinginfoPx = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ParkinginfoPy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ticketinfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Keyword = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Changetime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Class3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picdescribe1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picdescribe2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picture3 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Picdescribe3 = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScenicSpots", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ScenicSpots");
        }
    }
}

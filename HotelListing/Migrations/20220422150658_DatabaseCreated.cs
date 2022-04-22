using Microsoft.EntityFrameworkCore.Migrations;

namespace HotelListing.Migrations
{
    public partial class DatabaseCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(60)", nullable: true),
                    CountryCode = table.Column<string>(type: "varchar(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Hotels",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(150)", nullable: true),
                    Address = table.Column<string>(type: "varchar(250)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    FKCountryID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotels", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hotels_Countries_FKCountryID",
                        column: x => x.FKCountryID,
                        principalTable: "Countries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryCode", "Name" },
                values: new object[] { 1, "ZAF", "South Africa" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryCode", "Name" },
                values: new object[] { 2, "MOZ", "Mozambique" });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "ID", "CountryCode", "Name" },
                values: new object[] { 3, "KEN", "Kenya" });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "FKCountryID", "Name", "Rating" },
                values: new object[] { 2, "Lloys Ellis Ave, Houghton Estate, Johannesburg, 2198", 1, "The Houghton Hotel", 4.7000000000000002 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "FKCountryID", "Name", "Rating" },
                values: new object[] { 3, "1380 Av. Julius Nyerere, Maputo, Mozambique", 2, "Polana Serena Hotel", 4.5999999999999996 });

            migrationBuilder.InsertData(
                table: "Hotels",
                columns: new[] { "ID", "Address", "FKCountryID", "Name", "Rating" },
                values: new object[] { 1, "Motorogi Conservancy Masai Mara, Kenya", 3, "Mahali Mzuri", 4.7999999999999998 });

            migrationBuilder.CreateIndex(
                name: "IX_Hotels_FKCountryID",
                table: "Hotels",
                column: "FKCountryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hotels");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}

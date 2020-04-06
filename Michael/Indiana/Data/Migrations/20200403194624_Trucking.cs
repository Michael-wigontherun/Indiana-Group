using Microsoft.EntityFrameworkCore.Migrations;

namespace Indiana.Data.Migrations
{
    public partial class Trucking : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ChameleonCompanies",
                columns: table => new
                {
                    Usdot = table.Column<string>(nullable: false),
                    PercentOcham = table.Column<string>(nullable: true),
                    AddminId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChameleonCompanies", x => x.Usdot);
                });

            migrationBuilder.CreateTable(
                name: "LiquidatedCompanys",
                columns: table => new
                {
                    Usdot = table.Column<string>(nullable: false),
                    LegalName = table.Column<string>(nullable: true),
                    Dbaname = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Oosreason = table.Column<string>(nullable: true),
                    Oosdate = table.Column<string>(nullable: true),
                    Status = table.Column<string>(nullable: true),
                    GeoLocation = table.Column<string>(nullable: true),
                    AddminId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LiquidatedCompanys", x => x.Usdot);
                });

            migrationBuilder.CreateTable(
                name: "TruckingCompanies",
                columns: table => new
                {
                    Usdot = table.Column<string>(nullable: false),
                    LegalName = table.Column<string>(nullable: true),
                    Dbaname = table.Column<string>(nullable: true),
                    CarrierOperation = table.Column<string>(nullable: true),
                    HmFlag = table.Column<string>(nullable: true),
                    PcFlag = table.Column<string>(nullable: true),
                    PhyStreet = table.Column<string>(nullable: true),
                    PhyCity = table.Column<string>(nullable: true),
                    PhyState = table.Column<string>(nullable: true),
                    PhyZip = table.Column<string>(nullable: true),
                    PhyCountry = table.Column<string>(nullable: true),
                    MailingStreet = table.Column<string>(nullable: true),
                    MailingCity = table.Column<string>(nullable: true),
                    MailingState = table.Column<string>(nullable: true),
                    MailingZip = table.Column<string>(nullable: true),
                    MailingCountry = table.Column<string>(nullable: true),
                    Telephone = table.Column<string>(nullable: true),
                    Fax = table.Column<string>(nullable: true),
                    EmailAddress = table.Column<string>(nullable: true),
                    Mcs150Date = table.Column<string>(nullable: true),
                    Mcs150Mileage = table.Column<int>(nullable: false),
                    Mcs150MileageYear = table.Column<string>(nullable: true),
                    AddDate = table.Column<string>(nullable: true),
                    OicState = table.Column<string>(nullable: true),
                    NbrPowerUnit = table.Column<int>(nullable: false),
                    DriverTotal = table.Column<int>(nullable: false),
                    GeoLocation = table.Column<string>(nullable: true),
                    AddminId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TruckingCompanies", x => x.Usdot);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChameleonCompanies");

            migrationBuilder.DropTable(
                name: "LiquidatedCompanys");

            migrationBuilder.DropTable(
                name: "TruckingCompanies");
        }
    }
}

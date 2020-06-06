using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartphoneShop.Migrations
{
    public partial class OrderSeedMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "Address", "GadgetId", "PhoneNumber", "UserId" },
                values: new object[,]
                {
                    { 4, "ul. Polweiska 27, 3130, Poznan, PL", 2, "+123-456-789-022", "b348feb0-037d-40c9-941e-afc111648c6e" },
                    { 5, "ul. Polweiska 27, 3130, Poznan, PL", 3, "+123-456-789-022", "b348feb0-037d-40c9-941e-afc111648c6e" },
                    { 6, "ul. Polweiska 27, 3130, Poznan, PL", 4, "+123-456-789-022", "b348feb0-037d-40c9-941e-afc111648c6e" },
                    { 7, "ul. Polweiska 27, 3130, Poznan, PL", 5, "+123-456-789-022", "b348feb0-037d-40c9-941e-afc111648c6e" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);
        }
    }
}

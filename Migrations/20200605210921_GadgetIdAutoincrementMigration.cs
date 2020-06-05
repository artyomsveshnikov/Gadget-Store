using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartphoneShop.Migrations
{
    public partial class GadgetIdAutoincrementMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Gadgets",
                columns: new[] { "GadgetId", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Android 4.4 KitKat Tablet PC, Cortex A8 1.2 GHz Dual Core Processor,512MB / 4GB,Dual Camera,G-Sensor (Black)", "prontotec.jpg", "ProntoTec 7", 46.99f },
                    { 2, "Android 4.4 Kit Kat OS, 1.2 GHz quad-core processor", "samsung-galaxy.jpg", "Samsung Galaxy", 120.95f },
                    { 3, "NeuTab N7 Pro tablet features the amazing powerful, Quad Core processor performs approximately Double multitasking running speed, and is more reliable than ever", "neutab.jpg", "NeuTab® N7 Pro 7", 59.99f },
                    { 4, "Dragon Touch Y88X tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere", "dragon-touch.jpg", "Dragon Touch® Y88X 7", 54.99f },
                    { 5, "This Alldaymall tablet featuring the incredible powerful Allwinner Quad Core A33, up to four times faster CPU, ensures faster multitasking speed than ever. With the super-portable size, you get a robust power in a device that can be taken everywhere", "Alldaymall.jpg", "Alldaymall A88X 7", 47.99f },
                    { 6, "Pad 7 ME170CX-A1-BK 7-Inch 16GB Tablet. Dual-Core Intel Atom Z2520 1.2GHz CPU", "asus-memo.jpg", "ASUS MeMO", 94.99f },
                    { 7, "Latest Generation Intel Dual Core Celeron 2.16 GHz Processor (turbo to 2.41 GHz)", "asus-latest.jpg", "ASUS 15.6-Inch", 249.5f },
                    { 8, "This Certified Refurbished product is manufacturer refurbished, shows limited or no wear, and includes all original accessories plus a 90-day warranty", "hp-pavilion.jpg", "HP Pavilion 15-r030wm", 299.95f },
                    { 9, "Intel Celeron N2830 Processor, 15.6-Inch Screen, Intel HD Graphics", "dell-inspiron.jpg", "Dell Inspiron 15.6-Inch", 308f },
                    { 10, "15.6 HD Active Matrix TFT Color LED (1366 x 768) 16:9 CineCrystal Display", "acer-aspire.jpg", "Acer Aspire E Notebook", 299.95f },
                    { 11, "Intel Celeron N2840 Processor. 2 GB DDR3L SDRAM, 32 GB Solid-State Drive and 1TB OneDrive Cloud Storage for one year", "hp-stream.jpg", "HP Stream 13", 202.99f },
                    { 12, "T-Mobile Cell Phone 4G - White. 5MP Camera - Snap creative photos with built-in digital lenses", "nokia-lumia.jpg", "Nokia Lumia 521", 63.99f },
                    { 13, "13 MP Rear Facing BSI Camera / 5 MP Front Facing", "htc-desire.jpg", "HTC Desire 816", 177.99f },
                    { 14, "Uniquely designed 3G-enabled messaging phone with side-flipping QWERTY keyboard and external glow-thru OLED dial pad that 'disappears' when not in use", "sanyo-innuendo.jpg", "Sanyo Innuendo", 54.99f },
                    { 15, "Unlocked world GSM phone. 3G-850/2100, 2G -850/900/1800/1900", "ulefone.jpg", "Ulefone N9000", 133.99f }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Gadgets",
                keyColumn: "GadgetId",
                keyValue: 15);
        }
    }
}

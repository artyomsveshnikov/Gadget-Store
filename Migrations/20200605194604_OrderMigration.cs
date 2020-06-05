using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace SmartphoneShop.Migrations
{
    public partial class OrderMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "actors_pkey",
                table: "Gadgets");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "Gadgets",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Gadgets",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "image",
                table: "Gadgets",
                newName: "Image");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "Gadgets",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "GadgetID",
                table: "Gadgets",
                newName: "GadgetId");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "Gadgets",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "Gadget_pkey",
                table: "Gadgets",
                column: "GadgetId");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    GadgetId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_pkey", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    OrderId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                    table.ForeignKey(
                        name: "FK_User_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Gadgets_OrderId",
                table: "Gadgets",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_User_OrderId",
                table: "User",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Gadgets_Orders_OrderId",
                table: "Gadgets",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gadgets_Orders_OrderId",
                table: "Gadgets");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "Gadget_pkey",
                table: "Gadgets");

            migrationBuilder.DropIndex(
                name: "IX_Gadgets_OrderId",
                table: "Gadgets");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "Gadgets");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Gadgets",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Gadgets",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Gadgets",
                newName: "image");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Gadgets",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "GadgetId",
                table: "Gadgets",
                newName: "GadgetID");

            migrationBuilder.AddPrimaryKey(
                name: "actors_pkey",
                table: "Gadgets",
                column: "GadgetID");
        }
    }
}

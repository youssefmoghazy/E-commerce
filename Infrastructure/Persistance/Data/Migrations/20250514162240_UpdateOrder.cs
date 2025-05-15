using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_orders_OrderId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "Subtotal",
                table: "orders",
                newName: "subtotal");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "orders",
                newName: "BuyerEmail");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_orders_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_orders_OrderId",
                table: "OrderItem");

            migrationBuilder.RenameColumn(
                name: "subtotal",
                table: "orders",
                newName: "Subtotal");

            migrationBuilder.RenameColumn(
                name: "BuyerEmail",
                table: "orders",
                newName: "Email");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_orders_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "orders",
                principalColumn: "Id");
        }
    }
}

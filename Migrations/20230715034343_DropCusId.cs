using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentDemo.Migrations
{
    /// <inheritdoc />
    public partial class DropCusId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Orders_Customers_CustomerId",
            //    table: "Orders");

            //migrationBuilder.DropIndex(
            //    name: "IX_Orders_CustomerId",
            //    table: "Orders");

            migrationBuilder.DropColumn(
                name: "CusId",
                table: "Orders");

            //migrationBuilder.DropColumn(
            //    name: "CustomerId",
            //    table: "Orders");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CusId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            //migrationBuilder.AddColumn<int>(
            //    name: "CustomerId",
            //    table: "Orders",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0);

            //migrationBuilder.CreateIndex(
            //    name: "IX_Orders_CustomerId",
            //    table: "Orders",
            //    column: "CustomerId");

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Orders_Customers_CustomerId",
            //    table: "Orders",
            //    column: "CustomerId",
            //    principalTable: "Customers",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }
    }
}

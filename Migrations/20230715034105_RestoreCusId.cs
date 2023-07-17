﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssignmentDemo.Migrations
{
    /// <inheritdoc />
    public partial class RestoreCusId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CusId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CusId",
                table: "Orders");
        }
    }
}

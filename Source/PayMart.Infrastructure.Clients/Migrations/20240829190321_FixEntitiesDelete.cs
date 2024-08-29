using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayMart.Infrastructure.Clients.Migrations
{
    /// <inheritdoc />
    public partial class FixEntitiesDelete : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tb_Client");

            migrationBuilder.AddColumn<int>(
                name: "DeleteBy",
                table: "Tb_Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeleteDate",
                table: "Tb_Client",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleteBy",
                table: "Tb_Client");

            migrationBuilder.DropColumn(
                name: "DeleteDate",
                table: "Tb_Client");

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tb_Client",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}

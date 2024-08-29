using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PayMart.Infrastructure.Clients.Migrations
{
    /// <inheritdoc />
    public partial class FixEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Tb_Client",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tb_Client",
                newName: "FullName");

            migrationBuilder.RenameColumn(
                name: "Enabled",
                table: "Tb_Client",
                newName: "UpdatedBy");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Tb_Client",
                newName: "ContactEmail");

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "Tb_Client",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Tb_Client",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Tb_Client",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Tb_Client",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Tb_Client",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "Tb_Client");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Tb_Client");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Tb_Client");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Tb_Client");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Tb_Client");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Tb_Client",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "UpdatedBy",
                table: "Tb_Client",
                newName: "Enabled");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Tb_Client",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "ContactEmail",
                table: "Tb_Client",
                newName: "Email");
        }
    }
}

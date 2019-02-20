using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace ECommerce.Migrations
{
    public partial class Catalogue : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_OS_OSId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Storage_StorageId",
                table: "ProductVariants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storage",
                table: "Storage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OS",
                table: "OS");

            migrationBuilder.RenameTable(
                name: "Storage",
                newName: "Storages");

            migrationBuilder.RenameTable(
                name: "OS",
                newName: "OSs");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storages",
                table: "Storages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OSs",
                table: "OSs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OSs_OSId",
                table: "Products",
                column: "OSId",
                principalTable: "OSs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Storages_StorageId",
                table: "ProductVariants",
                column: "StorageId",
                principalTable: "Storages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_OSs_OSId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Storages_StorageId",
                table: "ProductVariants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Storages",
                table: "Storages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OSs",
                table: "OSs");

            migrationBuilder.RenameTable(
                name: "Storages",
                newName: "Storage");

            migrationBuilder.RenameTable(
                name: "OSs",
                newName: "OS");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Storage",
                table: "Storage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OS",
                table: "OS",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_OS_OSId",
                table: "Products",
                column: "OSId",
                principalTable: "OS",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Storage_StorageId",
                table: "ProductVariants",
                column: "StorageId",
                principalTable: "Storage",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

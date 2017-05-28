using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WMB.Data.Migrations
{
    public partial class _270401 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_ProductTypeСollections_ProductTypeСollectionId",
                table: "Beehives");

            migrationBuilder.DropTable(
                name: "ProductTypeСollections");

            migrationBuilder.CreateTable(
                name: "ProductTypeCollections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    zDataZbory = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeCollections", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_ProductTypeCollections_ProductTypeСollectionId",
                table: "Beehives",
                column: "ProductTypeСollectionId",
                principalTable: "ProductTypeCollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_ProductTypeCollections_ProductTypeСollectionId",
                table: "Beehives");

            migrationBuilder.DropTable(
                name: "ProductTypeCollections");

            migrationBuilder.CreateTable(
                name: "ProductTypeСollections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    zDataZbory = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeСollections", x => x.Id);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_ProductTypeСollections_ProductTypeСollectionId",
                table: "Beehives",
                column: "ProductTypeСollectionId",
                principalTable: "ProductTypeСollections",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

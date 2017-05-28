using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WMB.Data.Migrations
{
    public partial class _2704 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AgeUterus",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "Disease",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "PresenceCancer",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "TypeBeesHealth",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "zDataZbory",
                table: "Beehives");

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "ProductTypeСollections",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "zDataZbory",
                table: "ProductTypeСollections",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TypeBeesHealthId",
                table: "Beehives",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UterusId",
                table: "Beehives",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypeBeesHealth",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BeesHealth = table.Column<bool>(nullable: false),
                    Disease = table.Column<string>(nullable: true),
                    zDataDisease = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBeesHealth", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Uterus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Uteru = table.Column<bool>(nullable: false),
                    zDataAgeUterus = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uterus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_TypeBeesHealthId",
                table: "Beehives",
                column: "TypeBeesHealthId");

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_UterusId",
                table: "Beehives",
                column: "UterusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_TypeBeesHealth_TypeBeesHealthId",
                table: "Beehives",
                column: "TypeBeesHealthId",
                principalTable: "TypeBeesHealth",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Beehives_Uterus_UterusId",
                table: "Beehives",
                column: "UterusId",
                principalTable: "Uterus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_TypeBeesHealth_TypeBeesHealthId",
                table: "Beehives");

            migrationBuilder.DropForeignKey(
                name: "FK_Beehives_Uterus_UterusId",
                table: "Beehives");

            migrationBuilder.DropTable(
                name: "TypeBeesHealth");

            migrationBuilder.DropTable(
                name: "Uterus");

            migrationBuilder.DropIndex(
                name: "IX_Beehives_TypeBeesHealthId",
                table: "Beehives");

            migrationBuilder.DropIndex(
                name: "IX_Beehives_UterusId",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "ProductTypeСollections");

            migrationBuilder.DropColumn(
                name: "zDataZbory",
                table: "ProductTypeСollections");

            migrationBuilder.DropColumn(
                name: "TypeBeesHealthId",
                table: "Beehives");

            migrationBuilder.DropColumn(
                name: "UterusId",
                table: "Beehives");

            migrationBuilder.AddColumn<int>(
                name: "AgeUterus",
                table: "Beehives",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Disease",
                table: "Beehives",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "PresenceCancer",
                table: "Beehives",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "TypeBeesHealth",
                table: "Beehives",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Weight",
                table: "Beehives",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "zDataZbory",
                table: "Beehives",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WMB.Data.Migrations
{
    public partial class mogration_001 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "ProductTypeСollections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTypeСollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeBeess",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeBeess", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeHives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeHives", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Beehives",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AgeUterus = table.Column<int>(nullable: false),
                    Coefficientefficiency = table.Column<double>(nullable: false),
                    Disease = table.Column<string>(nullable: true),
                    ImagePath = table.Column<string>(nullable: true),
                    NameHive = table.Column<string>(nullable: true),
                    NumberFrames = table.Column<int>(nullable: false),
                    PresenceCancer = table.Column<bool>(nullable: false),
                    PriceCostsHive = table.Column<decimal>(nullable: false),
                    PriceHive = table.Column<decimal>(nullable: false),
                    ProductTypeСollectionId = table.Column<int>(nullable: true),
                    TypeBeesHealth = table.Column<bool>(nullable: false),
                    TypeBeesId = table.Column<int>(nullable: true),
                    TypeHiveId = table.Column<int>(nullable: true),
                    Weight = table.Column<int>(nullable: false),
                    descriptionDate = table.Column<string>(nullable: true),
                    descriptionHive = table.Column<string>(nullable: true),
                    zData = table.Column<DateTime>(nullable: false),
                    zData1 = table.Column<DateTime>(nullable: false),
                    zData2 = table.Column<DateTime>(nullable: false),
                    zDataZbory = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beehives", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Beehives_ProductTypeСollections_ProductTypeСollectionId",
                        column: x => x.ProductTypeСollectionId,
                        principalTable: "ProductTypeСollections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beehives_TypeBeess_TypeBeesId",
                        column: x => x.TypeBeesId,
                        principalTable: "TypeBeess",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Beehives_TypeHives_TypeHiveId",
                        column: x => x.TypeHiveId,
                        principalTable: "TypeHives",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_ProductTypeСollectionId",
                table: "Beehives",
                column: "ProductTypeСollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_TypeBeesId",
                table: "Beehives",
                column: "TypeBeesId");

            migrationBuilder.CreateIndex(
                name: "IX_Beehives_TypeHiveId",
                table: "Beehives",
                column: "TypeHiveId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Beehives");

            migrationBuilder.DropTable(
                name: "ProductTypeСollections");

            migrationBuilder.DropTable(
                name: "TypeBeess");

            migrationBuilder.DropTable(
                name: "TypeHives");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}

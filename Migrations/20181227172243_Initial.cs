using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HumanResourcesDepartment",
                columns: table => new
                {
                    HumanResourcesDepartmentID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Initial = table.Column<string>(nullable: true),
                    LengthOfService = table.Column<int>(nullable: false),
                    AcceptRawMaterials = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HumanResourcesDepartment", x => x.HumanResourcesDepartmentID);
                });

            migrationBuilder.CreateTable(
                name: "RawMaterials",
                columns: table => new
                {
                    RawMaterialsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RawMaterialsName = table.Column<string>(nullable: true),
                    DescriptionOfRawMaterials = table.Column<string>(nullable: true),
                    ReceptionConditions = table.Column<string>(nullable: true),
                    StorageConditions = table.Column<string>(nullable: true),
                    CostKG = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RawMaterials", x => x.RawMaterialsID);
                });

            migrationBuilder.CreateTable(
                name: "TypeOfStorages",
                columns: table => new
                {
                    TypeOfStoragesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NameOfTypeOfStorages = table.Column<string>(nullable: true),
                    TypesOfRawMaterialsInStorage = table.Column<string>(nullable: true),
                    FireProtection = table.Column<bool>(nullable: false),
                    SpecialEquipment = table.Column<bool>(nullable: false),
                    Humidity = table.Column<float>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeOfStorages", x => x.TypeOfStoragesID);
                });

            migrationBuilder.CreateTable(
                name: "Storages",
                columns: table => new
                {
                    StoragesID = table.Column<string>(nullable: false),
                    NameOfStorage = table.Column<string>(nullable: true),
                    InventoryNumber = table.Column<string>(nullable: true),
                    DesignatedEmployee = table.Column<string>(nullable: true),
                    SquareOfStorage = table.Column<int>(nullable: false),
                    Tonnage = table.Column<float>(nullable: false),
                    FillingPercentage = table.Column<float>(nullable: false),
                    TypeOfStoragesID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Storages", x => x.StoragesID);
                    table.ForeignKey(
                        name: "FK_Storages_TypeOfStorages_TypeOfStoragesID",
                        column: x => x.TypeOfStoragesID,
                        principalTable: "TypeOfStorages",
                        principalColumn: "TypeOfStoragesID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcceptedRawMaterials",
                columns: table => new
                {
                    AcceptedRawMaterialsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    TypeOfRawMaterials = table.Column<string>(nullable: true),
                    NumberKG = table.Column<int>(nullable: false),
                    Employee = table.Column<string>(nullable: true),
                    RoomOfStorage = table.Column<string>(nullable: true),
                    DateAndTime = table.Column<DateTime>(nullable: false),
                    Cost = table.Column<decimal>(nullable: false),
                    RawMaterialsID = table.Column<int>(nullable: false),
                    HumanResourcesDepartmentID = table.Column<int>(nullable: false),
                    StoragesID = table.Column<int>(nullable: false),
                    StoragesID1 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptedRawMaterials", x => x.AcceptedRawMaterialsID);
                    table.ForeignKey(
                        name: "FK_AcceptedRawMaterials_HumanResourcesDepartment_HumanResourcesDepartmentID",
                        column: x => x.HumanResourcesDepartmentID,
                        principalTable: "HumanResourcesDepartment",
                        principalColumn: "HumanResourcesDepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcceptedRawMaterials_RawMaterials_RawMaterialsID",
                        column: x => x.RawMaterialsID,
                        principalTable: "RawMaterials",
                        principalColumn: "RawMaterialsID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AcceptedRawMaterials_Storages_StoragesID1",
                        column: x => x.StoragesID1,
                        principalTable: "Storages",
                        principalColumn: "StoragesID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptedRawMaterials_HumanResourcesDepartmentID",
                table: "AcceptedRawMaterials",
                column: "HumanResourcesDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptedRawMaterials_RawMaterialsID",
                table: "AcceptedRawMaterials",
                column: "RawMaterialsID");

            migrationBuilder.CreateIndex(
                name: "IX_AcceptedRawMaterials_StoragesID1",
                table: "AcceptedRawMaterials",
                column: "StoragesID1");

            migrationBuilder.CreateIndex(
                name: "IX_Storages_TypeOfStoragesID",
                table: "Storages",
                column: "TypeOfStoragesID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AcceptedRawMaterials");

            migrationBuilder.DropTable(
                name: "HumanResourcesDepartment");

            migrationBuilder.DropTable(
                name: "RawMaterials");

            migrationBuilder.DropTable(
                name: "Storages");

            migrationBuilder.DropTable(
                name: "TypeOfStorages");
        }
    }
}

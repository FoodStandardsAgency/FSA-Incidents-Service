using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FSA.SIMSManagerDb.Migrations
{
    public partial class initOnlineForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OnlineForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(maxLength: 250, nullable: true),
                    NotifierType = table.Column<string>(maxLength: 250, nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Action = table.Column<string>(nullable: true),
                    DistributionDetails = table.Column<string>(nullable: true),
                    DeathIllness = table.Column<string>(nullable: true),
                    LADetails = table.Column<string>(nullable: true),
                    AdditionalInformation = table.Column<string>(nullable: true),
                    IncidentTypeId = table.Column<int>(nullable: false),
                    IsClosed = table.Column<bool>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineForms_HazardGroups_IncidentTypeId",
                        column: x => x.IncidentTypeId,
                        principalTable: "HazardGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlineFormNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Note = table.Column<string>(nullable: false),
                    OnlineFormId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineFormNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineFormNotes_OnlineForms_OnlineFormId",
                        column: x => x.OnlineFormId,
                        principalTable: "OnlineForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlineFormProducts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HostId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Brand = table.Column<string>(nullable: true),
                    ProductTypeId = table.Column<int>(nullable: false),
                    CountryOfOriginId = table.Column<int>(nullable: false),
                    Amount = table.Column<string>(nullable: true, defaultValue: "0.00"),
                    AmountUnitTypeId = table.Column<int>(nullable: false),
                    BatchCodes = table.Column<string>(nullable: true),
                    PackDescription = table.Column<string>(nullable: true),
                    AdditionalInfo = table.Column<string>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineFormProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineFormProducts_UnitQuantities_AmountUnitTypeId",
                        column: x => x.AmountUnitTypeId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OnlineFormProducts_Countries_CountryOfOriginId",
                        column: x => x.CountryOfOriginId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineFormProducts_OnlineForms_HostId",
                        column: x => x.HostId,
                        principalTable: "OnlineForms",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OnlineFormProducts_ProductTypes_ProductTypeId",
                        column: x => x.ProductTypeId,
                        principalTable: "ProductTypes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OnlineFormStakeholders",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnlineFormId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    GovDept = table.Column<string>(nullable: true),
                    Role = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    StakeholderDiscriminatorId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineFormStakeholders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineFormStakeholders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineFormStakeholders_OnlineForms_OnlineFormId",
                        column: x => x.OnlineFormId,
                        principalTable: "OnlineForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineFormStakeholders_StakeholderDiscriminators_StakeholderDiscriminatorId",
                        column: x => x.StakeholderDiscriminatorId,
                        principalTable: "StakeholderDiscriminators",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OnlineFormProductDates",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OnlineFormId = table.Column<int>(nullable: false),
                    DateTypeId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    OnlineFormProductDbId = table.Column<int>(nullable: true),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineFormProductDates", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineFormProductDates_ProductDateTypes_DateTypeId",
                        column: x => x.DateTypeId,
                        principalTable: "ProductDateTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineFormProductDates_OnlineFormProducts_OnlineFormProductDbId",
                        column: x => x.OnlineFormProductDbId,
                        principalTable: "OnlineFormProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineFormProductFbos",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false),
                    AddressId = table.Column<int>(nullable: false),
                    FboTypes = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineFormProductFbos", x => new { x.ProductId, x.AddressId });
                    table.ForeignKey(
                        name: "FK_OnlineFormProductFbos_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OnlineFormProductFbos_OnlineFormProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "OnlineFormProducts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OnlineFormProductPackSizes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Size = table.Column<string>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    OnlineFormId = table.Column<int>(nullable: false),
                    ModifiedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Modified = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    CreatedBy = table.Column<string>(maxLength: 70, nullable: false),
                    Created = table.Column<DateTime>(nullable: false, defaultValueSql: "getutcdate()"),
                    Timestamp = table.Column<byte[]>(rowVersion: true, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineFormProductPackSizes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OnlineFormProductPackSizes_OnlineFormProducts_OnlineFormId",
                        column: x => x.OnlineFormId,
                        principalTable: "OnlineFormProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OnlineFormProductPackSizes_UnitQuantities_UnitId",
                        column: x => x.UnitId,
                        principalTable: "UnitQuantities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormNotes_OnlineFormId",
                table: "OnlineFormNotes",
                column: "OnlineFormId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProductDates_DateTypeId",
                table: "OnlineFormProductDates",
                column: "DateTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProductDates_OnlineFormProductDbId",
                table: "OnlineFormProductDates",
                column: "OnlineFormProductDbId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProductFbos_AddressId",
                table: "OnlineFormProductFbos",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProductPackSizes_OnlineFormId",
                table: "OnlineFormProductPackSizes",
                column: "OnlineFormId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProductPackSizes_UnitId",
                table: "OnlineFormProductPackSizes",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProducts_AmountUnitTypeId",
                table: "OnlineFormProducts",
                column: "AmountUnitTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProducts_CountryOfOriginId",
                table: "OnlineFormProducts",
                column: "CountryOfOriginId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProducts_HostId",
                table: "OnlineFormProducts",
                column: "HostId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormProducts_ProductTypeId",
                table: "OnlineFormProducts",
                column: "ProductTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineForms_IncidentTypeId",
                table: "OnlineForms",
                column: "IncidentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormStakeholders_AddressId",
                table: "OnlineFormStakeholders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormStakeholders_OnlineFormId",
                table: "OnlineFormStakeholders",
                column: "OnlineFormId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineFormStakeholders_StakeholderDiscriminatorId",
                table: "OnlineFormStakeholders",
                column: "StakeholderDiscriminatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OnlineFormNotes");

            migrationBuilder.DropTable(
                name: "OnlineFormProductDates");

            migrationBuilder.DropTable(
                name: "OnlineFormProductFbos");

            migrationBuilder.DropTable(
                name: "OnlineFormProductPackSizes");

            migrationBuilder.DropTable(
                name: "OnlineFormStakeholders");

            migrationBuilder.DropTable(
                name: "OnlineFormProducts");

            migrationBuilder.DropTable(
                name: "OnlineForms");
        }
    }
}

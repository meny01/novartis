using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace novartis2.Data.Migrations
{
    public partial class novar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    AccountId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountType = table.Column<int>(nullable: false),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 50, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    LastName = table.Column<string>(maxLength: 50, nullable: false),
                    MidName = table.Column<string>(maxLength: 45, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.AccountId);
                });

            migrationBuilder.CreateTable(
                name: "companies",
                columns: table => new
                {
                    CompanyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CompanyName = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_companies", x => x.CompanyId);
                });

            migrationBuilder.CreateTable(
                name: "scWorkingDays",
                columns: table => new
                {
                    ScWorkingDayId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(nullable: false),
                    Month = table.Column<int>(nullable: false),
                    Quarter = table.Column<int>(nullable: false),
                    WorkingDays = table.Column<decimal>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scWorkingDays", x => x.ScWorkingDayId);
                });

            migrationBuilder.CreateTable(
                name: "ScBrands",
                columns: table => new
                {
                    BrandId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    BrandName = table.Column<string>(maxLength: 50, nullable: false),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ModifierAccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScBrands", x => x.BrandId);
                    table.ForeignKey(
                        name: "FK_ScBrands_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScBrands_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScHmos",
                columns: table => new
                {
                    HmoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    HmoName = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ModifierAccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScHmos", x => x.HmoId);
                    table.ForeignKey(
                        name: "FK_ScHmos_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScHmos_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScProducts",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ClalitCode = table.Column<int>(nullable: true),
                    ClalitPrice = table.Column<decimal>(nullable: true),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsVisible = table.Column<bool>(nullable: false),
                    LeumitPrice = table.Column<decimal>(nullable: true),
                    MaccabiPrice = table.Column<decimal>(nullable: true),
                    MeuhedetPrice = table.Column<decimal>(nullable: true),
                    ModifierAccountId = table.Column<int>(nullable: true),
                    ProductBrandId = table.Column<int>(nullable: false),
                    ProductCode = table.Column<string>(maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(maxLength: 100, nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    YarpaCode = table.Column<int>(nullable: true),
                    YearActive = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScProducts", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_ScProducts_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScProducts_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ScAgents",
                columns: table => new
                {
                    AgentId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: false),
                    CompanyId = table.Column<int>(nullable: false),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateAdded = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    IsFormSale = table.Column<bool>(nullable: true),
                    IsPharmSale = table.Column<bool>(nullable: true),
                    ModifierAccountId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScAgents", x => x.AgentId);
                    table.ForeignKey(
                        name: "FK_ScAgents_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScAgents_companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "companies",
                        principalColumn: "CompanyId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScAgents_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScAgents_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "scPharmacies",
                columns: table => new
                {
                    PharmacyId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: false),
                    Address = table.Column<string>(maxLength: 200, nullable: true),
                    City = table.Column<string>(maxLength: 50, nullable: true),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    HmoId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ModifierAccountId = table.Column<int>(nullable: true),
                    PharmacyClass = table.Column<int>(nullable: false),
                    PharmacyCodeId = table.Column<string>(maxLength: 50, nullable: true),
                    PharmacyErepId = table.Column<int>(nullable: true),
                    PharmacyGroup = table.Column<int>(nullable: false),
                    PharmacyGsl = table.Column<int>(nullable: true),
                    PharmacyName = table.Column<string>(maxLength: 200, nullable: false),
                    PharmacySector = table.Column<int>(nullable: true),
                    Phone = table.Column<string>(maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scPharmacies", x => x.PharmacyId);
                    table.ForeignKey(
                        name: "FK_scPharmacies_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scPharmacies_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_scPharmacies_ScHmos_HmoId",
                        column: x => x.HmoId,
                        principalTable: "ScHmos",
                        principalColumn: "HmoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scPharmacies_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "scAgentGoals",
                columns: table => new
                {
                    AgentGoalId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: false),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    HmoId = table.Column<int>(nullable: false),
                    ModifierAccountId = table.Column<int>(nullable: true),
                    ProductId = table.Column<int>(nullable: false),
                    Q1Quantity = table.Column<int>(nullable: true),
                    Q2Quantity = table.Column<int>(nullable: true),
                    Q3Quantity = table.Column<int>(nullable: true),
                    Q4Quantity = table.Column<int>(nullable: true),
                    Year = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_scAgentGoals", x => x.AgentGoalId);
                    table.ForeignKey(
                        name: "FK_scAgentGoals_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scAgentGoals_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_scAgentGoals_ScHmos_HmoId",
                        column: x => x.HmoId,
                        principalTable: "ScHmos",
                        principalColumn: "HmoId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_scAgentGoals_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_scAgentGoals_ScProducts_ProductId",
                        column: x => x.ProductId,
                        principalTable: "ScProducts",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ScOrders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AccountId = table.Column<int>(nullable: false),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ModifierAccountId = table.Column<int>(nullable: true),
                    PharmacyId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScOrders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_ScOrders_accounts_AccountId",
                        column: x => x.AccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ScOrders_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScOrders_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScOrders_scPharmacies_PharmacyId",
                        column: x => x.PharmacyId,
                        principalTable: "scPharmacies",
                        principalColumn: "PharmacyId"
                       );
                });

            migrationBuilder.CreateTable(
                name: "ScOrderProducts",
                columns: table => new
                {
                    OrderProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatorAccountId = table.Column<int>(nullable: true),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    DateModified = table.Column<DateTime>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    ModifierAccountId = table.Column<int>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScOrderProducts", x => x.OrderProductId);
                    table.ForeignKey(
                        name: "FK_ScOrderProducts_accounts_CreatorAccountId",
                        column: x => x.CreatorAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScOrderProducts_accounts_ModifierAccountId",
                        column: x => x.ModifierAccountId,
                        principalTable: "accounts",
                        principalColumn: "AccountId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScOrderProducts_ScOrders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "ScOrders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_scAgentGoals_AccountId",
                table: "scAgentGoals",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_scAgentGoals_CreatorAccountId",
                table: "scAgentGoals",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_scAgentGoals_HmoId",
                table: "scAgentGoals",
                column: "HmoId");

            migrationBuilder.CreateIndex(
                name: "IX_scAgentGoals_ModifierAccountId",
                table: "scAgentGoals",
                column: "ModifierAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_scAgentGoals_ProductId",
                table: "scAgentGoals",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ScAgents_AccountId",
                table: "ScAgents",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScAgents_CompanyId",
                table: "ScAgents",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_ScAgents_CreatorAccountId",
                table: "ScAgents",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScAgents_ModifierAccountId",
                table: "ScAgents",
                column: "ModifierAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScBrands_CreatorAccountId",
                table: "ScBrands",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScBrands_ModifierAccountId",
                table: "ScBrands",
                column: "ModifierAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScHmos_CreatorAccountId",
                table: "ScHmos",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScHmos_ModifierAccountId",
                table: "ScHmos",
                column: "ModifierAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScOrderProducts_CreatorAccountId",
                table: "ScOrderProducts",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScOrderProducts_ModifierAccountId",
                table: "ScOrderProducts",
                column: "ModifierAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScOrderProducts_OrderId",
                table: "ScOrderProducts",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_ScOrders_AccountId",
                table: "ScOrders",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScOrders_CreatorAccountId",
                table: "ScOrders",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScOrders_ModifierAccountId",
                table: "ScOrders",
                column: "ModifierAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScOrders_PharmacyId",
                table: "ScOrders",
                column: "PharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_scPharmacies_AccountId",
                table: "scPharmacies",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_scPharmacies_CreatorAccountId",
                table: "scPharmacies",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_scPharmacies_HmoId",
                table: "scPharmacies",
                column: "HmoId");

            migrationBuilder.CreateIndex(
                name: "IX_scPharmacies_ModifierAccountId",
                table: "scPharmacies",
                column: "ModifierAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScProducts_CreatorAccountId",
                table: "ScProducts",
                column: "CreatorAccountId");

            migrationBuilder.CreateIndex(
                name: "IX_ScProducts_ModifierAccountId",
                table: "ScProducts",
                column: "ModifierAccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "scAgentGoals");

            migrationBuilder.DropTable(
                name: "ScAgents");

            migrationBuilder.DropTable(
                name: "ScBrands");

            migrationBuilder.DropTable(
                name: "ScOrderProducts");

            migrationBuilder.DropTable(
                name: "scWorkingDays");

            migrationBuilder.DropTable(
                name: "ScProducts");

            migrationBuilder.DropTable(
                name: "companies");

            migrationBuilder.DropTable(
                name: "ScOrders");

            migrationBuilder.DropTable(
                name: "scPharmacies");

            migrationBuilder.DropTable(
                name: "ScHmos");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropIndex(
                name: "UserNameIndex",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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

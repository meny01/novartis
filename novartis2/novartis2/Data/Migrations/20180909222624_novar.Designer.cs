﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using novartis2.Data;
using System;

namespace novartis2.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180909222624_novar")]
    partial class novar
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MSContext.Account", b =>
                {
                    b.Property<int>("AccountId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountType");

                    b.Property<DateTime>("DateCreated");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("MidName")
                        .HasMaxLength(45);

                    b.HasKey("AccountId");

                    b.ToTable("accounts");
                });

            modelBuilder.Entity("MSContext.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive");

                    b.HasKey("CompanyId");

                    b.ToTable("companies");
                });

            modelBuilder.Entity("MSContext.ScAgent", b =>
                {
                    b.Property<int>("AgentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<int>("CompanyId");

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateAdded");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("IsActive");

                    b.Property<bool?>("IsFormSale");

                    b.Property<bool?>("IsPharmSale");

                    b.Property<int?>("ModifierAccountId");

                    b.HasKey("AgentId");

                    b.HasIndex("AccountId");

                    b.HasIndex("CompanyId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("ModifierAccountId");

                    b.ToTable("ScAgents");
                });

            modelBuilder.Entity("MSContext.ScAgentGoal", b =>
                {
                    b.Property<int>("AgentGoalId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("HmoId");

                    b.Property<int?>("ModifierAccountId");

                    b.Property<int>("ProductId");

                    b.Property<int?>("Q1Quantity");

                    b.Property<int?>("Q2Quantity");

                    b.Property<int?>("Q3Quantity");

                    b.Property<int?>("Q4Quantity");

                    b.Property<int?>("Year");

                    b.HasKey("AgentGoalId");

                    b.HasIndex("AccountId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("HmoId");

                    b.HasIndex("ModifierAccountId");

                    b.HasIndex("ProductId");

                    b.ToTable("scAgentGoals");
                });

            modelBuilder.Entity("MSContext.ScBrand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("ModifierAccountId");

                    b.HasKey("BrandId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("ModifierAccountId");

                    b.ToTable("ScBrands");
                });

            modelBuilder.Entity("MSContext.ScHmo", b =>
                {
                    b.Property<int>("HmoId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<string>("HmoName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<bool>("IsActive");

                    b.Property<int?>("ModifierAccountId");

                    b.HasKey("HmoId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("ModifierAccountId");

                    b.ToTable("ScHmos");
                });

            modelBuilder.Entity("MSContext.ScOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("ModifierAccountId");

                    b.Property<int>("PharmacyId");

                    b.HasKey("OrderId");

                    b.HasIndex("AccountId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("ModifierAccountId");

                    b.HasIndex("PharmacyId");

                    b.ToTable("ScOrders");
                });

            modelBuilder.Entity("MSContext.ScOrderProduct", b =>
                {
                    b.Property<int>("OrderProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("ModifierAccountId");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("OrderProductId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("ModifierAccountId");

                    b.HasIndex("OrderId");

                    b.ToTable("ScOrderProducts");
                });

            modelBuilder.Entity("MSContext.ScPharmacy", b =>
                {
                    b.Property<int>("PharmacyId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccountId");

                    b.Property<string>("Address")
                        .HasMaxLength(200);

                    b.Property<string>("City")
                        .HasMaxLength(50);

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<int>("HmoId");

                    b.Property<bool>("IsActive");

                    b.Property<int?>("ModifierAccountId");

                    b.Property<int>("PharmacyClass");

                    b.Property<string>("PharmacyCodeId")
                        .HasMaxLength(50);

                    b.Property<int?>("PharmacyErepId");

                    b.Property<int>("PharmacyGroup");

                    b.Property<int?>("PharmacyGsl");

                    b.Property<string>("PharmacyName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<int?>("PharmacySector");

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.HasKey("PharmacyId");

                    b.HasIndex("AccountId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("HmoId");

                    b.HasIndex("ModifierAccountId");

                    b.ToTable("scPharmacies");
                });

            modelBuilder.Entity("MSContext.ScProduct", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("ClalitCode");

                    b.Property<decimal?>("ClalitPrice");

                    b.Property<int?>("CreatorAccountId");

                    b.Property<DateTime>("DateCreated");

                    b.Property<DateTime>("DateModified");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsVisible");

                    b.Property<decimal?>("LeumitPrice");

                    b.Property<decimal?>("MaccabiPrice");

                    b.Property<decimal?>("MeuhedetPrice");

                    b.Property<int?>("ModifierAccountId");

                    b.Property<int>("ProductBrandId");

                    b.Property<string>("ProductCode")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<int>("Quantity");

                    b.Property<int?>("YarpaCode");

                    b.Property<int>("YearActive");

                    b.HasKey("ProductId");

                    b.HasIndex("CreatorAccountId");

                    b.HasIndex("ModifierAccountId");

                    b.ToTable("ScProducts");
                });

            modelBuilder.Entity("MSContext.ScWorkingDay", b =>
                {
                    b.Property<int>("ScWorkingDayId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<int>("Month");

                    b.Property<int>("Quarter");

                    b.Property<decimal>("WorkingDays");

                    b.Property<int>("Year");

                    b.HasKey("ScWorkingDayId");

                    b.ToTable("scWorkingDays");
                });

            modelBuilder.Entity("novartis2.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("novartis2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("novartis2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("novartis2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("novartis2.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSContext.ScAgent", b =>
                {
                    b.HasOne("MSContext.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSContext.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");
                });

            modelBuilder.Entity("MSContext.ScAgentGoal", b =>
                {
                    b.HasOne("MSContext.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.ScHmo", "Hmo")
                        .WithMany()
                        .HasForeignKey("HmoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");

                    b.HasOne("MSContext.ScProduct", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSContext.ScBrand", b =>
                {
                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");
                });

            modelBuilder.Entity("MSContext.ScHmo", b =>
                {
                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");
                });

            modelBuilder.Entity("MSContext.ScOrder", b =>
                {
                    b.HasOne("MSContext.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");

                    b.HasOne("MSContext.ScPharmacy", "Pharmacy")
                        .WithMany("ScOrders")
                        .HasForeignKey("PharmacyId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSContext.ScOrderProduct", b =>
                {
                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");

                    b.HasOne("MSContext.ScOrder", "ScOrder")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MSContext.ScPharmacy", b =>
                {
                    b.HasOne("MSContext.Account", "Account")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.ScHmo", "Hmo")
                        .WithMany()
                        .HasForeignKey("HmoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");
                });

            modelBuilder.Entity("MSContext.ScProduct", b =>
                {
                    b.HasOne("MSContext.Account", "CreatorAccount")
                        .WithMany()
                        .HasForeignKey("CreatorAccountId");

                    b.HasOne("MSContext.Account", "ModifierAccount")
                        .WithMany()
                        .HasForeignKey("ModifierAccountId");
                });
#pragma warning restore 612, 618
        }
    }
}

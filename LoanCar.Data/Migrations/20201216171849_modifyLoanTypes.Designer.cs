﻿// <auto-generated />
using System;
using LoanCar.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoanCar.Data.Migrations
{
    [DbContext(typeof(CrudApiDbContext))]
    [Migration("20201216171849_modifyLoanTypes")]
    partial class modifyLoanTypes
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoanCar.Data.Contact", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("Message")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Contact","fac");
                });

            modelBuilder.Entity("LoanCar.Data.Loan", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApplicantAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(135)")
                        .HasMaxLength(135);

                    b.Property<string>("ApplicantCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("ApplicantDateOfBirth")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<short>("ApplicantEmployerHowLongMonth")
                        .HasColumnType("smallint");

                    b.Property<short>("ApplicantEmployerHowLongYear")
                        .HasColumnType("smallint");

                    b.Property<long>("ApplicantEmployerMonthlyIncome")
                        .HasColumnType("bigint");

                    b.Property<string>("ApplicantEmployerName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("ApplicantEmployerOccupation")
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<long>("ApplicantEmployerPhone")
                        .HasColumnType("bigint");

                    b.Property<string>("ApplicantEmployerTwoIncome")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("ApplicantFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<short>("ApplicantHowLongMonth")
                        .HasColumnType("smallint");

                    b.Property<short>("ApplicantHowLongYear")
                        .HasColumnType("smallint");

                    b.Property<string>("ApplicantLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("ApplicantMiddleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("ApplicantPhone")
                        .HasColumnType("bigint");

                    b.Property<string>("ApplicantPostalCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("ApplicantProvince")
                        .IsRequired()
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<long>("ApplicantSIN")
                        .HasColumnType("bigint");

                    b.Property<string>("BalanceOwing")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("CpApplicantPhone")
                        .HasColumnType("bigint");

                    b.Property<DateTimeOffset>("Created")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Difference")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("DocFEE")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("DownPMT")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("DriverLicence")
                        .HasColumnType("nvarchar(12)")
                        .HasMaxLength(12);

                    b.Property<string>("ExpDate")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MarketValue")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Mortgage")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("MortgageBalance")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("MortgageHolder")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("NatureBusiness")
                        .HasColumnType("nvarchar(40)")
                        .HasMaxLength(40);

                    b.Property<string>("OwnStatus")
                        .IsRequired()
                        .HasColumnType("nvarchar(4)")
                        .HasMaxLength(4);

                    b.Property<string>("PresentEmployerAddress")
                        .HasColumnType("nvarchar(135)")
                        .HasMaxLength(135);

                    b.Property<short>("PresentEmployerHowLongMonth")
                        .HasColumnType("smallint");

                    b.Property<short>("PresentEmployerHowLongYear")
                        .HasColumnType("smallint");

                    b.Property<long>("PresentEmployerMonthlyIncome")
                        .HasColumnType("bigint");

                    b.Property<string>("PresentEmployerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("PresentEmployerOccupation")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<long>("PresentEmployerPhone")
                        .HasColumnType("bigint");

                    b.Property<string>("PresentEmployerTwoIncome")
                        .HasColumnType("nvarchar(70)")
                        .HasMaxLength(70);

                    b.Property<string>("PreviousApplicantAddress")
                        .HasColumnType("nvarchar(135)")
                        .HasMaxLength(135);

                    b.Property<string>("PreviousApplicantCity")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<short>("PreviousApplicantHowLongMonth")
                        .HasColumnType("smallint");

                    b.Property<short>("PreviousApplicantHowLongYear")
                        .HasColumnType("smallint");

                    b.Property<string>("PreviousApplicantPostalCode")
                        .HasColumnType("nvarchar(6)")
                        .HasMaxLength(6);

                    b.Property<string>("PreviousApplicantProvince")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<short>("PreviousEmployerHowLongMonth")
                        .HasColumnType("smallint");

                    b.Property<short>("PreviousEmployerHowLongYear")
                        .HasColumnType("smallint");

                    b.Property<string>("PreviousEmployerName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<long>("PreviousEmployerPhone")
                        .HasColumnType("bigint");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("SolidVehicleDamage")
                        .HasColumnType("bit");

                    b.Property<long>("SolidVehicleKms")
                        .HasColumnType("bigint");

                    b.Property<string>("SolidVehicleMake")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("SolidVehicleModel")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<bool>("SolidVehicleOut")
                        .HasColumnType("bit");

                    b.Property<bool>("SolidVehicleRebuilt")
                        .HasColumnType("bit");

                    b.Property<string>("SolidVehicleVin")
                        .HasColumnType("nvarchar(17)")
                        .HasMaxLength(17);

                    b.Property<int>("SolidVehicleYear")
                        .HasColumnType("int");

                    b.Property<string>("SpouseDateOfBirth")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SpouseFirstName")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SpouseLastName")
                        .HasColumnType("nvarchar(100)")
                        .HasMaxLength(100);

                    b.Property<string>("SpouseMiddleName")
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<long>("SpouseSIN")
                        .HasColumnType("bigint");

                    b.Property<string>("Trade")
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<bool>("TradeVehicleDamage")
                        .HasColumnType("bit");

                    b.Property<long>("TradeVehicleKms")
                        .HasColumnType("bigint");

                    b.Property<string>("TradeVehicleMake")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("TradeVehicleModel")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<bool>("TradeVehicleOut")
                        .HasColumnType("bit");

                    b.Property<bool>("TradeVehicleRebuilt")
                        .HasColumnType("bit");

                    b.Property<string>("TradeVehicleVin")
                        .HasColumnType("nvarchar(17)")
                        .HasMaxLength(17);

                    b.Property<int>("TradeVehicleYear")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Loan","fac");
                });
#pragma warning restore 612, 618
        }
    }
}

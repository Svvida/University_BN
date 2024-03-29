﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using University_BN.Models;

#nullable disable

namespace University_BN.Migrations
{
    [DbContext(typeof(UniversityContext))]
    [Migration("20240311134131_SeedData")]
    partial class SeedData
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");
            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("University_BN.Models.DoctrineMigrationVersion", b =>
                {
                    b.Property<string>("Version")
                        .HasMaxLength(191)
                        .HasColumnType("varchar(191)")
                        .HasColumnName("version");

                    b.Property<DateTime?>("ExecutedAt")
                        .HasColumnType("datetime")
                        .HasColumnName("executed_at");

                    b.Property<int?>("ExecutionTime")
                        .HasColumnType("int")
                        .HasColumnName("execution_time");

                    b.HasKey("Version")
                        .HasName("PRIMARY");

                    b.ToTable("doctrine_migration_versions", (string)null);

                    MySqlEntityTypeBuilderExtensions.HasCharSet(b, "utf8mb3");
                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb3_unicode_ci");
                });

            modelBuilder.Entity("University_BN.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("account_id");

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("varchar(21)")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("varchar(55)")
                        .HasColumnName("name");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("pesel");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("varchar(55)")
                        .HasColumnName("surname");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "AccountId" }, "UNIQ_BA82C3009B6B5FBA")
                        .IsUnique();

                    b.HasIndex(new[] { "AddressId" }, "UNIQ_BA82C300F5B7AF75")
                        .IsUnique();

                    b.ToTable("employees", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            AddressId = 1,
                            DateOfBirth = new DateOnly(1980, 1, 1),
                            Gender = "Male",
                            Name = "Jan",
                            Pesel = "80010112345",
                            Surname = "Nowak"
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            AddressId = 2,
                            DateOfBirth = new DateOnly(1985, 2, 2),
                            Gender = "Female",
                            Name = "Anna",
                            Pesel = "85020212345",
                            Surname = "Kowalska"
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 3,
                            AddressId = 3,
                            DateOfBirth = new DateOnly(1990, 3, 3),
                            Gender = "Male",
                            Name = "Piotr",
                            Pesel = "90030312345",
                            Surname = "Wiśniewski"
                        });
                });

            modelBuilder.Entity("University_BN.Models.EmployeesAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApartmentNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("apartment_number");

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("building_number");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("country");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("postal_code");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("street");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("employees_addresses", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentNumber = "1",
                            BuildingNumber = "1",
                            City = "Warsaw",
                            Country = "Poland",
                            PostalCode = "00-001",
                            Street = "Marszałkowska"
                        },
                        new
                        {
                            Id = 2,
                            ApartmentNumber = "2",
                            BuildingNumber = "2",
                            City = "Krakow",
                            Country = "Poland",
                            PostalCode = "30-001",
                            Street = "Floriańska"
                        },
                        new
                        {
                            Id = 3,
                            ApartmentNumber = "3",
                            BuildingNumber = "3",
                            City = "Gdansk",
                            Country = "Poland",
                            PostalCode = "80-001",
                            Street = "Długa"
                        });
                });

            modelBuilder.Entity("University_BN.Models.Grade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("GradeEu")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("grade_eu");

                    b.Property<string>("GradeUsa")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("varchar(2)")
                        .HasColumnName("grade_usa");

                    b.Property<decimal>("Value")
                        .HasPrecision(3, 2)
                        .HasColumnType("decimal(3,2)")
                        .HasColumnName("value");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("grades", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");
                });

            modelBuilder.Entity("University_BN.Models.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("roles", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Administrator"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Employee"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Student"
                        });
                });

            modelBuilder.Entity("University_BN.Models.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int")
                        .HasColumnName("account_id");

                    b.Property<int>("AddressId")
                        .HasColumnType("int")
                        .HasColumnName("address_id");

                    b.Property<DateOnly>("DateOfBirth")
                        .HasColumnType("date")
                        .HasColumnName("date_of_birth");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("varchar(21)")
                        .HasColumnName("gender");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("varchar(55)")
                        .HasColumnName("name");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("varchar(11)")
                        .HasColumnName("pesel");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("varchar(55)")
                        .HasColumnName("surname");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.HasIndex(new[] { "AccountId" }, "UNIQ_A4698DB29B6B5FBA")
                        .IsUnique();

                    b.HasIndex(new[] { "AddressId" }, "UNIQ_A4698DB2F5B7AF75")
                        .IsUnique();

                    b.ToTable("students", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccountId = 1,
                            AddressId = 1,
                            DateOfBirth = new DateOnly(2000, 1, 1),
                            Gender = "Mężczyzna",
                            Name = "Jan",
                            Pesel = "00010112345",
                            Surname = "Nowak"
                        },
                        new
                        {
                            Id = 2,
                            AccountId = 2,
                            AddressId = 2,
                            DateOfBirth = new DateOnly(2001, 2, 2),
                            Gender = "Kobieta",
                            Name = "Anna",
                            Pesel = "01020212345",
                            Surname = "Kowalska"
                        },
                        new
                        {
                            Id = 3,
                            AccountId = 3,
                            AddressId = 3,
                            DateOfBirth = new DateOnly(2002, 3, 3),
                            Gender = "Mężczyzna",
                            Name = "Piotr",
                            Pesel = "02030312345",
                            Surname = "Wiśniewski"
                        });
                });

            modelBuilder.Entity("University_BN.Models.StudentsAddress", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ApartmentNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("apartment_number");

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("building_number");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("city");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("varchar(150)")
                        .HasColumnName("country");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("varchar(15)")
                        .HasColumnName("postal_code");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("street");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("students_addresses", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ApartmentNumber = "10",
                            BuildingNumber = "4",
                            City = "Wroclaw",
                            Country = "Poland",
                            PostalCode = "50-001",
                            Street = "Oławska"
                        },
                        new
                        {
                            Id = 2,
                            ApartmentNumber = "20",
                            BuildingNumber = "5",
                            City = "Poznan",
                            Country = "Poland",
                            PostalCode = "60-001",
                            Street = "Półwiejska"
                        },
                        new
                        {
                            Id = 3,
                            ApartmentNumber = "30",
                            BuildingNumber = "6",
                            City = "Lodz",
                            Country = "Poland",
                            PostalCode = "90-001",
                            Street = "Piotrkowska"
                        });
                });

            modelBuilder.Entity("University_BN.Models.UsersAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(320)
                        .HasColumnType("varchar(320)")
                        .HasColumnName("email");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasMaxLength(16)
                        .HasColumnType("varchar(16)")
                        .HasColumnName("login");

                    b.Property<bool>("State")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("state");

                    b.HasKey("Id")
                        .HasName("PRIMARY");

                    b.ToTable("users_accounts", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "jan.nowak@example.com",
                            Login = "jan_nowak",
                            State = true
                        },
                        new
                        {
                            Id = 2,
                            Email = "anna.kowalska@example.com",
                            Login = "anna_kowalska",
                            State = true
                        },
                        new
                        {
                            Id = 3,
                            Email = "piotr.wisniewski@example.com",
                            Login = "piotr_wisniewski",
                            State = true
                        });
                });

            modelBuilder.Entity("UsersAccountsRole", b =>
                {
                    b.Property<int>("UsersAccountsId")
                        .HasColumnType("int")
                        .HasColumnName("users_accounts_id");

                    b.Property<int>("RolesId")
                        .HasColumnType("int")
                        .HasColumnName("roles_id");

                    b.HasKey("UsersAccountsId", "RolesId")
                        .HasName("PRIMARY")
                        .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                    b.HasIndex(new[] { "RolesId" }, "IDX_6D97C67538C751C4");

                    b.HasIndex(new[] { "UsersAccountsId" }, "IDX_6D97C6753BEBB01A");

                    b.ToTable("users_accounts_roles", (string)null);

                    MySqlEntityTypeBuilderExtensions.UseCollation(b, "utf8mb4_unicode_ci");
                });

            modelBuilder.Entity("University_BN.Models.Employee", b =>
                {
                    b.HasOne("University_BN.Models.UsersAccount", "Account")
                        .WithOne("Employee")
                        .HasForeignKey("University_BN.Models.Employee", "AccountId")
                        .IsRequired()
                        .HasConstraintName("FK_BA82C3009B6B5FBA");

                    b.HasOne("University_BN.Models.EmployeesAddress", "Address")
                        .WithOne("Employee")
                        .HasForeignKey("University_BN.Models.Employee", "AddressId")
                        .IsRequired()
                        .HasConstraintName("FK_BA82C300F5B7AF75");

                    b.Navigation("Account");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("University_BN.Models.Student", b =>
                {
                    b.HasOne("University_BN.Models.UsersAccount", "Account")
                        .WithOne("Student")
                        .HasForeignKey("University_BN.Models.Student", "AccountId")
                        .IsRequired()
                        .HasConstraintName("FK_A4698DB29B6B5FBA");

                    b.HasOne("University_BN.Models.StudentsAddress", "Address")
                        .WithOne("Student")
                        .HasForeignKey("University_BN.Models.Student", "AddressId")
                        .IsRequired()
                        .HasConstraintName("FK_A4698DB2F5B7AF75");

                    b.Navigation("Account");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("UsersAccountsRole", b =>
                {
                    b.HasOne("University_BN.Models.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_6D97C67538C751C4");

                    b.HasOne("University_BN.Models.UsersAccount", null)
                        .WithMany()
                        .HasForeignKey("UsersAccountsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_6D97C6753BEBB01A");
                });

            modelBuilder.Entity("University_BN.Models.EmployeesAddress", b =>
                {
                    b.Navigation("Employee");
                });

            modelBuilder.Entity("University_BN.Models.StudentsAddress", b =>
                {
                    b.Navigation("Student");
                });

            modelBuilder.Entity("University_BN.Models.UsersAccount", b =>
                {
                    b.Navigation("Employee");

                    b.Navigation("Student");
                });
#pragma warning restore 612, 618
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace University_BN.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "doctrine_migration_versions",
                columns: table => new
                {
                    version = table.Column<string>(type: "varchar(191)", maxLength: 191, nullable: false, collation: "utf8mb3_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb3"),
                    executed_at = table.Column<DateTime>(type: "datetime", nullable: true),
                    execution_time = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.version);
                })
                .Annotation("MySql:CharSet", "utf8mb3")
                .Annotation("Relational:Collation", "utf8mb3_unicode_ci");

            migrationBuilder.CreateTable(
                name: "employees_addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    country = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postal_code = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    building_number = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apartment_number = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "grades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    grade_eu = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    grade_usa = table.Column<string>(type: "varchar(2)", maxLength: 2, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    value = table.Column<decimal>(type: "decimal(3,2)", precision: 3, scale: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "students_addresses",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    country = table.Column<string>(type: "varchar(150)", maxLength: 150, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    city = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    postal_code = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    street = table.Column<string>(type: "varchar(255)", maxLength: 255, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    building_number = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    apartment_number = table.Column<string>(type: "varchar(15)", maxLength: 15, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "users_accounts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    login = table.Column<string>(type: "varchar(16)", maxLength: 16, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    email = table.Column<string>(type: "varchar(320)", maxLength: 320, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    state = table.Column<bool>(type: "tinyint(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    address_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surname = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    pesel = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK_BA82C3009B6B5FBA",
                        column: x => x.account_id,
                        principalTable: "users_accounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_BA82C300F5B7AF75",
                        column: x => x.address_id,
                        principalTable: "employees_addresses",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "students",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    address_id = table.Column<int>(type: "int", nullable: false),
                    name = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    surname = table.Column<string>(type: "varchar(55)", maxLength: 55, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    date_of_birth = table.Column<DateOnly>(type: "date", nullable: false),
                    pesel = table.Column<string>(type: "varchar(11)", maxLength: 11, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    gender = table.Column<string>(type: "varchar(21)", maxLength: 21, nullable: false, collation: "utf8mb4_unicode_ci")
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    account_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => x.id);
                    table.ForeignKey(
                        name: "FK_A4698DB29B6B5FBA",
                        column: x => x.account_id,
                        principalTable: "users_accounts",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_A4698DB2F5B7AF75",
                        column: x => x.address_id,
                        principalTable: "students_addresses",
                        principalColumn: "id");
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.CreateTable(
                name: "users_accounts_roles",
                columns: table => new
                {
                    users_accounts_id = table.Column<int>(type: "int", nullable: false),
                    roles_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PRIMARY", x => new { x.users_accounts_id, x.roles_id })
                        .Annotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                    table.ForeignKey(
                        name: "FK_6D97C67538C751C4",
                        column: x => x.roles_id,
                        principalTable: "roles",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_6D97C6753BEBB01A",
                        column: x => x.users_accounts_id,
                        principalTable: "users_accounts",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4")
                .Annotation("Relational:Collation", "utf8mb4_unicode_ci");

            migrationBuilder.InsertData(
                table: "employees_addresses",
                columns: new[] { "id", "apartment_number", "building_number", "city", "country", "postal_code", "street" },
                values: new object[,]
                {
                    { 1, "1", "1", "Warsaw", "Poland", "00-001", "Marszałkowska" },
                    { 2, "2", "2", "Krakow", "Poland", "30-001", "Floriańska" },
                    { 3, "3", "3", "Gdansk", "Poland", "80-001", "Długa" }
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "id", "name" },
                values: new object[,]
                {
                    { 1, "Administrator" },
                    { 2, "Employee" },
                    { 3, "Student" }
                });

            migrationBuilder.InsertData(
                table: "students_addresses",
                columns: new[] { "id", "apartment_number", "building_number", "city", "country", "postal_code", "street" },
                values: new object[,]
                {
                    { 1, "10", "4", "Wroclaw", "Poland", "50-001", "Oławska" },
                    { 2, "20", "5", "Poznan", "Poland", "60-001", "Półwiejska" },
                    { 3, "30", "6", "Lodz", "Poland", "90-001", "Piotrkowska" }
                });

            migrationBuilder.InsertData(
                table: "users_accounts",
                columns: new[] { "id", "email", "login", "state" },
                values: new object[,]
                {
                    { 1, "jan.nowak@example.com", "jan_nowak", true },
                    { 2, "anna.kowalska@example.com", "anna_kowalska", true },
                    { 3, "piotr.wisniewski@example.com", "piotr_wisniewski", true }
                });

            migrationBuilder.InsertData(
                table: "employees",
                columns: new[] { "id", "account_id", "address_id", "date_of_birth", "gender", "name", "pesel", "surname" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateOnly(1980, 1, 1), "Male", "Jan", "80010112345", "Nowak" },
                    { 2, 2, 2, new DateOnly(1985, 2, 2), "Female", "Anna", "85020212345", "Kowalska" },
                    { 3, 3, 3, new DateOnly(1990, 3, 3), "Male", "Piotr", "90030312345", "Wiśniewski" }
                });

            migrationBuilder.InsertData(
                table: "students",
                columns: new[] { "id", "account_id", "address_id", "date_of_birth", "gender", "name", "pesel", "surname" },
                values: new object[,]
                {
                    { 1, 1, 1, new DateOnly(2000, 1, 1), "Mężczyzna", "Jan", "00010112345", "Nowak" },
                    { 2, 2, 2, new DateOnly(2001, 2, 2), "Kobieta", "Anna", "01020212345", "Kowalska" },
                    { 3, 3, 3, new DateOnly(2002, 3, 3), "Mężczyzna", "Piotr", "02030312345", "Wiśniewski" }
                });

            migrationBuilder.CreateIndex(
                name: "UNIQ_BA82C3009B6B5FBA",
                table: "employees",
                column: "account_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UNIQ_BA82C300F5B7AF75",
                table: "employees",
                column: "address_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UNIQ_A4698DB29B6B5FBA",
                table: "students",
                column: "account_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UNIQ_A4698DB2F5B7AF75",
                table: "students",
                column: "address_id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IDX_6D97C67538C751C4",
                table: "users_accounts_roles",
                column: "roles_id");

            migrationBuilder.CreateIndex(
                name: "IDX_6D97C6753BEBB01A",
                table: "users_accounts_roles",
                column: "users_accounts_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "doctrine_migration_versions");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "grades");

            migrationBuilder.DropTable(
                name: "students");

            migrationBuilder.DropTable(
                name: "users_accounts_roles");

            migrationBuilder.DropTable(
                name: "employees_addresses");

            migrationBuilder.DropTable(
                name: "students_addresses");

            migrationBuilder.DropTable(
                name: "roles");

            migrationBuilder.DropTable(
                name: "users_accounts");
        }
    }
}

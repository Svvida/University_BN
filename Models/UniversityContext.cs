using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace University_BN.Models;

public partial class UniversityContext : DbContext
{
    public UniversityContext()
    {
    }

    public UniversityContext(DbContextOptions<UniversityContext> options)
        : base(options)
    {
    }

    public virtual DbSet<DoctrineMigrationVersion> DoctrineMigrationVersions { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeesAddress> EmployeesAddresses { get; set; }

    public virtual DbSet<Grade> Grades { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Student> Students { get; set; }

    public virtual DbSet<StudentsAddress> StudentsAddresses { get; set; }

    public virtual DbSet<UsersAccount> UsersAccounts { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=University;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("8.2.0-mysql"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_0900_ai_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<DoctrineMigrationVersion>(entity =>
        {
            entity.HasKey(e => e.Version).HasName("PRIMARY");

            entity
                .ToTable("doctrine_migration_versions")
                .HasCharSet("utf8mb3")
                .UseCollation("utf8mb3_unicode_ci");

            entity.Property(e => e.Version)
                .HasMaxLength(191)
                .HasColumnName("version");
            entity.Property(e => e.ExecutedAt)
                .HasColumnType("datetime")
                .HasColumnName("executed_at");
            entity.Property(e => e.ExecutionTime).HasColumnName("execution_time");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("employees")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.AccountId, "UNIQ_BA82C3009B6B5FBA").IsUnique();

            entity.HasIndex(e => e.AddressId, "UNIQ_BA82C300F5B7AF75").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Gender)
                .HasMaxLength(21)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(55)
                .HasColumnName("name");
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .HasColumnName("pesel");
            entity.Property(e => e.Surname)
                .HasMaxLength(55)
                .HasColumnName("surname");

            entity.HasOne(d => d.Account).WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BA82C3009B6B5FBA");

            entity.HasOne(d => d.Address).WithOne(p => p.Employee)
                .HasForeignKey<Employee>(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BA82C300F5B7AF75");
        });

        modelBuilder.Entity<EmployeesAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("employees_addresses")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentNumber)
                .HasMaxLength(15)
                .HasColumnName("apartment_number");
            entity.Property(e => e.BuildingNumber)
                .HasMaxLength(15)
                .HasColumnName("building_number");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(150)
                .HasColumnName("country");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .HasColumnName("postal_code");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .HasColumnName("street");
        });

        modelBuilder.Entity<Grade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("grades")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.GradeEu)
                .HasMaxLength(2)
                .HasColumnName("grade_eu");
            entity.Property(e => e.GradeUsa)
                .HasMaxLength(2)
                .HasColumnName("grade_usa");
            entity.Property(e => e.Value)
                .HasPrecision(3, 2)
                .HasColumnName("value");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("roles")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .HasColumnName("name");
        });

        modelBuilder.Entity<Student>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("students")
                .UseCollation("utf8mb4_unicode_ci");

            entity.HasIndex(e => e.AccountId, "UNIQ_A4698DB29B6B5FBA").IsUnique();

            entity.HasIndex(e => e.AddressId, "UNIQ_A4698DB2F5B7AF75").IsUnique();

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AccountId).HasColumnName("account_id");
            entity.Property(e => e.AddressId).HasColumnName("address_id");
            entity.Property(e => e.DateOfBirth).HasColumnName("date_of_birth");
            entity.Property(e => e.Gender)
                .HasMaxLength(21)
                .HasColumnName("gender");
            entity.Property(e => e.Name)
                .HasMaxLength(55)
                .HasColumnName("name");
            entity.Property(e => e.Pesel)
                .HasMaxLength(11)
                .HasColumnName("pesel");
            entity.Property(e => e.Surname)
                .HasMaxLength(55)
                .HasColumnName("surname");

            entity.HasOne(d => d.Account).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.AccountId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A4698DB29B6B5FBA");

            entity.HasOne(d => d.Address).WithOne(p => p.Student)
                .HasForeignKey<Student>(d => d.AddressId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_A4698DB2F5B7AF75");
        });

        modelBuilder.Entity<StudentsAddress>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("students_addresses")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ApartmentNumber)
                .HasMaxLength(15)
                .HasColumnName("apartment_number");
            entity.Property(e => e.BuildingNumber)
                .HasMaxLength(15)
                .HasColumnName("building_number");
            entity.Property(e => e.City)
                .HasMaxLength(255)
                .HasColumnName("city");
            entity.Property(e => e.Country)
                .HasMaxLength(150)
                .HasColumnName("country");
            entity.Property(e => e.PostalCode)
                .HasMaxLength(15)
                .HasColumnName("postal_code");
            entity.Property(e => e.Street)
                .HasMaxLength(255)
                .HasColumnName("street");
        });

        modelBuilder.Entity<UsersAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity
                .ToTable("users_accounts")
                .UseCollation("utf8mb4_unicode_ci");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(320)
                .HasColumnName("email");
            entity.Property(e => e.Login)
                .HasMaxLength(16)
                .HasColumnName("login");
            entity.Property(e => e.State).HasColumnName("state");

            entity.HasMany(d => d.Roles).WithMany(p => p.UsersAccounts)
                .UsingEntity<Dictionary<string, object>>(
                    "UsersAccountsRole",
                    r => r.HasOne<Role>().WithMany()
                        .HasForeignKey("RolesId")
                        .HasConstraintName("FK_6D97C67538C751C4"),
                    l => l.HasOne<UsersAccount>().WithMany()
                        .HasForeignKey("UsersAccountsId")
                        .HasConstraintName("FK_6D97C6753BEBB01A"),
                    j =>
                    {
                        j.HasKey("UsersAccountsId", "RolesId")
                            .HasName("PRIMARY")
                            .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });
                        j
                            .ToTable("users_accounts_roles")
                            .UseCollation("utf8mb4_unicode_ci");
                        j.HasIndex(new[] { "RolesId" }, "IDX_6D97C67538C751C4");
                        j.HasIndex(new[] { "UsersAccountsId" }, "IDX_6D97C6753BEBB01A");
                        j.IndexerProperty<int>("UsersAccountsId").HasColumnName("users_accounts_id");
                        j.IndexerProperty<int>("RolesId").HasColumnName("roles_id");
                    });
        });


        //Seeding data to DB
        modelBuilder.Entity<EmployeesAddress>().HasData(
    new EmployeesAddress { Id = 1, Country = "Poland", City = "Warsaw", PostalCode = "00-001", Street = "Marszałkowska", BuildingNumber = "1", ApartmentNumber = "1" },
    new EmployeesAddress { Id = 2, Country = "Poland", City = "Krakow", PostalCode = "30-001", Street = "Floriańska", BuildingNumber = "2", ApartmentNumber = "2" },
    new EmployeesAddress { Id = 3, Country = "Poland", City = "Gdansk", PostalCode = "80-001", Street = "Długa", BuildingNumber = "3", ApartmentNumber = "3" }
);
        modelBuilder.Entity<Employee>().HasData(
    new Employee { Id = 1, Name = "Jan", Surname = "Nowak", DateOfBirth = new DateOnly(1980, 1, 1), Pesel = "80010112345", Gender = "Male", AccountId = 1, AddressId = 1 },
    new Employee { Id = 2, Name = "Anna", Surname = "Kowalska", DateOfBirth = new DateOnly(1985, 2, 2), Pesel = "85020212345", Gender = "Female", AccountId = 2, AddressId = 2 },
    new Employee { Id = 3, Name = "Piotr", Surname = "Wiśniewski", DateOfBirth = new DateOnly(1990, 3, 3), Pesel = "90030312345", Gender = "Male", AccountId = 3, AddressId = 3 }
);
        modelBuilder.Entity<UsersAccount>().HasData(
    new UsersAccount { Id = 1, Login = "jan_nowak", Email = "jan.nowak@example.com", State = true },
    new UsersAccount { Id = 2, Login = "anna_kowalska", Email = "anna.kowalska@example.com", State = true },
    new UsersAccount { Id = 3, Login = "piotr_wisniewski", Email = "piotr.wisniewski@example.com", State = true }
);
        modelBuilder.Entity<Role>().HasData(
    new Role { Id = 1, Name = "Administrator" },
    new Role { Id = 2, Name = "Employee" },
    new Role { Id = 3, Name = "Student" }
);
        modelBuilder.Entity<StudentsAddress>().HasData(
    new StudentsAddress { Id = 1, Country = "Poland", City = "Wroclaw", PostalCode = "50-001", Street = "Oławska", BuildingNumber = "4", ApartmentNumber = "10" },
    new StudentsAddress { Id = 2, Country = "Poland", City = "Poznan", PostalCode = "60-001", Street = "Półwiejska", BuildingNumber = "5", ApartmentNumber = "20" },
    new StudentsAddress { Id = 3, Country = "Poland", City = "Lodz", PostalCode = "90-001", Street = "Piotrkowska", BuildingNumber = "6", ApartmentNumber = "30" }
);
        modelBuilder.Entity<Student>().HasData(
    new Student { Id = 1, AddressId = 1, Name = "Jan", Surname = "Nowak", DateOfBirth = DateOnly.Parse("2000-01-01"), Pesel = "00010112345", Gender = "Mężczyzna", AccountId = 1 },
    new Student { Id = 2, AddressId = 2, Name = "Anna", Surname = "Kowalska", DateOfBirth = DateOnly.Parse("2001-02-02"), Pesel = "01020212345", Gender = "Kobieta", AccountId = 2 },
    new Student { Id = 3, AddressId = 3, Name = "Piotr", Surname = "Wiśniewski", DateOfBirth = DateOnly.Parse("2002-03-03"), Pesel = "02030312345", Gender = "Mężczyzna", AccountId = 3 }
);






        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

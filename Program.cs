using Microsoft.EntityFrameworkCore;
using University_BN.Models;

var builder = WebApplication.CreateBuilder(args);

//Add YourDbContext to allow communication between application and DB
builder.Services.AddDbContext<UniversityContext>(options=>
options.UseMySql(builder.Configuration.GetConnectionString("DefaultConnection"),
ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))));


// CORS configuration to allow testing with Swagger
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(builder =>
    {
        builder.WithOrigins("http://localhost:5000", "https://localhost:5001", "https://localhost:7116")
               .AllowAnyHeader()
               .AllowAnyMethod();
    });
});

//Add services to the container
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// USE IT BEFORE app.UseRouting();
var app = builder.Build();

app.UseCors();

// Enable middleware to serve generated Swagger as a JSON endpoint.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    // Enable middleware to serve swagger-ui (HTML, JS, CSS, etc.),
    // specifying the Swagger JSON endpoint.
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1"));

    // Redirect root to Swagger UI
    app.MapGet("/", () => Results.Redirect("/swagger"));
}

app.MapGet("/students", async (UniversityContext context) =>
{
    var studentDTOs = await context.Students
    .Select(s => new StudentDTO
    {
        Name =s.Name,
        Surname = s.Surname,
        DateOfBirth = s.DateOfBirth,
        Gender = s.Gender
    })
    .ToListAsync();
    return Results.Ok(studentDTOs);
});

app.MapPost("/students", async (UniversityContext context, StudentRegistrationModel registrationModel) =>
{
    using var transaction = await context.Database.BeginTransactionAsync();
    try
    {
        var birthDate = DateOnly.ParseExact(registrationModel.BirthDate, "yyyy-MM-dd");

        var address = new StudentsAddress
        {
            Country = registrationModel.Country,
            City = registrationModel.City,
            PostalCode = registrationModel.PostalCode,
            Street = registrationModel.Street,
            BuildingNumber = registrationModel.BuildingNumber,
            ApartmentNumber = registrationModel.ApartmentNumber
        };
        context.StudentsAddresses.Add(address);
        await context.SaveChangesAsync();

        var student = new Student
        {
            Name = registrationModel.Name,
            Surname = registrationModel.Surname,
            DateOfBirth = birthDate,
            Gender = registrationModel.Gender,
            Pesel = registrationModel.Pesel,
            AddressId = address.Id,
        };
        context.Students.Add(student);
        await context.SaveChangesAsync();

        await transaction.CommitAsync();

        var studentDto = new StudentDTO
        {
            Name = student.Name,
            Surname = student.Surname,
            DateOfBirth = birthDate,
            Gender = registrationModel.Gender,
        };

        return Results.Ok(studentDto);
    }
    catch (Exception ex)
    {
        await transaction.RollbackAsync();
        return Results.Problem(detail: ex.Message, statusCode: 500);
    }
});


app.Run();


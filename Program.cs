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
    .Select(s => new StudentDTO(s.Name, s.Surname, s.DateOfBirth, s.Gender))
    .ToListAsync();
    return Results.Ok(studentDTOs);
});


app.Run();


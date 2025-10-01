using InvoiceAPI.Data;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// ---- DATABASE CONFIG ----
// Use InMemory during Development so Swagger/UI launches without a real SQL server.
// In non-Development (e.g., Production) it falls back to the configured SQL Server.
if (builder.Environment.IsDevelopment())
{
    builder.Services.AddDbContext<InvoiceDbContext>(options =>
        options.UseInMemoryDatabase("FakeDb"));
}
else
{
    builder.Services.AddDbContext<InvoiceDbContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
}

// Add services to the container.
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Always allow Swagger in Development so you can inspect endpoints.
// If you want Swagger visible in Production too, remove the IsDevelopment() check.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using WebApiDemo2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebApiDemo2.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<ApplicationDbContext>(Options => 
Options.UseSqlServer(builder.Configuration.GetSection("ConnectionStrings.DefaultConnection").Value));

builder.Services.AddScoped<IProductRepository, ProductRepository>(); 
builder.Services.AddScoped<IProductServices, ProductServices>();
builder.Services.AddSwaggerGen(c=>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApiDemo2", Version = "v1" });
});


builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();

app.UseSwaggerUI(c=>c.SwaggerEndpoint("/swagger/v1/swagger.json","WebApiDemo2 v1"));

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

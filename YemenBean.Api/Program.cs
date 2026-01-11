using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using YemenBean.Core.Features.Products.Queries.Handlers;
using YemenBean.Infrastructure.Context;
using YemenBean.Infrastructure.Repositories;
using YemenBean.Service.Abstracts;
using YemenBean.Service.Implementations;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();



/// =======================
/// 1️⃣ Services
/// =======================
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddSwaggerGen();

/// =======================
/// 2️⃣ Database
/// =======================
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
/// =======================
/// 3️⃣ Dependency Injection
/// =======================
builder.Services.AddMediatR(cfg =>
    cfg.RegisterServicesFromAssembly(typeof(GetAllProductsHandler).Assembly));

builder.Services.AddScoped<IProductService, ProductService>();
builder.Services.AddScoped<ProductRepository>();

/// =======================
/// 4️⃣ CORS
/// =======================
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", policy =>
        policy.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

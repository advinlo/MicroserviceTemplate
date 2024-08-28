using MediatR;
using Microsoft.OpenApi.Models;
using Microsoft.EntityFrameworkCore;
using MicroserviceTemplate.Application;
using System.Reflection;
using MicroserviceTemplate.API;
using MicroserviceTemplate.Application.Mappper;
using MicroserviceTemplate.Infrastructure;


var builder = WebApplication.CreateBuilder(args);
var Configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false)
    .Build();

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(options => options.UseSqlServer());
ServiceRegistration.Register(builder.Services);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Microservice Template API", Version = "v1" });    
});

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetUserByIdHandler).Assembly));
var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger(options =>
    {
        options.RouteTemplate = "/microservicetemplate/api/swagger/{documentname}/swagger.json";
    }
    );
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("v1/swagger.json", "Microservice Template API V1");
        options.RoutePrefix = "microservicetemplate/api/swagger";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

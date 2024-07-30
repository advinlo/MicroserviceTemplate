using MediatR;
using Microsoft.OpenApi.Models;
using MicroserviceTemplate.Application.UseCase;
using System.Configuration;
using System.Reflection;
using MicroserviceTemplate.API;
using MicroserviceTemplate.Application.Mappper;
using AutoMapper;


var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
ServiceRegistration.Register(builder.Services);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo { Title = "Microservice Template API", Version = "v1" });    
});

builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);

builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetUserByIdUseCase).Assembly));
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

using Application.Command.Usuario.AddUsuario;
using IoC;
using MediatR;
using Microsoft.OpenApi.Models;
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
RegisterServices();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "API Mediator"
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();

void RegisterServices()
{
    builder.Services.AddMediatR(typeof(AddUsuarioCommand));

    builder.Services.InjectServices(builder.Configuration.GetConnectionString("ConnectionString"));
}
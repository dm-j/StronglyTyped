using Microsoft.EntityFrameworkCore;
using StrictlyTyped.EntityFramework;
using System.Reflection;
using TodoApi.Models;
using StrictlyTyped.Swagger;
using Microsoft.Extensions.Options;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<TodoContext>(opt =>
{
    //opt.UseInMemoryDatabase("TodoList");
    opt.AddStrictTypeConverters();
});
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.UseStrictTypesDefinedIn(Assembly.GetExecutingAssembly());
    c.EnableAnnotations();
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

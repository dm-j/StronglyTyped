using Example.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using StrictlyTyped;
using StrictlyTyped.EntityFramework;
using System.Reflection.Emit;

namespace TodoApi.Models;

public class TodoContext : DbContext
{
    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        //configurationBuilder
        //    .DefaultTypeMapping<IStrictType<,>>()

    }

    public DbSet<TodoItem> TodoItems { get; set; } = null!;
}
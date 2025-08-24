using TechnologyPracticeTestWeb.Middlewares;
using TechnologyPracticeTestWeb.Services.StringModifierService.Implementations;
using TechnologyPracticeTestWeb.Services.StringModifierService.Interfaces;

namespace TechnologyPracticeTestWeb;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddSingleton<IStringModifierService, BaseStringModifierService>();

        var concurrencyLimit = builder.Configuration.GetValue("ConcurrencyLimit:MaxConcurrentRequests", 100);

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseMiddleware<ConcurrencyLimitMiddleware>(concurrencyLimit);

        app.MapControllers();

        app.Run();
    }
}
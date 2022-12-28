using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.AddConsole();
builder.Logging.AddDebug();

builder.Configuration.AddJsonFile($"ocelot.{builder.Environment.EnvironmentName}.json", 
                                    optional: true, 
                                    reloadOnChange: true);
builder.Services.AddOcelot();

// Add services to the container.

var app = builder.Build();

// Configure the HTTP request pipeline.
app.Run();

await app.UseOcelot();
var builder = WebApplication.CreateBuilder(args).WebHost.ConfigureLogging((hostingContext, loggingBuilder) =>
{
    loggingBuilder.AddConfiguration(hostingContext.Configuration.GetSection("Logging"));
    loggingBuilder.AddConsole();
    loggingBuilder.AddDebug();
});
var app = builder.Build();

app.Run();

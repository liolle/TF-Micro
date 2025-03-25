using DotNetEnv;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Add Env &  Json configuration
Env.Load();
builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddSingleton<IConfiguration>(builder.Configuration);

// Add Ocelot with configuration file
builder.Services.AddOcelot();

var app = builder.Build();

app.UseHttpsRedirection();
//app.UseAuthorization();
await app.UseOcelot();
app.Run();

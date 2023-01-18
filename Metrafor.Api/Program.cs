using Metrafor.Api.Hubs;
using Metrafor.Infrastructure;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;
var postgresConnectionString = configuration.GetConnectionString("postgres");
Debug.Assert(postgresConnectionString != null);

builder.Services.AddCors(options => options.AddPolicy("CorsPolicy",
        builder =>
        {
            builder.AllowAnyHeader()
                   .AllowAnyMethod()
                   .SetIsOriginAllowed((host) => true)
                   .AllowCredentials();
        }));

builder.Services.AddContext(postgresConnectionString);

builder.Services.AddSignalR();

var app = builder.Build();

app.UseCors("CorsPolicy");
app.MapHub<IdentityHub>("/identity");

app.Run();

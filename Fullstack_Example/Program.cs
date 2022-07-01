using Fullstack_Example.Architecture.Application;
using Fullstack_Example.Architecture.Infrastructure;
using Fullstack_Example.Configurations;

var builder = WebApplication.CreateBuilder(args);

builder.Services.UseApplicationServices();
builder.Services.UseInfrastructureServices(builder.Configuration);
builder.Services.UseCommonServices(builder.Configuration);

var app = builder.Build();
app.UseCommonPiplines();
app.Run();
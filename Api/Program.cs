using Api;
using Application;
using Infrastructure;
using Microsoft.AspNetCore.Http.Json;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCors();
builder.Services.AddCarter();
builder.Services.AddApi();
builder.Services.AddApplication();
builder.Services.AddInfrastructure();
builder.Services.Configure<JsonOptions>(options =>
{
    options.SerializerOptions.PropertyNamingPolicy = null;
});

var app = builder.Build();
app.UseGlobalExceptionHandler();
app.UseWebCors();
app.MapCarter();
app.Run();
using Contracts;
using Google.Apis.Compute.v1.Data;
using HealthChecks.MySql;
using HealthChecks.SqlServer;
using LoggerService;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Diagnostics.HealthChecks;
using NLog;
using PurchasePointCalcAPI.Extensions;
using PurchasePointCalcAPI.Services;
using Repository;

var builder = WebApplication.CreateBuilder(args);

LogManager.LoadConfiguration(string.Concat(Directory.GetCurrentDirectory(), "/nlog.config"));

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddAuthentication()
    .AddScheme<AuthenticationSchemeOptions, ApiKeyAuthenticationHandler>(
            "ApiKey",options => { });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.ConfigureLoggerService();
builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

//Registering the ApplicationContext class.
//The actual implementation has been done in the ServiceExtension.cs class just to demonstrate that this way the Program.cs class can be simplified.
builder.Services.ConfigureMySqlContext(builder.Configuration);
builder.Services.AddAutoMapper(typeof(Program));   

//Adding MySql db connection as part of the application health check.
builder.Services.AddHealthChecks()
    .AddMySql(
        connectionString: builder.Configuration["mysqlconnection:connectionString"],
        name: "Database",
        failureStatus: Microsoft.Extensions.Diagnostics.HealthChecks.HealthStatus.Degraded);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
    app.UseHsts();

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseForwardedHeaders(new ForwardedHeadersOptions
{ 
    ForwardedHeaders = ForwardedHeaders.All
});
app.UseCors("CorsPolicy");
app.UseAuthorization();
app.MapControllers();

//Adding endpoint for application health check.
app.MapHealthChecks("/health");
app.Run();

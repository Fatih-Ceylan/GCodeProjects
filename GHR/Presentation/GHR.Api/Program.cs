
using BaseProject.Application;
using BaseProject.Infrastructure;
using BaseProject.Persistence;
using GHR.Application;
using GHR.Infrastructure;
using GHR.Persistence;
using Serilog;
using Utilities.Infrastructure.UtilityInfrastructure;
using Utilities.Infrastructure.UtilityInfrastructure.Services.Storage.Local;
using Utilities.Presentation.UtilityApi.Middleware;

var builder = WebApplication.CreateBuilder(args);
var logger = SerilogExtension.CreateLogger(builder.Configuration);
builder.Host.UseSerilog(logger);
builder.Services.AddBaseProjectApplicationServices();
builder.Services.AddBaseProjectInfrastructureServices();
builder.Services.AddBaseProjectPersistenceServices();
builder.Services.AddGHRApplicationServices();
builder.Services.AddGHRInfrastructureServices();
builder.Services.AddGHRPersistenceServices();
builder.Services.AddUtilityInfrastructureServices();
builder.Services.AddStroage<LocalStorage>();
builder.Services.AddEndpointsApiExplorer();
//swagger için
builder.Services.AddSwaggerGen();
builder.Services.ConfigureSwaggerCustom();
builder.Services.AddCustomJwtAuthentication(builder.Configuration);
//routing config
builder.Services.AddRouting(options => options.LowercaseUrls = true);
//redis config
builder.Services.AddRedisCache(builder.Configuration);
//redis olmadan cache config
builder.Services.AddDistributedMemoryCache();
builder.Services.AddControllers();
// ESextension için
//builder.Services.AddElasticSearch(builder.Configuration);

var corsUrls = builder.Configuration.GetSection("CorsPolicy:Urls").Get<string[]>();
builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        builder =>
        {
            builder.WithOrigins(corsUrls)
                     .AllowAnyHeader()
                     .AllowAnyMethod()
                     .AllowCredentials();
        });
});

var app = builder.Build();

var environment = builder.Environment.EnvironmentName;
var basedbName = builder.Configuration.GetSection("ConnectionStrings:BaseProjectDatabase");
if (app.Environment.IsDevelopment() || app.Environment.IsStaging())
{

    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{basedbName.Value}_GHR Local API");
    });
}

app.UseSwagger();
app.UseSwaggerUI(c =>
{
    c.SwaggerEndpoint("/swagger/v1/swagger.json", $"{basedbName.Value}_GHR API");
    c.RoutePrefix = string.Empty;
});

app.UseSerilogRequestLogging();

app.UseCors();

app.UseDeveloperExceptionPage();
app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();

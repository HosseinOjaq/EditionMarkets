using Common;
using System.Reflection;
using WebFramework.Cors;
using WebFramework.Swagger;
using WebFramework.Middlewares;
using WebFramework.CustomMapping;
using WebFramework.Configuration;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

IConfiguration configuration = builder.Configuration;
var siteSettingsSection = configuration.GetSection(nameof(SiteSettings));
builder.Services.Configure<SiteSettings>(siteSettingsSection);

var siteSettings = siteSettingsSection.Get<SiteSettings>();
builder.Services.InitializeAutoMapper();
builder.Services.AddDbContext(configuration);

builder.Services.AddCustomIdentity(siteSettings.IdentitySettings);

builder.Services.AddElmahCore(configuration, siteSettings);

builder.Services.AddJwtAuthentication(siteSettings.JwtSettings);

builder.Services.AddCustomApiVersioning();
builder.Services.AddMvc(x => x.EnableEndpointRouting = false);
var projectName = Assembly.GetEntryAssembly().GetName().Name;
builder.Services.AddSwagger(projectName);
builder.Services.AddCustomeWebCors();

var app = builder.Build();
app.UseSwaggerAndUI();

app.IntializeDatabase();
app.UseCustomExceptionHandler();
app.UseHsts(app.Environment);
app.UseHttpsRedirection();
app.UseElmahCore(siteSettings);
app.UseRouting();
app.UseMvc();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.MapControllers();

app.Run();
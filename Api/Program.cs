using Common;
using WebFramework.CustomMapping;
using WebFramework.Configuration;
using System.Reflection;
using WebFramework.Cors;
using WebFramework.Swagger;

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

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
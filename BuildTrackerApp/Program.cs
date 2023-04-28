using BuildTrackerApp.Data;
using BuildTrackerApp.Data.Repositories.DataImplimentation;
using BuildTrackerApp.Data.Repositories.DataInterface;
using BuildTrackerApp.Services.ServiceData;
using BuildTrackerApp.Services.ServicesRepositories.ServiceImplimentation;
using BuildTrackerApp.Services.ServicesRepositories.ServicesInterface;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<BuildAppContext>(option =>
{
 option.UseSqlServer(builder.Configuration.GetConnectionString("BuildTrackerConnection"));
});

// REPOSITORY
builder.Services.AddScoped<ITeamRepository, TeamRepository>();
builder.Services.AddScoped<IBlockerRepository, BlockerRepository>();
builder.Services.AddScoped<IBuildRepository, BuildRepository>();
builder.Services.AddScoped<IProjectRepository, ProjectRepository>();

// SERVICES
builder.Services.AddScoped<ITeamServices, TeamServices>();
builder.Services.AddScoped<IBlockerServices, BlockerServices>();
builder.Services.AddScoped<IBuildServices, BuildServices>();
builder.Services.AddScoped<IServiceDataFetch, ServiceDataFetch>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

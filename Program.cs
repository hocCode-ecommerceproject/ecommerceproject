using Microsoft.EntityFrameworkCore;
using ecommerceproject.DbContexts;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllersWithViews();

var app = builder.Build();

// Set dbPath to DEV when in development mode (see launchSettings.json) else set PROD
var dbPath = builder.Environment.IsDevelopment() ? builder.Configuration["ConnectionStrings:DEV"] : builder.Configuration["ConnectionStrings:PROD"];

builder.Services.AddDbContext<DataContext>(opts => opts.UseSqlite($"Data Source=./Database/dev.db"));

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
	app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.MapControllerRoute(
	name: "default",
	pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");

app.Run();

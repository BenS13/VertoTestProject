using Microsoft.EntityFrameworkCore;
using VertoTestProject.Data;
using VertoTestProject.Services;
using VertoTestProject.Models;

var builder = WebApplication.CreateBuilder(args);

//Add services to the app container
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ContentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContentContext") ?? throw new InvalidOperationException("Connection string 'ContentContext' not found.")));

//Register the ContentService so it can be injected into any page
builder.Services.AddScoped<ContentService>();

var app = builder.Build();

//Run the seeding for the database on app startup
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);//Seed the database with data
}

//Allow css files to be applied
app.UseStaticFiles();

//Routes automatically get routed
app.UseRouting();

//Set up the default route
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}"
);


app.Run();

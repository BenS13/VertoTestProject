using Microsoft.EntityFrameworkCore;
using VertoTestProject.Data;

var builder = WebApplication.CreateBuilder(args);

//Add services to the app container
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ContentContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContentContext") ?? throw new InvalidOperationException("Connection string 'ContentContext' not found.")));

var app = builder.Build();



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

var builder = WebApplication.CreateBuilder(args);

//Add services to the app container
builder.Services.AddControllersWithViews();

var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

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

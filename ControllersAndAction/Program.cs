var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

app.MapControllerRoute(
    name: "Default",
    pattern: "{Controller=Home}/{action=Index}/{id?}"
    );

app.Run();

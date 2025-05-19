var builder = WebApplication.CreateBuilder(args);

// Leer URL base desde appsettings
var apiBaseUrl = builder.Configuration["ApiSettings:BaseUrl"];

// Registrar el HttpClient nombrado
builder.Services.AddHttpClient("AlquilappApi", client =>
{
    client.BaseAddress = new Uri(apiBaseUrl!);
});

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

using BlazingPizza.Data;
using BlazingPizza.Model;
using BlazingPizza.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add services to the container.
builder.Services.AddHttpClient();
builder.Services.AddSqlite<PizzaStoreContext>("Data Source=pizza.db");
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
// Register the pizzas service
builder.Services.AddScoped<OrderState>();
builder.Services.AddScoped<PizzaSalesState>();
builder.Services.AddSingleton<PizzaService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();
app.UseRouting();

app.MapRazorPages();
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");

// Inicializa o banco
var scopeFactory = app.Services.GetRequiredService<IServiceScopeFactory>();
using (var scope = scopeFactory.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<PizzaStoreContext>();
    if (db.Database.EnsureCreated())
    {
        SeedData.Initialize(db);
    }
}

app.Run();
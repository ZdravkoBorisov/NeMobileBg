using Microsoft.EntityFrameworkCore;
using NeMobileBg.Data;
using NeMobileBg.Data.Models;
using NeMobileBg.Data.Repository;
using NeMobileBg.Services;
using NeMobileBg.Services.Cars;
using NeMobileBg.Services.Contracts;
using NeMobileBg.Services.Motorcycles;
using NeMobileBg.Services.Trucks;
using NeMobileBg.Services.Tyres;
using NeMobileBg.Services.Users;

var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped<ICarsService, CarsService>();
builder.Services.AddScoped<ITrucksService, TrucksService>();
builder.Services.AddScoped<IMotorcycleService, MotorcyclesService>();
builder.Services.AddScoped<ITyresService, TyresService>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IHomePageService, HomePageService>();

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 2;
    options.Password.RequireLowercase = false;

}).AddEntityFrameworkStores<ApplicationDbContext>();

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

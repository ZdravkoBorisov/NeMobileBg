var builder = WebApplication.CreateBuilder(args);
builder.Logging.ClearProviders();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddScoped<ICarsService, CarsService>();
builder.Services.AddScoped<IMotorcycleService, MotorcyclesService>();
builder.Services.AddScoped<ITyresService, TyresService>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IUsersService, UsersService>();
builder.Services.AddScoped<IAdminService, AdminService>();
builder.Services.AddScoped<IAlertsService, AlertsService>();
builder.Services.AddScoped<IRepository, Repository>();
builder.Services.AddScoped<IHomePageService, HomePageService>();

builder.Services.AddCors(o => o.AddDefaultPolicy(builder =>
{
    builder.AllowAnyOrigin()
           .AllowAnyMethod()
           .AllowAnyHeader();
}));

builder.Services.AddDefaultIdentity<ApplicationUser>(options =>
{
    options.SignIn.RequireConfirmedAccount = false;
    options.Password.RequireDigit = false;
    options.Password.RequireLowercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
    options.Password.RequiredLength = 2;
    options.Password.RequireLowercase = false;

}).AddRoles<IdentityRole<string>>()
.AddEntityFrameworkStores<ApplicationDbContext>();

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

app.UseEndpoints(config =>
{
    config.MapControllerRoute(
          name: "areas",
          pattern: "/{area:exists}/{controller=Home}/{action=Index}/{id?}");

    config.MapControllerRoute(
        name: "default",
        pattern: "/{controller=Home}/{action=Index}/{id?}");
});
app.MapRazorPages();

app.Run();

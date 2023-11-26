using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DNMOFT.CostTrackr.Web.Data;
using DNMOFT.CostTrackr.Web.Data.Entities.Identity;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("connectionstrings.json", optional: false, reloadOnChange: true);

// Add services to the container.
var connectionString =

#if POSTGREDEBUG || POSTGRERELEASE
builder.Configuration.GetConnectionString("PostgreConnection") ?? 
                        throw new InvalidOperationException("Connection string 'PostgreConnection' not found.");
                        
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));
#endif
#if DEBUG || RELEASE
builder.Configuration.GetConnectionString("SqlServerConnection") ??
                        throw new InvalidOperationException("Connection string 'SqlServer' not found.");

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(connectionString));
#endif

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddIdentity<mUser, mRole>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultUI()
    .AddDefaultTokenProviders();

builder.Services.AddControllersWithViews();

// Authentications
builder.Services.AddAuthentication()
    .AddMicrosoftAccount(msOptions =>
    {
        msOptions.ClientId = builder.Configuration["Authentication:Microsoft:ClientId"];
        msOptions.ClientSecret = builder.Configuration["Authentication:Microsoft:ClientSecret"];
        msOptions.CallbackPath = "/Home/Index";

    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapRazorPages();

app.Run();

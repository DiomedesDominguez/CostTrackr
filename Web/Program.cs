using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using DNMOFT.CostTrackr.Web.Data;
using DNMOFT.CostTrackr.Web.Data.Entities.Identity;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.MicrosoftAccount;
using Microsoft.AspNetCore.Authentication.AzureAD.UI;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;

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
builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = MicrosoftAccountDefaults.AuthenticationScheme;
}).AddCookie()
    .AddMicrosoftAccount(msOptions =>
    {
        msOptions.ClientId = builder.Configuration["Authentication:AzureAd:ClientId"];
        msOptions.ClientSecret = builder.Configuration["Authentication:AzureAd:ClientSecret"];
        msOptions.SaveTokens = true;
    });

builder.Services.AddLogging(o =>
{
    o.AddFilter("Microsoft", LogLevel.Debug)
           .AddFilter("System", LogLevel.Debug)
           .AddFilter("YourAppName", LogLevel.Debug)
           .AddConsole();
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

using Microsoft.EntityFrameworkCore;
using ProjektSklepTI.DAL;
using ProjektSklepTI.Models.Users;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();builder.Services.AddDbContext<FilmsContext>(options=>options.UseSqlServer(builder.Configuration.GetConnectionString("localDB")));
builder.Services.AddDbContext<IdentityAppContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));

builder.Services.AddSession();

builder.Services.AddIdentity<AppUser, AppRole>(options =>
{
    options.User.RequireUniqueEmail = true;

    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireDigit = false;
    options.Password.RequiredLength = 4;
}).AddEntityFrameworkStores<IdentityAppContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.UseSession();
app.MapControllerRoute(
    name: "Details",
    pattern: "{action}/{filmId}",
    defaults: new { controller = "Films", action = "Details" }
    );


app.MapControllerRoute(
    name: "StaticSites",
    pattern: "Info/{siteName}",
    defaults: new { controller = "Home", action = "FooterSites" }
    );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Categories",
    pattern: "{categoryName}",
    defaults: new { controller = "Films", action = "ProductList" }
    );
app.Run();

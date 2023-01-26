using System.Security.Policy;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using WebApplication6.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<MyBlogContext>(optionsBuilder =>
    optionsBuilder.UseSqlServer(builder.Configuration.GetConnectionString("default")));

builder.Services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<MyBlogContext>()
    .AddDefaultTokenProviders();
// builder.Services.AddDefaultIdentity<AppUser>().AddEntityFrameworkStores<MyBlogContext>()
//     .AddDefaultTokenProviders();
builder.Services.Configure<IdentityOptions>(opt =>
{
    opt.Password.RequireDigit = false;
    opt.Password.RequiredLength = 3;
    opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
    opt.SignIn.RequireConfirmedEmail = true;
});
builder.Services.AddOptions();
builder.Services.Configure<MailSettings>(builder.Configuration.GetSection("MailSettings"));
builder.Services.AddSingleton<IEmailSender, SendMailService>();

// Configure the HTTP request pipeline.
var app = builder.Build();
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();
app.UseAuthentication();

app.MapRazorPages();

app.Run();
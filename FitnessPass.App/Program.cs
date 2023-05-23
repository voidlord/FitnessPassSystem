using FitnessPass.App.Auth;
using FitnessPass.App.Mail;
using FitnessPass.DB;
using FitnessPass.DB.CompiledModels;
using FitnessPass.Service;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace FitnessPassApp
{
    public class Program {
        public static void Main(string[] args) {

            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddScoped<ClientService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<PassTypeService>();
            builder.Services.AddScoped<GymService>();

            builder.Services.AddScoped<ProtectedSessionStorage>();
            builder.Services.AddScoped<ClaimsPrincipal>();
            builder.Services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            builder.Services.AddSingleton(builder.Configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>());
            builder.Services.AddScoped<EmailService>();

            var connectionString = builder.Configuration.GetConnectionString("url");

            builder.Services.AddDbContext<AppDbContext>(options => {
                options.UseModel(AppDbContextModel.Instance)
                       .UseSqlServer(connectionString);
            });

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}

using FinanceApp.Data;
using Microsoft.EntityFrameworkCore;

namespace FinanceApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            //server to connect context to database
            builder.Services.AddDbContext<FinanceAppContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
            //add migration to db


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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                //routing , id to access specific page
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

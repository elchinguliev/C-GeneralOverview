using DependecjInjectionGencayYildiz.Services;
using DependecjInjectionGencayYildiz.Services.Interface;
using System.Runtime.InteropServices;

namespace DependecjInjectionGencayYildiz
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            ////builder.Services.AddSingleton<ConsoleLog>(); //parametr qebul etmirse isleyecek pramaetr qebul etse duzgun islemeyecek
            //builder.Services.AddSingleton<ConsoleLog>(p => new ConsoleLog(5)); //parametr qebul etse bele olacaq
            //builder.Services.AddScoped<ILog>(p=>new TestLog()); Lakin bunu qisa formada asagidaki kimi yaziriq
            builder.Services.AddScoped<ILog,TestLog>();
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
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}

using Microsoft.EntityFrameworkCore;
using SenaiApi.Repository.Repositorios;
using SenaiApp.Repository.Contexts;
using SenaiApp.Repository.Interfaces;
using Service.Interface;
using Service.Service;
using System;

namespace SenaiApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();

            #region Injeção de Dependência

            //builder.Services.AddScoped<IPessoaService, PessoaService>();
            //builder.Services.AddScoped<IPessoaRepository, PessoaRepositorio>();
            // builder.Services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            builder.Services.AddScoped<IClienteService, ClienteService>();
            builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

            builder.Services.AddDbContext<SenaiAppContext>(options =>
                options.UseNpgsql(builder.Configuration.GetValue<string>("ConnectionStrings:SenaiApp")));
            #endregion


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("Home/Error");
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
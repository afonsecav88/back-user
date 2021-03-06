using System.ComponentModel.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using ListaTareas.Models;
using ListaTareas.Interfaces;
using ListaTareas.Services;
using AutoMapper;
using ListaTareas.Profiles;

namespace ListaTareas
{
    public class Startup
    {
      
        public Startup(IConfiguration configuration) 
        {
            this.Configuration = configuration;
               
        }
                public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //permitiendo acceso desde el frontend
            services.AddCors();

            services.AddControllers();

            //Configurado el contexto a la base de datos sql 
            services.AddDbContext<ListaTareasContext>(options=>
            options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            //Declarando la Inyecci�n de Dependencias
            services.AddScoped<ITareas,CTareas>();

            //Declarando el uso de automapper

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddAutoMapper(typeof(TareasProfile));

          
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            //permitiendo acceso desde el frontend
            app.UseCors(x => x
            .AllowAnyMethod()
            .AllowAnyOrigin()
            .AllowAnyHeader());

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}

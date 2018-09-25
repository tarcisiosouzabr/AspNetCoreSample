﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using WebApi.DAL;
using WebApi.DAL.Infra;
using Microsoft.EntityFrameworkCore;
using WebApi.BLL.Infra;
using WebApi.BLL;
using WebApi.UoWs;
using WebApi.DAL.Infra.Repositories;
using WebApi.DAL.Repositories;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<IWebApiDbContext, WebApiDbContext>(
                x => x.UseSqlServer(Configuration.GetConnectionString("WebApiDbContext")
                ));
            services.AddMvc();

            #region BLL's
            services.AddScoped<IPersonBLL, PersonBLL>();
            services.AddScoped<IAnimalBLL, AnimalBLL>();
            #endregion
            #region Repositories
            services.AddScoped<IAnimalRepository, AnimalRepository>();
            services.AddScoped<IPersonRepository, PersonRepository>(); 
            #endregion
            #region UoW's
            services.AddScoped<AnimalUoW, AnimalUoW>(); 
            services.AddScoped<PersonUoW, PersonUoW>();
            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseMvc();
        }
    }
}

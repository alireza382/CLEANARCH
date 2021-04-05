using ClaenArch.Application.Interfaces;
using ClaenArch.Application.Services;
using CleanArc.Data.Repository;
using CleanArch.Domain.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IOC
{
     public  class DependencyContainer
    {
        public static void registerServices(IServiceCollection services)
        {

            ////Application layer
            services.AddScoped<ICourseService, CourseService>();


            ///Infra.data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();

        }
        
    }
}

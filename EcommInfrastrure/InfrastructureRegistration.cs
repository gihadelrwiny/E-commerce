using EcommCore.interfaces;
using EcommInfrastrure.Data;
using EcommInfrastrure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommInfrastrure
{
   public static class InfrastructureRegistration
    {
        //انا هنا بضيف الفانكشن ده ل service 
        public static IServiceCollection infrastructureConfiguration(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddScoped(typeof(IgenericRepository<>), typeof(GenericRepository<>));
            //services.AddScoped<IcatogeryRepository, CategoryRepository>();
            //services.AddScoped<IproductRepository, ProductRepository>();
            //services.AddScoped<IphotoRepository, photoRepository>();
            //ملهمش لازمة دلوقت عشان استخدمت unitofwork وعرفتهم هناك
            services.AddScoped<IunitOfWork, UnitOfWork>();
            services.AddDbContext<AppDbContext>(o =>
            {
                o.UseSqlServer(configuration.GetConnectionString("Ecom"));

            }
            );

            return services;
        }
    }
}

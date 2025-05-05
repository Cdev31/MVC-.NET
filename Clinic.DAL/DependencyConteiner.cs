using Microsoft.EntityFrameworkCore;
using mvc_practice.Clinic.DAL.Interfaces;
using mvc_practice.Db;
using mvc_practice.Interfaces;
using mvc_practice.Services;

namespace mvc_practice.Clinic.DAL
{
    public static class DependencyConteiner
    {
        public static IServiceCollection AddDALDependencies( this IServiceCollection service, IConfiguration config ){
            
            service.AddDbContext<ContextDB>( options => options.UseSqlServer( config.GetConnectionString("conn")));

            service.AddScoped<IUserDAL, UserDAL>();
            service.AddScoped<IUnitOfWork, UnitOfWork>();

            return service;
        }
    }
}
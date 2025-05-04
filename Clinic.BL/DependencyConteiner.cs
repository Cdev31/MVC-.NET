using mvc_practice.Clinic.BL.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace mvc_practice.Clinic.BL
{
    public static class DependencyConteiner
    {
        public static IServiceCollection AddBLDependencies( this IServiceCollection services){
            services.AddTransient<IUserBL,UserBL>();
            return services;
        }
    }
}
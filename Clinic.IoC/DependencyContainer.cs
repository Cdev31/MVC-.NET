
using mvc_practice.Clinic.BL;
using mvc_practice.Clinic.DAL;

namespace mvc_practice.Clinic.IoC
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddClinicDependencies( this IServiceCollection service, IConfiguration config ){

            service.AddDALDependencies( config );
            service.AddBLDependencies();

            return service;
        }
    }
}
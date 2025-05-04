using mvc_practice.Models;
using mvc_practice.Schemas;

namespace mvc_practice.Clinic.BL.Interfaces
{
    public interface IDoctorBL
    {
        public List<DoctorModel> findDoctor();

        public bool createDoctor( CreateDoctorDTOs data );

        public bool activeDoctor( Guid Id );

        public bool deactiveDoctor( Guid Id );

        public bool UpdateDoctor( Guid Id, UpdateDoctorDTOs newData );
        
    }
}
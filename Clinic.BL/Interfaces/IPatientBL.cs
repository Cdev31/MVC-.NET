
using mvc_practice.Models;
using mvc_practice.Schemas;

namespace mvc_practice.Clinic.BL.Interfaces
{
    public interface IPatientBL
    {
        public List<PatientModel> findPatients();

        public bool createPatient( CreatePatientDTOs data );

        public object showMedicalHistory( Guid Id );

        public bool updateMedicalHistory( Guid Id, UpdateMedicalHistoryDTOs newData );

        public bool updatePatient( Guid Id , UpdatePatientDTOs newData);
    }
}
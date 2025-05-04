using mvc_practice.Schemas;

namespace mvc_practice.Clinic.BL.Interfaces
{
    public interface IAppointmentBL
    {

        public List<Object> findAppointments();

        public bool addAppointment( CreateAppointmentDTOs data );
        
        public bool cancelAppointment( Guid Id );

        public bool updateAppointment( Guid Id, UpdateAppointmentDTOs newChanges );

        public bool finishAppointment( Guid Id );

    }
}
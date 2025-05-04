
using mvc_practice.Schemas;

namespace mvc_practice.Clinic.BL.Interfaces
{
    public interface IAuthBL
    {
        public bool login( LoginDTOs data );
    }
}
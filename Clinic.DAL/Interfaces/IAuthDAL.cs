using mvc_practice.Schemas;

namespace mvc_practice.Interfaces
{
    public interface AuthI
    {
        public bool login( LoginDTOs informationLogin);
    }
}
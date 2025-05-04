using mvc_practice.Schemas;

namespace mvc_practice.Interfaces
{
    public interface IAuthDAL
    {
        public bool login( LoginDTOs informationLogin);
    }
}
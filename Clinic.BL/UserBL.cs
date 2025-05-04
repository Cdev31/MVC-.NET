using mvc_practice.Clinic.BL.Interfaces;
using mvc_practice.Schemas;

namespace mvc_practice.Clinic.BL
{
    public class UserBL : IUserBL
    {
        public bool createUser(CreateUserDTOs data)
        {
            throw new NotImplementedException();
        }

        public object findUserByEmail(FindByEmailUserDTOs email)
        {
            throw new NotImplementedException();
        }

        public List<object> findUsers()
        {
            throw new NotImplementedException();
        }

        public bool updateUser(Guid Id, UpdateUserDTOs newData)
        {
            throw new NotImplementedException();
        }
    }
}
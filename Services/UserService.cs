using mvc_practice.Interfaces;
using mvc_practice.Models;
using mvc_practice.Schemas;

namespace mvc_practice.Services
{
    public class UserService : UserI
    {
        public bool create(CreateUserDTOs user)
        {
            throw new NotImplementedException();
        }

        public bool delete(SetIdUserDTOs Id)
        {
            throw new NotImplementedException();
        }

        public List<UserModel> findAll()
        {
            throw new NotImplementedException();
        }

        public UserModel findByEmail(findByEmailUserDTOs email)
        {
            throw new NotImplementedException();
        }

        public UserModel findById(SetIdUserDTOs Id)
        {
            throw new NotImplementedException();
        }

        public bool update(Guid Id, UpdateUserDTOs newInformation)
        {
            throw new NotImplementedException();
        }
    }
}
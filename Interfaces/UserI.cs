using mvc_practice.Schemas;
using mvc_practice.Models;

namespace mvc_practice.Services
{
    public interface UserI
    {
        public UserModel findByEmail( findByEmailUserDTOs email );

        public List<UserModel> findAll();

        public bool create(CreateUserDTOs user);

        public bool update( Guid Id, UpdateUserDTOs newInformation );

        public bool delete( SetIdUserDTOs Id );

        public UserModel findById( SetIdUserDTOs Id );
    }
}
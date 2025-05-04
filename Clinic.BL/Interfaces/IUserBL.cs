
using mvc_practice.Schemas;

namespace mvc_practice.Clinic.BL.Interfaces
{
    public interface IUserBL
    {
        public List<Object> findUsers();

        public bool createUser( CreateUserDTOs data );

        public bool updateUser( Guid Id , UpdateUserDTOs newData );

        public Object findUserByEmail( FindByEmailUserDTOs email );
    }
}
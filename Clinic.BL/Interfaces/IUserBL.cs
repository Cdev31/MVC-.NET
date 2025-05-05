
using mvc_practice.Clinic.DTOs;

namespace mvc_practice.Clinic.BL.Interfaces
{
    public interface IUserBL
    {
        public Task<List<FindUserOuputDTOs>> findUsers();

        public Task<bool> createUser( CreateUserDTOs data );

        public Task<bool> updateUser( Guid Id , UpdateUserDTOs newData );

        public Task<FindUserOuputDTOs> findUserByEmail( FindByEmailUserDTOs email );
    }
}
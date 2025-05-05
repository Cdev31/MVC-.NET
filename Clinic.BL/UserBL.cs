using mvc_practice.Clinic.BL.Interfaces;
using mvc_practice.Interfaces;
using mvc_practice.Models;
using mvc_practice.Clinic.DTOs;

namespace mvc_practice.Clinic.BL
{
    public class UserBL : IUserBL
    {
        readonly IUserDAL _userDAL;
        
        public UserBL( IUserDAL userDAL){
            _userDAL = userDAL;
        }

        public async Task<bool> createUser(CreateUserDTOs data)
        {
            throw new NotImplementedException();
        }

        public async Task<FindUserOuputDTOs> findUserByEmail(FindByEmailUserDTOs email)
        {
            throw new NotImplementedException();
        }

        public async Task<List<FindUserOuputDTOs>> findUsers()
        {
            List<UserModel> users = await _userDAL.findAll();

            List<FindUserOuputDTOs> _users = new List<FindUserOuputDTOs>();

            users.ForEach( user => _users.Add(
                new FindUserOuputDTOs(){
                    Id = user.Id,
                    allName = $"{user.InformationId.firstname} {user.InformationId.surname}",
                    dui = user.InformationId.dui,
                    email = user.InformationId.email,
                    gender = user.InformationId.gender,
                    dateOfBirth = user.InformationId.dateOfBirth,
                    role = user.RoleId.roleName,
                    isActive = user.isActive
                }
            ));

            return _users;
            
        }

        public async Task<bool> updateUser(Guid Id, UpdateUserDTOs newData)
        {
            throw new NotImplementedException();
        }
    }
}
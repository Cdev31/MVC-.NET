using mvc_practice.Clinic.BL.Interfaces;
using mvc_practice.Interfaces;
using mvc_practice.Models;
using mvc_practice.Clinic.DTOs;
using Microsoft.VisualBasic;
using mvc_practice.Clinic.DAL;
using mvc_practice.Clinic.DAL.Interfaces;

namespace mvc_practice.Clinic.BL
{
    public class UserBL : IUserBL
    {
        readonly IUserDAL _userDAL;
        readonly IUnitOfWork _unitOfWork;
        
        public UserBL( IUserDAL userDAL, IUnitOfWork unitOfWork){
            _userDAL = userDAL;
            _unitOfWork = unitOfWork;
        }

        public async Task<bool> createUser(CreateUserDTOs data)
        {
            UserModel user = new UserModel(){
                password = data.password,
                InformationId = new PersonInformationModel{
                    firstname = data.firstname,
                    surname = data.surname,
                    email = data.email,
                    dateOfBirth = data.dateOfBirth,
                    dui = data.dui
                },
                role = data.role
            };
            bool newUser = await _userDAL.create( user );
            await _unitOfWork.SaveChangesAsync();

            return newUser;
            
        }

        public async Task<FindUserOuputDTOs> findUserById(Guid Id)
        {
            UserModel user = await _userDAL.findById( Id );

            FindUserOuputDTOs _user = new FindUserOuputDTOs()
            {
                Id = user.Id,
                email = user.InformationId.email,
                phoneNumber = user.InformationId.phoneNUmber,
                allName = $"{ user.InformationId.firstname } { user.InformationId.surname }",
                isActive = user.isActive,
                dui = user.InformationId.dui,
                gender = user.InformationId.gender,
                role = user.RoleId.roleName
            };

            return _user;
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
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using mvc_practice.Clinic.DAL;
using mvc_practice.Db;
using mvc_practice.Interfaces;
using mvc_practice.Models;

namespace mvc_practice.Services
{
    public class UserDAL : IUserDAL
    {
        readonly ContextDB _contextDB;

        public UserDAL( ContextDB contextDB ){
            _contextDB = contextDB;
        }

        public async Task<bool> create(UserModel user)
        {
            try
            {
               var exitUser = await _contextDB.UserEN
                              .Where( u => u.InformationId.email == user.InformationId.email)
                              .Where( u => u.InformationId.dui == user.InformationId.dui )
                              .FirstOrDefaultAsync();

               if ( exitUser == null ){

                    await _contextDB.AddAsync( user );
                    return true;

               } else return false;
            
            }
            catch (SqlException ex)
            {
                 throw new DatabaseException(ex.Message, ex);
            }
        }

        public async void delete(Guid Id)
        {
            try
            {
                var user = await _contextDB.UserEN.FirstOrDefaultAsync( u => u.Id == Id);

                if( user == null ) return;

                _contextDB.UserEN.Remove( user );
            }
            catch (SqlException ex )
            {
                throw new DatabaseException( ex.Message, ex );
            }
        }

        public async Task<List<UserModel>> findAll()
        {
            try
            {
               var users = await _contextDB.UserEN
                            .Include( u => u.InformationId)
                            .Include( u => u.RoleId)
                            .ToListAsync();        
                return users;   

            }
            catch (SqlException ex)
            {
                 throw new DatabaseException(ex.Message, ex);
            }
        }

        public async Task<UserModel> findByEmail(string email)
        {
           try
           {
             var userExists = await _contextDB.UserEN
                            .Include( u=> u.InformationId)
                            .Include( u => u.RoleId)
                            .FirstOrDefaultAsync( u => u.InformationId.email == email);
    
            return ( userExists == null ) ? new UserModel() : userExists;
           }
           catch (SqlException ex)
           {
             throw new DatabaseException(ex.Message, ex);
           }
        }

        public async Task<UserModel> findById(Guid Id)
        {
            try
            {
               var user = await _contextDB.UserEN
                          .Include( u => u.InformationId)
                          .Include( u => u.RoleId )
                          .FirstOrDefaultAsync( u => u.InformationId.Id == Id);

               return ( user == null ) ? new UserModel() : user;              
            }
            catch (SqlException ex)
            {
              throw new DatabaseException(ex.Message, ex);
            }
        }

        public void update(Guid Id, UserModel newInformation)
        {
           try
           {
              _contextDB.UserEN.Update(newInformation);
           }
           catch (SqlException ex )
           {
               throw new DatabaseException(ex.Message, ex);
           }
        }

    }
}
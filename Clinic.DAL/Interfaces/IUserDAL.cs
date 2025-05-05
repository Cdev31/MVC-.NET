using mvc_practice.Models;

namespace mvc_practice.Interfaces
{
    public interface IUserDAL
    {
        public Task<UserModel> findByEmail( string email );

        public Task<List<UserModel>> findAll();

        public Task<bool> create( UserModel user);

        public void update( Guid Id, UserModel newInformation );

        public void delete( Guid Id );

        public Task<UserModel> findById( Guid Id );
    }
}
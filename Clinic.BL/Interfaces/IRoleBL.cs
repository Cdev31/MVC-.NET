using mvc_practice.Models;
using mvc_practice.Schemas;

namespace mvc_practice.Clinic.BL.Interfaces
{
    public interface IRoleBL
    {

        public List<RoleModel> findRoles();

        public bool createRole( CreateRoleDTOs data );
        
        public bool updateRole( int Id, UpdateRoleDTOs newData );

        public bool activeRole( int Id );

        public bool deactiveRole( int Id );
    }
}
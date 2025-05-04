using mvc_practice.Clinic.DAL.Interfaces;
using mvc_practice.Db;

namespace mvc_practice.Clinic.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        readonly ContextDB dbContext;

        public UnitOfWork( ContextDB _dbContext ){
            dbContext = _dbContext;
        }
        public Task<int> SaveChangesAsync()
        {
            return dbContext.SaveChangesAsync();  
        }
    }
}
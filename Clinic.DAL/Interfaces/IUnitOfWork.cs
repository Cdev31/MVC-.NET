
namespace mvc_practice.Clinic.DAL.Interfaces
{
    public interface IUnitOfWork
    {
       Task<int> SaveChangesAsync();   
    }
}

namespace mvc_practice.Clinic.DAL
{
    public class DatabaseException: Exception
    {
        public DatabaseException( string message, Exception innerException): base( message, innerException){}
    }
}
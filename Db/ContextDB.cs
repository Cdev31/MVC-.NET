using Microsoft.EntityFrameworkCore;
using mvc_practice.Models;

namespace mvc_practice.Db
{
    public class ContextDB: DbContext
    {

        public ContextDB( DbContextOptions<ContextDB> options ): base( options){}

        public DbSet<DoctorModel> DoctorEN { get; set; }
        public DbSet<AreaModel> AreaEN { get; set; }
        public DbSet<AppoinmentModel> AppointmentEN { get; set; }
        public DbSet<DiagnosesModel> DiagnosesEN { get; set; }
        public DbSet<MedicalHistoryModel> MedicalHistoryEN { get; set; }
        public DbSet<MedicationModel> MedicationEN { get; set; }
        public DbSet<PatientModel> PatientEN { get; set; }
        public DbSet<PersonInformationModel> PersonInformationEN { get; set; }
        public DbSet<PrescriptionModel> PrescriptionEN { get; set; }
        public DbSet<PrescriptionDrugModel> PrescriptionDrugEN { get; set; }
        public DbSet<RoleModel> RoleEN { get; set; }
        public DbSet<UserModel> UserEN { get; set; }
        
    }
}
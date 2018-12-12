using System.Data.Entity;

namespace Patient.Model
{
    public class PatientDemographicsContext : DbContext
    {
        public PatientDemographicsContext() : base("DbConnectionObj")
        {
            Database.SetInitializer<PatientDemographicsContext>(new CreateDatabaseIfNotExists<PatientDemographicsContext>());
        }
        public DbSet<Patient> Patient { get; set; }
    }
}

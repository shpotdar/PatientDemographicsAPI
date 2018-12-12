using System.Collections.Generic;

namespace Patient.Repository.Interface
{
    public interface IPatientRepository
    {
        IList<Patient.Model.Patient> GetAllPatientDetails();
        void CreatePatientInformation(Patient.Model.Patient _objPatient);

    }
}

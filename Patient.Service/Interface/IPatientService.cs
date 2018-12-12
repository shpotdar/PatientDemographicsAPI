using System.Collections.Generic;

namespace Patient.Service.Interface
{
    public interface IPatientService
    {
        IList<Patient.Model.Patient> GetAllPatientDetails();

        void CreatePatientInformation(Patient.Model.Patient _objPatient);
    }
}

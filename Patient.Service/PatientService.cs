using Patient.Repository.Interface;
using Patient.Service.Interface;
using System.Collections.Generic;

namespace Patient.Service
{
    public class PatientService : IPatientService
    {
        private IPatientRepository _objPatientRepo;
        public PatientService(IPatientRepository objPatientRepo)
        {
            _objPatientRepo = objPatientRepo;
        }
        public IList<Patient.Model.Patient> GetAllPatientDetails()
        {
            return _objPatientRepo.GetAllPatientDetails();
        }
        
        public void CreatePatientInformation(Model.Patient _objPatient)
        {
            _objPatientRepo.CreatePatientInformation(_objPatient);
        }
    }
}

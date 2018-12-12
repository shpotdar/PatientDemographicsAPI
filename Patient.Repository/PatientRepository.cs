using System;
using Patient.Repository.Interface;
using System.Collections.Generic;
using Patient.Model;
using System.Linq;

namespace Patient.Repository
{
    public class PatientRepository : IPatientRepository
    {
        public PatientRepository()
        {

        }
       
        public IList<Patient.Model.Patient> GetAllPatientDetails()
        {
            List<Patient.Model.Patient> _objPatient = new List<Patient.Model.Patient>();
            using (var _dbPatient = new PatientDemographicsContext())
            {
                _objPatient = _dbPatient.Patient.ToList<Patient.Model.Patient>();
            }
            return _objPatient;
        }
        public void CreatePatientInformation(Model.Patient _objPatient)
        {
            using (var _dbPatient = new PatientDemographicsContext())
            {
                _dbPatient.Patient.Add(_objPatient);
                _dbPatient.SaveChanges();
            }
        }
    }
}

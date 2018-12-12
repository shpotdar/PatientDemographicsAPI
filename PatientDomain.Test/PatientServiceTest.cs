using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Patient.Domain.OM;
using Patient.Repository.Interface;
using Patient.Service;
using Patient.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientDomain.Test
{
    [TestClass]
    public class PatientServiceTest
    {
        private IPatientService _patientService;
        private Mock<IPatientRepository> _mockRepository;

        [TestInitialize]
        public void Initialize()
        {
            _mockRepository = new Mock<IPatientRepository>();
            _patientService = new PatientService(_mockRepository.Object);
        }

        [TestMethod, TestCategory("UnitTest")]
        public void GetPatientDetails()
        {
            _mockRepository.Setup(r => r.GetAllPatientDetails()[0]).Returns(PatientDetail.GetPatient());
            var patient = _patientService.GetAllPatientDetails()[0];
            
            //Assert
            Assert.IsNotNull(patient);
        }
    }
}

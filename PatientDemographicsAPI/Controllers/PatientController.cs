using Patient.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PatientDemographicsAPI.Controllers
{
    public class PatientController : ApiController
    {
        private IPatientService _patientService;

        public PatientController(IPatientService patientService)
        {
            _patientService = patientService;
        }
        /// <summary>
        /// GET patient details from database
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public HttpResponseMessage GetAllPatientDetails()
        {
            try
            {
                var response = _patientService.GetAllPatientDetails();
                return Request.CreateResponse(HttpStatusCode.OK, response);
            }
            catch(Exception ex)
            {
                throw new ExceptionLayer.ExceptionLayer("patient details could not be fetched due to following error ", ex.InnerException);
            }
            return Request.CreateResponse(HttpStatusCode.NotFound);
        }
        /// <summary>
        /// POST - create patient information in database
        /// </summary>
        /// <param name="_objPatient"></param>
        [HttpPost]
        public void CreatePatientInformation([FromBody]Patient.Model.Patient _objPatient)
        {
            try
            {
                _patientService.CreatePatientInformation(_objPatient);
            }
            catch(Exception ex)
            {
                throw new ExceptionLayer.ExceptionLayer("patient details cannot be created due to following error ", ex.InnerException);
            }
        }
    }
}

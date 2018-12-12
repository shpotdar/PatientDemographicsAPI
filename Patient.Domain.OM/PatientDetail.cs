namespace Patient.Domain.OM
{
    public static class PatientDetail
    {
        public static Patient.Model.Patient GetPatient()
        {
            return new Patient.Model.Patient()
            {
                Id = 1,
                PatientObject = "<PatientModel xmlns:xsi='http://www.w3.org/2001/XMLSchema-instance' xmlns:xsd='http://www.w3.org/2001/XMLSchema'>< Forename > ddgdh </ Forename >< Surname > dhdhgfdh </ Surname >< DOB > 2018 - 11 - 08T00:00:00 </ DOB >< Gender > Male </ Gender >< TelephoneNumbers >" +
                                "< HomeNumber > 464646 </ HomeNumber >< WorkNumber > 585675675 </ WorkNumber >< MobileNumber > 5757567657 </ MobileNumber ></ TelephoneNumbers ></ PatientModel >"
            };
        }
    }
}

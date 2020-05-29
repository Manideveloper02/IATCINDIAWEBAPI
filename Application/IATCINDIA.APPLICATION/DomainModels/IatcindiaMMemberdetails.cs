using System;
using System.Collections.Generic;

namespace IATCINDIA.APPLICATION.DomainModels
{
    public partial class IatcindiaMMemberdetails
    {
        public int PkId { get; set; }
        public string Salutations { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Iatcregno { get; set; }
        public string Emailid { get; set; }
        public string DateofBirth { get; set; }
        public string Gender { get; set; }
        public string EducationQualification { get; set; }
        public string Medicine { get; set; }
        public string Nursing { get; set; }
        public string PostGraduate { get; set; }
        public string QualificationDetails { get; set; }
        public string ContactNo1 { get; set; }
        public string ContactNo2 { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Zip { get; set; }
        public string NameofInstitution { get; set; }
        public string CityInstitution { get; set; }
        public string StateInstitution { get; set; }
        public string Designation { get; set; }
        public string YearofExperience { get; set; }
        public string NottoregistrationNo { get; set; }
        public string Photo { get; set; }
        public string Profile { get; set; }
        public string AreasofInterest { get; set; }
        public string PaymentMode { get; set; }
        public string Bank { get; set; }
        public string TransacationNumber { get; set; }
        public string DateofTransaction { get; set; }
        public DateTime? Crtdate { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Status { get; set; }
    }
}

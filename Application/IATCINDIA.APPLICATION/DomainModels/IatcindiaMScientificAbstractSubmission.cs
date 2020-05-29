using System;
using System.Collections.Generic;

namespace IATCINDIA.APPLICATION.DomainModels
{
    public partial class IatcindiaMScientificAbstractSubmission
    {
        public int PkId { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Institution { get; set; }
        public string Contact { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string State { get; set; }
        public string Pincode { get; set; }
        public string Preferredpresentation { get; set; }
        public string Category { get; set; }
        public string Presentingauthor { get; set; }
        public string Affiliationofthepresentingauthor { get; set; }
        public string Contactno { get; set; }
        public string Coauthor1 { get; set; }
        public string Affiliationcoauthor1 { get; set; }
        public string Coauthor2 { get; set; }
        public string Affiliationcoauthor2 { get; set; }
        public string Abstract { get; set; }
        public DateTime? Crtdate { get; set; }
    }
}

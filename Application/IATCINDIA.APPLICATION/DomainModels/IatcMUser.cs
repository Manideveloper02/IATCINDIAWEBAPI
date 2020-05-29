using System;
using System.Collections.Generic;

namespace IATCINDIA.APPLICATION.DomainModels
{
    public partial class IatcMUser
    {
        public int PkId { get; set; }
        public string EmailId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public DateTime? LastLogin { get; set; }
        public string FirstLoginStatus { get; set; }
        public string Status { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? Lastmodified { get; set; }
    }
}

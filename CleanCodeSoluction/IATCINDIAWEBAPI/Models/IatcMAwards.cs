using System;
using System.Collections.Generic;

namespace IATCINDIAWEBAPI.Models
{
    public partial class IatcMAwards
    {
        public int PkId { get; set; }
        public string AwardsId { get; set; }
        public string AwardsTitle { get; set; }
        public string AwardsDate { get; set; }
        public string AwardsLocation { get; set; }
        public string AwardsDetails { get; set; }
        public string AwardsBanner { get; set; }
        public string StatusFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Lastmodified { get; set; }
    }
}

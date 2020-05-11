using System;
using System.Collections.Generic;

namespace IATCINDIAWEBAPI.Models
{
    public partial class IatcMResource
    {
        public int PkId { get; set; }
        public string ResourceId { get; set; }
        public string ResourceFileName { get; set; }
        public string StatusFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Lastmodified { get; set; }
    }
}

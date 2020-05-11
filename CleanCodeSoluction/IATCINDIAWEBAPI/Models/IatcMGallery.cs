using System;
using System.Collections.Generic;

namespace IATCINDIAWEBAPI.Models
{
    public partial class IatcMGallery
    {
        public int PkId { get; set; }
        public string EventId { get; set; }
        public string Image { get; set; }
        public string StatusFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Lastmodified { get; set; }
    }
}

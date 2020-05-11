using System;
using System.Collections.Generic;

namespace IATCINDIAWEBAPI.Models
{
    public partial class IatcMEvent
    {
        public int PkId { get; set; }
        public string EventId { get; set; }
        public string EventTitle { get; set; }
        public string EventDate { get; set; }
        public string EventLocation { get; set; }
        public string EventState { get; set; }
        public string EventDetails { get; set; }
        public string EventBanner { get; set; }
        public string StatusFlag { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? Lastmodified { get; set; }
    }
}

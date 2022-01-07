using System;
using System.Collections.Generic;

#nullable disable

namespace CoreWEBAPI.Models
{
    public partial class TblBookConsultation
    {
        public int Id { get; set; }
        public string SelectConsultationMode { get; set; }
        public string AuditAndAccounting { get; set; }
        public string SelectSubMatter { get; set; }
        public string SelectConsultant { get; set; }
        public string ConsultationDuration { get; set; }
        public DateTime ScheduleDate { get; set; }
        public TimeSpan Time { get; set; }
    }
}

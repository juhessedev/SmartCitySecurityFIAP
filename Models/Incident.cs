using System;

namespace SmartCitySecurity.Models
{
    public class Incident
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public DateTime ReportedAt { get; set; }
        public string Status { get; set; }
    }
}

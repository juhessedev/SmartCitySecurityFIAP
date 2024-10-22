using System;

namespace SmartCitySecurity.Models
{
    public class PolicePatrol
    {
        public int Id { get; set; }
        public string OfficerName { get; set; }
        public string Location { get; set; }
        public DateTime AssignedAt { get; set; }
        public string Status { get; set; }
    }
}

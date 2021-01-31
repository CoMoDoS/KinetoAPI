using System;

namespace KinetoAPI.Data.Entities
{
    public class AppointmentDto
    {
        public long Id { get; set; }
        public long IdPatient { get; set; }
        public long IdTreatment { get; set; }
        public DateTime Date { get; set; }
        public bool Done { get; set; }
        public int AddedBy { get; set; }
        public string Status { get; set; }
    }
}
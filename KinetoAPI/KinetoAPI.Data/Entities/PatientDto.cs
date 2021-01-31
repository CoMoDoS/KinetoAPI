using System;

namespace KinetoAPI.Data.Entities
{
    public class PatientDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int AppointmentsDone { get; set; }
        public int AppointmentsTotal { get; set; }
        public DateTime LastPay { get; set; }
        public int AddedBy { get; set; }
        public string Status { get; set; }
    }
}
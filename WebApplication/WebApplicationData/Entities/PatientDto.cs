using System;

namespace WebApplicationData.Entities
{
    public class PatientDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int AppointmentsDone { get; set; }
        public int AppointmentsTotal { get; set; }
        public DateTime LastPay { get; set; }
        public string AddedBy { get; set; }
        public string status { get; set; }
    }
}
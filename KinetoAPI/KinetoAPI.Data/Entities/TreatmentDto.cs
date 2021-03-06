namespace KinetoAPI.Data.Entities
{
    public class TreatmentDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Status { get; set; }
    }
}
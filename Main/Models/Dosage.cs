namespace PrihodkoCourse.Models
{
    public class Dosage
    {
        public int Id { get; set; }
        public int DiseaseMedicamentId { get; set; }
        public int MinAge { get; set; }
        public double Dose { get; set; }

        public DiseaseMedicament DiseaseMedicament { get; set; }
    }
}
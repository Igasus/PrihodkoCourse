namespace PrihodkoCourse.Models
{
    public class Substitute
    {
        public int OriginalMedicamentId { get; set; }
        public int SubstituteMedicamentId { get; set; }
        public float DosageMultiplier { get; set; }
        
        public Medicament OriginalMedicament { get; set; }
        public Medicament SubstituteMedicament { get; set; }
    }
}
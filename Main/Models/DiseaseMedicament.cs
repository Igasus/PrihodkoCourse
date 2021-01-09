using System.Collections.Generic;

namespace PrihodkoCourse.Models
{
    public class DiseaseMedicament
    {
        public int Id { get; set; }
        public int DiseaseId { get; set; }
        public int MedicamentId { get; set; }
        
        public Disease Disease { get; set; }
        public Medicament Medicament { get; set; }
        public ICollection<Dosage> Dosages { get; set; }
    }
}
using System.Collections.Generic;

namespace PrihodkoCourse.Models
{
    public class Medicament
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double StockQuantity { get; set; }
        
        public ICollection<Substitute> MedicamentSubstitutes { get; set; }
        public ICollection<Substitute> SubstituteOfMedicaments { get; set; }
        public ICollection<RecipeMedicament> MedicamentRecipes { get; set; }
        public ICollection<DiseaseMedicament> MedicamentDiseases { get; set; }
    }
}
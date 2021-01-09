using System.Collections.Generic;

namespace PrihodkoCourse.Models
{
    public class Disease
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<Recipe> Recipes { get; set; }
        public ICollection<DiseaseSymptom> DiseaseSymptoms { get; set; } 
        public ICollection<DiseaseMedicament> DiseaseMedicaments { get; set; }
    }
}
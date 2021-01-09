using System.Collections.Generic;

namespace PrihodkoCourse.Models
{
    public class Symptom
    {
        public int Id { get; set; }
        public string Name { get; set; }
        
        public ICollection<DiseaseSymptom> SymptomDiseases { get; set; }
    }
}
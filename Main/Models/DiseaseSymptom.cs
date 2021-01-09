namespace PrihodkoCourse.Models
{
    public class DiseaseSymptom
    {
        public int DiseaseId { get; set; }
        public int SymptomId { get; set; }
        
        public Disease Disease { get; set; }
        public Symptom Symptom { get; set; }
    }
}
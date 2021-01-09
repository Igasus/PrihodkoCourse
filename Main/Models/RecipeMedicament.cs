namespace PrihodkoCourse.Models
{
    public class RecipeMedicament
    {
        public int RecipeId { get; set; }
        public int MedicamentId { get; set; }
        public double Dose { get; set; }
        
        public Recipe Recipe { get; set; }
        public Medicament Medicament { get; set; }
    }
}
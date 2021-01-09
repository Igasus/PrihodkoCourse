using System;
using System.Collections.Generic;

namespace PrihodkoCourse.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public int ClientId { get; set; }
        public int DiseaseId { get; set; }
        public DateTime Date { get; set; }
        
        public Client Client { get; set; }
        public Disease Disease { get; set; }
        
        public ICollection<RecipeMedicament> RecipeMedicaments { get; set; }
    }
}
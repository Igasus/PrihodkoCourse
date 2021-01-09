using System.Collections.Generic;

namespace PrihodkoCourse.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string PhoneNumber { get; set; }
        public string InsurancePolicyNumber { get; set; }
        public string FullName { get; set; }
        public string Sex { get; set; }
        public int Age { get; set; }
        
        public ICollection<Recipe> Recipes { get; set; }
    }
}
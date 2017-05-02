using System.ComponentModel.DataAnnotations;

namespace SuggestionBox.Models
{
    public class Suggestion
    {
        [Key]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Comment { get; set; }
    }
}
using System.ComponentModel.DataAnnotations;

namespace Section_05.Data
{
    public class TodoItem
    {
        [Required]
        public string Description { get; set; }
        [Range(1,10, ErrorMessage = "Importance must be a number between 1 and 10")]
        public int Importance { get; set; }
    }
}

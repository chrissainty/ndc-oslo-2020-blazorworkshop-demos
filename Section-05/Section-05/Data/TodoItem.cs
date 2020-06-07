using System.ComponentModel.DataAnnotations;

namespace Section_05.Data
{
    public class TodoItem
    {
        [Required]
        public string Description { get; set; }

        [Range(1,10, ErrorMessage = "Please enter a value between 1 and 10")]
        public int Importance { get; set; }
    }
}

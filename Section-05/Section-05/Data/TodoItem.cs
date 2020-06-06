using System.ComponentModel.DataAnnotations;

namespace Section_05.Data
{
    public class TodoItem
    {
        [Required]
        public string Description { get; set; }
        public int Importance { get; set; }
    }
}

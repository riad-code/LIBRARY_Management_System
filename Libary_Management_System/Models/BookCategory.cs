using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Libary_Management_System.Models
{
    public class BookCategory
    {
        public int CategoryID { get; set; }

        [Required(ErrorMessage = "Category name is required")]
        public string CategoryName { get; set; }

        public string? Description { get; set; }

        public ICollection<Book>? Books { get; set; }
    }
}

using System.ComponentModel.DataAnnotations;

namespace library.management.system.Models.ViewModels
{
    public class BookViewModel
    {
        [Required(ErrorMessage = "Title is required")]
        [StringLength(100, ErrorMessage = "Title can not be more than 250 characters")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Author is required")]
        public string Author { get; set; }
        public string ISBN { get; set; }
        public DateTime PublicationYear { get; set; }
    }
}

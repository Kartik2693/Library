using System.ComponentModel.DataAnnotations;

namespace LibraryWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string CategoryName { get; set; }

        public int DisplayOrder { get; set; }
    }
}

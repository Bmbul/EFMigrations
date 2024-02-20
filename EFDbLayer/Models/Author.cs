using System.ComponentModel.DataAnnotations;

namespace EFDbLayer.Models
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; } = null!;

        //public ICollection<AuthorBook> AuthorBooks { get; set; }

        public ICollection<Book> Books { get; set; }    
    }
}

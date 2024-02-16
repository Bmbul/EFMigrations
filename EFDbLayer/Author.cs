using System.ComponentModel.DataAnnotations;

namespace EFDbLayer
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(128)]
        public string Name { get; set; } = null!;

        public List<Book>? Books { get; set; }
    }
}

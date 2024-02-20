using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EFDbLayer.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(256)]
        public string Title { get; set; } = null!;

        //public ICollection<AuthorBook> AuthorBooks { get; set; }


        //public int AuthorId { get; set; }
        public ICollection<AuthorBook> AuthorBook { get; set; }

        public Student Student { get; set; }    
    }
}

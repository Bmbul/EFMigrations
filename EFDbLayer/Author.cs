using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbLayer
{
    public class Author
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? BookId { get; set; }

        public Book? Book { get; set; }
    }
}

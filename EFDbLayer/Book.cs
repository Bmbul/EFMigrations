﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDbLayer
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        public string Title { get; set; }

        public int? AuthorId { get; set; }

        public Author Author { get; set; }
    }
}
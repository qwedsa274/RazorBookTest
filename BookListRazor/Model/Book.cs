using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [Display(Name = "Book Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Book ISBN")]
        public string ISBN { get; set; }

        [Required]
        [Display(Name = "Book Author")]
        public string Author { get; set; }

    }
}

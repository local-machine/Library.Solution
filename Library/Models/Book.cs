using System.Collections.Generic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models
{
    [Table("Books")]
    public class Book
    {

        [Key]
        public int BookId { get; set;}
        public string Title {get; set;}
        public string Genre{get; set; }
        public ICollection<AuthorBook> Authors {get; }
        public virtual ApplicationUser User {get; set;}

        public Book()
        {
            this.Authors = new HashSet<AuthorBook>();
            this.Completed = false;
        }
    }
}
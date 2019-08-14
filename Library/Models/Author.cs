using System.Collections.Generic;
namespace Library.Models
{
    public class Author
    {
        public int AuthorId {get; set;}
        public string AuthorName {get; set;}
        public ICollection<AuthorBook> Books {get; set;}

        public Author ()
        {
            this.Books = new HashSet<AuthorBook>();
        }
    }
}
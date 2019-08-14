using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Library.Models;
namespace Library.Models

{
    public class LibraryContext : IdentityDbContext<ApplicationUser>
    {

        public virtual DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<AuthorBook> AuthorBook { get; set; }
        public DbSet<Checkout> Checkout { get; set; }
        public DbSet<Copy> Copy { get; set; }

        public LibraryContext(DbContextOptions options) : base(options) { }
    }
}
using Microsoft.EntityFrameworkCore;

namespace SignInPage.Models
{
    public class SignInContext:DbContext
    {
        public SignInContext() { }
        public SignInContext(DbContextOptions options) : base(options) { }
        public DbSet<User> Usertbl { get; set; }
    }
}

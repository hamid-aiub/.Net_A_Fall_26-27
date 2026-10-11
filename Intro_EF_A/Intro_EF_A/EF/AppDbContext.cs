using Microsoft.EntityFrameworkCore;
using Intro_EF_A.Models;
namespace Intro_EF_A.EF
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Student> student { get; set; }
    }
}

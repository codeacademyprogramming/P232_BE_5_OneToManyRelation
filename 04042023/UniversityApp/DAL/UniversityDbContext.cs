using Microsoft.EntityFrameworkCore;
using UniversityApp.Models;

namespace UniversityApp.DAL
{
    public class UniversityDbContext:DbContext
    {
        public UniversityDbContext(DbContextOptions<UniversityDbContext> options):base(options)
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }    

    }
}

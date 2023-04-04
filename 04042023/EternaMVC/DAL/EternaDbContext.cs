using EternaMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace EternaMVC.DAL
{
    public class EternaDbContext:DbContext
    {
        public EternaDbContext(DbContextOptions<EternaDbContext> options):base(options)
        {

        }

        public DbSet<TeamMember> TeamMembers { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }

    }
}

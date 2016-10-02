using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace Gig.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        /* connection to database */
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre>  Genres { get; set; }



        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
    }
}
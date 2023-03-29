

using FederalWayOptometryRevamp.Models;
using Microsoft.EntityFrameworkCore;

namespace FederalWayOptometryRevamp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        

        //Create a table in SQL using Person model defined in Model folder.
        public DbSet<Person> Persons { get; set; }
    }
}

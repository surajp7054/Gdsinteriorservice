using Gdsinteriorservice.web.Models;
using Microsoft.EntityFrameworkCore;

namespace Gdsinteriorservice.web.DataDb
{
    public class GDSContext:DbContext
    {
        public GDSContext(DbContextOptions<GDSContext>options) : base(options) 
        {

        }
        public DbSet<Userdata> UsersData { get; set; }
    }
}

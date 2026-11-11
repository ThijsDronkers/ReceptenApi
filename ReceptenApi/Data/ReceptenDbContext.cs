using Microsoft.EntityFrameworkCore;
using ReceptenApi.Entities;

namespace ReceptenApi.Data
{
    public class ReceptenDbContext : DbContext
    {
        public ReceptenDbContext(DbContextOptions<ReceptenDbContext> options) : base(options) 
        {  
        }
        public DbSet<Recept> Recepten { get; set; }

    }
}

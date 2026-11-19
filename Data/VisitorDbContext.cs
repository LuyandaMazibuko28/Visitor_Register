using Microsoft.EntityFrameworkCore;
using VisitorRegister.Models;

namespace VisitorRegister.Data
{
    public class VisitorDbContext : DbContext
    {
        public VisitorDbContext(DbContextOptions<VisitorDbContext> options) : base(options) 
        {
        }

        public DbSet<Visitor> Visitors { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using RazorPizza.Model;

namespace RazorPizza.Data
{
    public class PizzaDbContext : DbContext
    {


        public DbSet<PizzaOrder> PizzaOrders { get; set; }

        public PizzaDbContext(DbContextOptions<PizzaDbContext> options) : base(options)
        {

        }

        
    }
}

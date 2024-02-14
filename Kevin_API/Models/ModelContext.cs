using Kevin_API.Models;
using Microsoft.EntityFrameworkCore;

namespace cars_api.Models
{
    public class ModelContext : DbContext
    {
        public DbSet<Model> cars { get; set; }
        public ModelContext(DbContextOptions options) : base(options) 
        {

        }
    }
}

using Microsoft.EntityFrameworkCore;
using ProEentos.API.Model;

namespace ProEentos.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }
        public DbSet<Evento> Eventos{get; set;}
    }
}
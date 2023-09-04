using Digital_Circle.Back.Domain.Entidades;
using Microsoft.EntityFrameworkCore;

namespace Digital_Circle.Back.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            
        }

        public DbSet<Entidade> Entidades { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
        }
    }
}

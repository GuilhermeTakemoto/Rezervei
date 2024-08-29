using Microsoft.EntityFrameworkCore;
using Rezervei.Contexts.builders;
using Rezervei.Object.Models.Entities;

namespace Rezervei.Contexts
{
    public class AppDBContext : DbContext
    {
        //mapeamento Relacional dos Objetos no Banco de dados
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        //Conjunto:usuario
        public DbSet<UserModel> Users { get; set; }

        // Fluent API
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            UserBuilder.Build(modelBuilder);
        }
    }
}

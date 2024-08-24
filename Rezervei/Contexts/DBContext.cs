using Microsoft.EntityFrameworkCore;
using Rezervei.Contexts.builders;
using Rezervei.Object.Models;

namespace Rezervei.Contexts
{
    public class DBContext : DbContext
    {
        //mapeamento Relacional dos Objetos no Banco de dados
        public DBContext(DbContextOptions<DBContext> options) : base(options) { }
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

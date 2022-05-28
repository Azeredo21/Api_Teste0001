using Api_Teste0001.Models;
using Microsoft.EntityFrameworkCore;

namespace Api_Teste0001.Data {
    public class AppDbContext : DbContext {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => 
            optionsBuilder.UseSqlite(connectionString: "DataSource=app.db;Cache=Shared");
    }
}

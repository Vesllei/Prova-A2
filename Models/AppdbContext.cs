using Microsoft.EntityFrameworkCore;
namespace Weslley;

public class AppdbContext : DbContext
{

    public DbSet<Folha> Folhas { get; set; }
    public DbSet<Funcionario> Funcionarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source = weslley_nicolas.db");


    }
}

using Microsoft.EntityFrameworkCore;
using Smart.CleanArch.Domain.Entities.Endereco;
using Smart.CleanArch.Domain.Entities.Pessoa;
using Smart.CleanArch.Domain.Entities.Produto;

namespace Smart.CleanArch.Infra.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    //public DbSet<Produtos> Produtos { get; set; }
    //public DbSet<Pessoas> Pessoas { get; set; }
    //public DbSet<Enderecos> Enderecos { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);
    }
}

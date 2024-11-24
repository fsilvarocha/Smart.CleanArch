using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.CleanArch.Domain.Entities.Pessoa;

namespace Smart.CleanArch.Infra.Mappings.Pessoa;

public class PessoasMap : IEntityTypeConfiguration<Pessoas>
{
    public void Configure(EntityTypeBuilder<Pessoas> builder)
    {
        builder.ToTable(nameof(Pessoas));

        builder.HasKey(p => p.Id);

        builder.Property(p => p.Nome)
            .HasColumnType("varchar(150)");

        builder.Property(p => p.DataCriacao)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");

        builder.Property(p => p.DataAtualizado)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");

        builder.HasMany(p => p.Enderecos)
            .WithOne(e => e.Pessoa)
            .HasForeignKey(e => e.PessoaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.Navigation(e => e.Enderecos)
            .AutoInclude();

        builder.HasQueryFilter(p => p.Tenante == p.Tenante);
    }
}

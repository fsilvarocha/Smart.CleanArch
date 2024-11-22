using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.CleanArch.Domain.Entities.Produto;

namespace Smart.CleanArch.Infra.Mappings.Produto;

public class ProdutosMap : IEntityTypeConfiguration<Produtos>
{
    public void Configure(EntityTypeBuilder<Produtos> builder)
    {
        builder.ToTable(nameof(Produtos));
        builder.HasKey(p => p.Id);


        builder.Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("varchar(150)");

        builder.Property(p => p.DataCriacao)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");

        builder.Property(p => p.DataAtualizado)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Smart.CleanArch.Domain.Entities.Endereco;

namespace Smart.CleanArch.Infra.Mappings.Endereco;

public class EnderecosMap : IEntityTypeConfiguration<Enderecos>
{
    public void Configure(EntityTypeBuilder<Enderecos> builder)
    {
        builder.ToTable(nameof(Enderecos));

        builder.HasKey(e=>e.Id);

        builder.Property(p => p.Logradouro)
            .HasColumnType("varchar(250)");

        builder.Property(p => p.Cep)
                        .HasColumnType("varchar(10)");

        builder.Property(p => p.DataCriacao)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");

        builder.Property(p => p.DataAtualizado)
            .HasDefaultValue(DateTime.Now)
            .HasColumnType("Date");

        builder.HasOne(e => e.Pessoa)
            .WithMany(p => p.Enderecos)
            .HasForeignKey(e => e.PessoaId)
            .OnDelete(DeleteBehavior.Cascade);

        builder.HasIndex(e => new {e.PessoaId, e.Tenante})
            .IsUnique();

        builder.HasQueryFilter(e => e.Pessoa != null && e.Tenante == e.Pessoa.Tenante);
    }
}

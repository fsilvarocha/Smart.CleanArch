namespace Smart.CleanArch.Domain.Common;

public class BaseEntity
{
    public int Id { get; protected set; }
    public Guid Tenante { get; protected set; } = Guid.NewGuid();
    public DateTime DataCriacao { get; protected set; } = DateTime.Now;
    public DateTime? DataAtualizado { get; protected set; }
}

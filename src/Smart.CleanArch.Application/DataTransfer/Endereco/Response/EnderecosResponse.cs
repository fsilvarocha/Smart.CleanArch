namespace Smart.CleanArch.Application.DataTransfer.Endereco.Response;

public class EnderecosResponse
{
    public int Id { get; set; }
    public Guid Tenante { get; set; }
    public string Logradouro { get; protected set; }
    public string Cep { get; protected set; }
    public string Cidade { get; protected set; }

}

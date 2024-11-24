using Smart.CleanArch.Domain.Entities.Endereco;
using Smart.CleanArch.Domain.Interfaces.Endereco;
using Smart.CleanArch.Infra.Data;
using Smart.CleanArch.Infra.Repositories.Base;

namespace Smart.CleanArch.Infra.Repositories.Endereco;

public class EnderecosRepository(ApplicationDbContext context) : BaseRepository<Enderecos>(context), IEnderecosRepository
{
    private readonly ApplicationDbContext _context = context;
}

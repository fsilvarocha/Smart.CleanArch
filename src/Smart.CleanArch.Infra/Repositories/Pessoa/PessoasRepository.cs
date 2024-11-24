using Smart.CleanArch.Domain.Entities.Pessoa;
using Smart.CleanArch.Domain.Interfaces.Pessoa;
using Smart.CleanArch.Infra.Data;
using Smart.CleanArch.Infra.Repositories.Base;

namespace Smart.CleanArch.Infra.Repositories.Pessoa;

public class PessoasRepository(ApplicationDbContext context) : BaseRepository<Pessoas>(context), IPessoasRepository
{
    private readonly ApplicationDbContext _context = context;
}

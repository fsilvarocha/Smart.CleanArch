using Smart.CleanArch.Domain.Entities.Produto;
using Smart.CleanArch.Domain.Interfaces.Produto;
using Smart.CleanArch.Infra.Data;
using Smart.CleanArch.Infra.Repositories.Base;

namespace Smart.CleanArch.Infra.Repositories.Produto;

public class ProdutosRepository(ApplicationDbContext context) : BaseRepository<Produtos>(context), IProdutosRepository
{
    private readonly ApplicationDbContext _context = context;
}

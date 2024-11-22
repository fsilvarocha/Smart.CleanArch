using Microsoft.EntityFrameworkCore;
using Smart.CleanArch.Domain.Entities.Produto;
using Smart.CleanArch.Domain.Interfaces.Produto;
using Smart.CleanArch.Infra.Data;
using Smart.CleanArch.Infra.Repositories.Base;

namespace Smart.CleanArch.Infra.Repositories.Produto;

public class ProdutosRepository : BaseRepository<Produtos>, IProdutosRepository
{
    private readonly ApplicationDbContext _context;
    public ProdutosRepository(ApplicationDbContext context) : base(context)
    {
        _context = context;
    }
}

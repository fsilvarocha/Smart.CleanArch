using Microsoft.AspNetCore.Mvc;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Request;
using Smart.CleanArch.Application.DataTransfer.Pessoa.Response;
using Smart.CleanArch.Application.Services.Interfaces.Pessoa;

namespace Smart.CleanArch.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PessoasController : ControllerBase
    {

        private readonly IPessoasService _pessoaService;

        public PessoasController(IPessoasService pessoaService)
        {
            _pessoaService = pessoaService;
        }

        /// <summary>
        /// Obtem todos as pessoas cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet("obter-todos")]
        public async Task<ActionResult<IEnumerable<PessoasResponse>>> GetAll()
        {
            var Produtoss = await _pessoaService.GetAllAsync();
            return Ok(Produtoss);
        }

        /// <summary>
        /// Busca por uma pessoa informando o Id(int) e Tenante(GUID)
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenante"></param>
        /// <returns></returns>
        [HttpGet("buscar-tenante")]
        public async Task<ActionResult<PessoasResponse>> GetByTenante(int id, Guid tenante)
        {
            PessoaPesquisaRequest pesquisaRequest = new()
            {
                Id = id,
                Tenante = tenante
            };

            PessoasResponse Produtos = await _pessoaService.GetByIdTenanteAsync(pesquisaRequest);
            if (Produtos == null)
                return NotFound();

            return Ok(Produtos);
        }
    }
}

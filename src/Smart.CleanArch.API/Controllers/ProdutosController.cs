using Microsoft.AspNetCore.Mvc;
using Smart.CleanArch.Application.DataTransfer.Produto.Request;
using Smart.CleanArch.Application.DataTransfer.Produto.Response;
using Smart.CleanArch.Application.Services.Interfaces.Produtos;
using Smart.CleanArch.Domain.Entities.Produto;

namespace Smart.CleanArch.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutosServices _produtosServices;

        public ProdutosController(IProdutosServices produtosServices)
        {
            _produtosServices = produtosServices;
        }

        /// <summary>
        /// Obtem todos os produtos cadastrados
        /// </summary>
        /// <returns></returns>
        [HttpGet("obter-todos")]
        public async Task<ActionResult<IEnumerable<ProdutosResponse>>> GetAll()
        {
            var Produtoss = await _produtosServices.GetAllAsync();
            return Ok(Produtoss);
        }

        /// <summary>
        /// Busca por um produto informando o Id e o Guid Tenante
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenante"></param>
        /// <returns></returns>
        [HttpGet("buscar-id-tenante")]
        public async Task<ActionResult<ProdutosResponse>> GetById(int id, Guid tenante)
        {
            ProdutosPesquisaRequest pesquisaRequest = new()
            {
                Id = id,
                Tenante = tenante
            };

            ProdutosResponse Produtos = await _produtosServices.GetByIdAsync(pesquisaRequest);
            if (Produtos == null)
                return NotFound();

            return Ok(Produtos);
        }

        /// <summary>
        /// Cria um novo Produto
        /// </summary>
        /// <param name="Produtos"></param>
        /// <returns></returns>
        [HttpPost("criar")]
        public async Task<ActionResult<Produtos>> Create(ProdutosInserirRequest Produtos)
        {
            var createdProdutos = await _produtosServices.AddAsync(Produtos);
            return CreatedAtAction(nameof(GetById), new { id = createdProdutos.Id }, createdProdutos);
        }

        /// <summary>
        /// Atualiza um produto já previamente cadastrado
        /// </summary>
        /// <param name="Produtos"></param>
        /// <returns></returns>
        [HttpPut("atualizar")]
        public async Task<IActionResult> Update([FromBody]ProdutosAtualizarRequest Produtos)
        {
            if (string.IsNullOrEmpty(Produtos.Nome))
                return BadRequest();

            await _produtosServices.UpdateAsync(Produtos);
            return NoContent();
        }

        /// <summary>
        /// Delete um produto cadastrado
        /// </summary>
        /// <param name="id"></param>
        /// <param name="tenante"></param>
        /// <returns></returns>
        [HttpDelete("deletar")]
        public async Task<IActionResult> Delete(int id, Guid tenante)
        {
            ProdutosPesquisaRequest comando = new()
            {
                Id = id,
                Tenante = tenante,
            };

            var Produtos = await _produtosServices.GetByIdAsync(comando);
            if (Produtos == null)
                return NotFound();

            await _produtosServices.DeleteAsync(id, tenante);
            return NoContent();
        }
    }
}

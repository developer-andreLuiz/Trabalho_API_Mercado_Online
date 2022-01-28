using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/produtos")]
    public class ProdutosController : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();
        
        // --/api/produto
        [Route("")]
        [HttpGet]
        public ActionResult GetProdutos()
        {
            var list = _banco.Produtos.AsNoTracking().AsQueryable();
            return Ok(list);
        }

        // --/api/produto/1
        [Route("{id}")]
        [HttpGet]
        public ActionResult GetProduto(int id)
        {
            var obj = _banco.Produtos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }
       
        
        
        
        
        
        
        
        
        // --/api/produto(POST: id, nome, valor, etc...)
        [Route("")]
        [HttpPost]
        private ActionResult CreateProduto([FromBody] Produto produto)
        {
            _banco.Produtos.Add(produto);
            _banco.SaveChanges();
            return Created($"/api/produto/{produto.Id}", produto);
        }
        
        // --/api/produto/1 (PUT: id, nome, valor, etc...)
        [Route("{id}")]
        [HttpPut]
        private ActionResult Atualizar(int id, [FromBody] Produto palavra)
        {
            var obj = _banco.Produtos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            palavra.Id = id;
            _banco.Produtos.Update(palavra);
            _banco.SaveChanges();
            return Ok(palavra);
        }
        
        // --/api/produto/1 (DELETE)
        [Route("{id}")]
        [HttpDelete]
        private ActionResult Deletar(int id)
        {
            var obj = _banco.Produtos.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            _banco.Produtos.Remove(obj);
            _banco.SaveChanges();
            return NoContent();//sem conteudo
        }

    }
}

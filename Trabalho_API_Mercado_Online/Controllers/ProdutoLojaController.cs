using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;
namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/produtoloja")]
    public class ProdutoLojaController : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtoloja
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.ProdutoLojas.AsNoTracking().AsQueryable();
            return Ok(list);
        }
     
        // --/api/produtoloja/id/1
        [Route("id/{id}")]
        [HttpGet]
        public ActionResult Get(int id)
        {
            var obj = _banco.ProdutoLojas.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }

        // --/api/produtoloja(POST: id, nome...)
        [Route("")]
        [HttpPost]
        public ActionResult Create([FromBody] ProdutoLoja produtoLoja)
        {
            _banco.ProdutoLojas.Add(produtoLoja);
            _banco.SaveChanges();
            return Created($"/api/produtoloja/id/{produtoLoja.Id}", produtoLoja);
        }

        // --/api/produtoloja/1 (PUT: id, nome...)
        [Route("{id}")]
        [HttpPut]
        public ActionResult Update(int id, [FromBody] ProdutoLoja produtoLoja)
        {
            var obj = _banco.ProdutoLojas.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            produtoLoja.Id = id;
            _banco.ProdutoLojas.Update(produtoLoja);
            _banco.SaveChanges();
            return Ok(produtoLoja);
        }

        // --/api/usuario/1
        [Route("{id}")]
        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var obj = _banco.ProdutoLojas.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
          
            _banco.ProdutoLojas.Remove(obj);
            _banco.SaveChanges();
            return Ok(obj);
        }

    }
}

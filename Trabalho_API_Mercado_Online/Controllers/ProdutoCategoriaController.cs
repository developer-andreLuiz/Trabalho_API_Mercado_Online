using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/produto-categoria")]
    public class ProdutoCategoriaController : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtoscategoria
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.ProdutoCategoria.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

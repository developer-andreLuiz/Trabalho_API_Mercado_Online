using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/produtocodigobarra")]
    public class ProdutoCodigoBarraController : Controller
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtocodigobarra
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.ProdutoCodigoBarras.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

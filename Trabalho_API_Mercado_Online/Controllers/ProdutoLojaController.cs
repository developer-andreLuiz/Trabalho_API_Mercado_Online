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

        
    }
}

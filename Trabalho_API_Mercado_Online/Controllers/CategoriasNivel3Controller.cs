using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/categoriasnivel3")]
    public class CategoriasNivel3Controller : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtoscategoria
        [Route("")]
        [HttpGet]
        public ActionResult GetCategoriasNivel3()
        {
            var list = _banco.CategoriasNivel3s.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/categoriasnivel1")]
    public class CategoriasNivel1Controller : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtoscategoria
        [Route("")]
        [HttpGet]
        public ActionResult GetCategoriasNivel1()
        {
            var list = _banco.CategoriasNivel1s.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

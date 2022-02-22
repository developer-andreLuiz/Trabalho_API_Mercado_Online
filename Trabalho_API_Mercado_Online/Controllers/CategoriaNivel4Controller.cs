using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/categoria-nivel-4")]
    public class CategoriaNivel4Controller : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtoscategoria
        [Route("")]
        [HttpGet]
        public ActionResult GetCategoriasNivel4()
        {
            var list = _banco.CategoriasNivel4s.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

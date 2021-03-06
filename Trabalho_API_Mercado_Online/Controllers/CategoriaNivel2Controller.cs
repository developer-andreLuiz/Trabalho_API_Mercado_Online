using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/categoria-nivel-2")]
    public class CategoriaNivel2Controller : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtoscategoria
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.CategoriaNivel2s.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

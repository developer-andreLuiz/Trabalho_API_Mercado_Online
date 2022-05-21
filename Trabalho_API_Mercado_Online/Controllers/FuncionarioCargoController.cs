using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/funcionariocargo")]
    public class FuncionarioCargoController : Controller
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/funcionariocargo
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.FuncionarioCargos.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

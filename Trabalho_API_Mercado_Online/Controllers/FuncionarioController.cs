using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/funcionario")]
    public class FuncionarioController : Controller
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/funcionario
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.Funcionarios.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

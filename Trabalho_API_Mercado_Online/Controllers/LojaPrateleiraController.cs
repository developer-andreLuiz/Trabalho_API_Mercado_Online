using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/lojaprateleira")]
    public class LojaPrateleiraController : Controller
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtocodigobarra
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.LojaPrateleiras.AsNoTracking().AsQueryable();
            return Ok(list);
        }





       
        
        
        
        
        
        // --/api/produtocodigobarra/1 (PUT: id, nome...)
        [Route("{id}")]
        [HttpPut]
        public ActionResult Update(int id, [FromBody] LojaPrateleira LojaPrateleira)
        {
            var obj = _banco.LojaPrateleiras.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            LojaPrateleira.Id = id;
            _banco.LojaPrateleiras.Update(LojaPrateleira);
            _banco.SaveChanges();
            return Ok(LojaPrateleira);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;
namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/cliente")]
    public class ClienteController : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();
        
        // --/api/cliente
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.Clientes.AsNoTracking().AsQueryable();
            return Ok(list);
        }
       
        // --/api/cliente/1
        [Route("{id}")]
        [HttpGet]
        public ActionResult Get(int id)
        {
            var obj = _banco.Clientes.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }

        // --/api/cliente(POST: id, nome...)
        [Route("")]
        [HttpPost]
        public ActionResult Create([FromBody] Cliente cliente)
        {
            _banco.Clientes.Add(cliente);
            _banco.SaveChanges();
            return Created($"/api/cliente/{cliente.Id}", cliente);
        }

        // --/api/cliente/1 (PUT: id, nome...)
        [Route("{id}")]
        [HttpPut]
        public ActionResult Update(int id, [FromBody] Cliente cliente)
        {
            var obj = _banco.Clientes.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            cliente.Id = id;
            _banco.Clientes.Update(cliente);
            _banco.SaveChanges();
            return Ok(cliente);
        }

        // --/api/cliente/1
        [Route("{id}")]
        [HttpDelete]
        public ActionResult Disable(int id)
        {
            var obj = _banco.Clientes.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            obj.Habilitado = 0;
           _banco.SaveChanges();
            return NoContent();
        }
    }
}

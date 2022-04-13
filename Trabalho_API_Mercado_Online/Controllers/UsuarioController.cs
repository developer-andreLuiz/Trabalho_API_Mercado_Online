using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;
namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/usuario")]
    public class UsuarioController : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();
        
        // --/api/usuario
        [Route("")]
        [HttpGet]
        public ActionResult GetAll()
        {
            var list = _banco.Usuarios.AsNoTracking().AsQueryable();
            return Ok(list);
        }

        // --/api/usuario/1
        [Route("id/{id}")]
        [HttpGet]
        public ActionResult Get(int id)
        {
            var obj = _banco.Usuarios.AsNoTracking().FirstOrDefault(a => a.Id==id);
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }

        // --/api/usuario/21999999999
        [Route("telefone/{telefone}")]
        [HttpGet]
        public ActionResult Get(string telefone)
        {
            var obj = _banco.Usuarios.AsNoTracking().FirstOrDefault(a => a.Telefone.Equals(telefone));
            if (obj == null)
            {
                return NotFound();
            }
            return Ok(obj);
        }



        // --/api/usuario(POST: id, nome...)
        [Route("")]
        [HttpPost]
        public ActionResult Create([FromBody] Usuario usuario)
        {
            _banco.Usuarios.Add(usuario);
            _banco.SaveChanges();
             usuario.Img = $"https://mercadoonline.blob.core.windows.net/usuario/{usuario.Id}.png";
            _banco.Usuarios.Update(usuario);
            _banco.SaveChanges();
            return Created($"/api/usuario/{usuario.Id}", usuario);
        }

        // --/api/usuario/1 (PUT: id, nome...)
        [Route("{id}")]
        [HttpPut]
        public ActionResult Update(int id, [FromBody] Usuario usuario)
        {
            var obj = _banco.Usuarios.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }

            usuario.Id = id;
            _banco.Usuarios.Update(usuario);
            _banco.SaveChanges();
            return Ok(usuario);
        }

        // --/api/usuario/1
        [Route("{id}")]
        [HttpDelete]
        public ActionResult Disable(int id)
        {
            var obj = _banco.Usuarios.AsNoTracking().FirstOrDefault(a => a.Id == id);
            if (obj == null)
            {
                return NotFound();
            }
            obj.Habilitado = 0;
            _banco.Usuarios.Update(obj);
            _banco.SaveChanges();
            return Ok(obj);
        }
    }
}

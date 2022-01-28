﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Trabalho_API_Mercado_Online.Models;

namespace Trabalho_API_Mercado_Online.Controllers
{
    [ApiController]
    [Route("api/produtoscategoria")]
    public class ProdutosCategoriaController : ControllerBase
    {
        private readonly DBContextDAO _banco = new DBContextDAO();

        // --/api/produtoscategoria
        [Route("")]
        [HttpGet]
        public ActionResult GetProdutosCategoria()
        {
            var list = _banco.ProdutosCategoria.AsNoTracking().AsQueryable();
            return Ok(list);
        }
    }
}

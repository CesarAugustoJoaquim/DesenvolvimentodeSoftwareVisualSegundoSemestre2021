using Microsoft.AspNetCore.Mvc;
using API.Models;
using API.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{

    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        private readonly DataContext _context;
        public ProdutoController(DataContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(Produto produto)
        {
            await _context.Produtos.AddAsync(produto);
            _context.SaveChanges();
            return Created("", produto);
        }

        [HttpGet]
        [Route("list")]
        public async Task<IActionResult> List() => Ok(await _context.Produtos.ToListAsync());


        [HttpGet]
        [Route("getbyid/{id}")]
        public async Task<IActionResult> GetByIdAsync([FromRoute] int id)
        {
            Produto produto = await _context.Produtos.FindAsync(id);
            if (produto != null)
            {
                return Ok(produto);
            }
            return NotFound();
        }

        [HttpDelete]
        [Route("delete/{name}")]
        public async Task<IActionResult> DeleteAsync([FromRoute] string name)
        {
            Produto produto = _context.Produtos.FirstOrDefault(produto => produto.Nome == name);
            _context.Produtos.Remove(produto);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        [Route("update")]
        public async Task<IActionResult> UpdateAsync([FromBody] Produto produto)
        {
            _context.Produtos.Update(produto);
            await _context.SaveChangesAsync();
            return Ok();
        }
    }
}
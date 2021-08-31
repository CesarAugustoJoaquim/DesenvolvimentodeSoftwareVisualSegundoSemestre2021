using Microsoft.AspNetCore.Mvc;
using API.Models;

namespace API.Controllers
{
    [ApiController]
    [Route("api/produto")]
    public class ProdutoController : ControllerBase
    {
        [HttpPost]
        [Route("Create")]
        public Produto Post(Produto produto)
        {
            return produto;
        }
    }
}
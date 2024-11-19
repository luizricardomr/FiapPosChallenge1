using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure;
using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Repository;
using FIAP.NET.Grupo13.CadastroDeContatos.Service;
using FIAP.NET.Grupo13.CadastroDeContatos.Service.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Controllers
{    
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class ContatoController : ControllerBase
    {
        private readonly BaseLogger<ContatoController> _logger;
        private readonly IContatoService _contatoService;

        public ContatoController(BaseLogger<ContatoController> logger, 
            IContatoService contatoService)
        {
            _logger = logger;
            _contatoService = contatoService;
        }

        [HttpGet("GetContatoPorDDD/{id}")]
        public async Task<IEnumerable<Contato>> GetContatoPorDDD(int id)
        {
            return await _contatoService.GetContatoByDDD(id);
        }

        [HttpPost]
        [Authorize(Policy ="Admin")]
        public IActionResult Post([FromBody] string value)
        {
            return Ok("Esse endpoint só acessivel como Admin");
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }


        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

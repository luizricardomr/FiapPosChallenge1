using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure;
using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Repository;
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
        private readonly IContatoRepository _repository;

        public ContatoController(BaseLogger<ContatoController> logger, IContatoRepository repository)
        {
            _logger = logger;
            _repository = repository;
        }

        [HttpGet("GetDDD")]
        public async Task<IEnumerable<CodigoDDD>> GetDDD()
        {
            return await _repository.GetAllDDD();
        }

        [HttpGet("GetDDD/{id}")]
        public async Task<CodigoDDD> GetDDD(int id)
        {
            return (await _repository.GetAllDDD(id)).FirstOrDefault();
        }

        [HttpGet("GetContatoPorDDD/{id}")]
        public async Task<Contato> GetContatoPorDDD(int id)
        {
            return (await _repository.GetContatoByDDD(id)).FirstOrDefault();
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

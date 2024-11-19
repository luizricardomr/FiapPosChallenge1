using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Repository;
using FIAP.NET.Grupo13.CadastroDeContatos.Service.Models;
using Microsoft.AspNetCore.DataProtection.KeyManagement;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Service
{
    public class ContatoService: IContatoService
    {
        private readonly IContatoRepository _repository;
        private readonly ICacheService _cacheService;

        public ContatoService(IContatoRepository repository, 
                              ICacheService cacheService)
        {
            _repository = repository;
            _cacheService = cacheService;
        }

        public async Task<IEnumerable<Contato>> GetContatoByDDD(int ddd)
        {
            var cachedProduct = _cacheService.Get(ddd.ToString());

            if (cachedProduct != null)
            {
                return (IEnumerable<Contato>)cachedProduct;
            }

            var dados = await _repository.GetContatoByDDD(ddd);
            
            if(dados != null)
                _cacheService.Set(ddd.ToString(), dados);
            
            return  dados;
        }
    }
}

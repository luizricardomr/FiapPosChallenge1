using FIAP.NET.Grupo13.CadastroDeContatos.Service.Models;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Service
{
    public interface IContatoService
    {
        Task<IEnumerable<Contato>> GetContatoByDDD(int ddd);
    }
}

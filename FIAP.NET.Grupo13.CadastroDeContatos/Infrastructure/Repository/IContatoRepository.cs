using FIAP.NET.Grupo13.CadastroDeContatos.Service.Models;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Repository
{
    public interface IContatoRepository
    {
        Task<IEnumerable<CodigoDDD>> GetAllDDD(int? id = null);
        Task<IEnumerable<Contato>> GetContatoByDDD(int id);
    }
}

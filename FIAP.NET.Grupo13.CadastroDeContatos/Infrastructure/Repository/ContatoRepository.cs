using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Query;
using FIAP.NET.Grupo13.CadastroDeContatos.Service.Models;
using Dapper;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Repository
{
    public class ContatoRepository : IContatoRepository
    {
        private readonly DbConnectionProvider _dbProvider;

        public ContatoRepository(DbConnectionProvider dbProvider)
        {
            _dbProvider = dbProvider;
        }

        public async Task<IEnumerable<CodigoDDD>> GetAllDDD(int? id = null)
        {
            using var connection = _dbProvider.GetConnection();
            var query = Query.Query.ListDDD(id);
            return await connection.QueryAsync<CodigoDDD>(query, new { Id = id }); 
        }

        public async Task<IEnumerable<Contato>> GetContatoByDDD(int id)
        {
            using var connection = _dbProvider.GetConnection();
            var query = Query.Query.GetContatoByDDD(id);
            return await connection.QueryAsync<Contato>(query, new { Id = id });
        }
    }
}

using FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Config;
using Microsoft.Extensions.Options;
using Npgsql;
using System.Data;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure
{
    public class DbConnectionProvider: IDisposable
    {
        private  IDbConnection _connection;
        private readonly string _connectionString;
        public DbConnectionProvider(IOptions<ConnectionStrings> connection)
        {
            _connectionString = connection.Value.DefaultConnection;
        }

        public IDbConnection GetConnection()
        {
            if (_connection == null || _connection.State != ConnectionState.Open)
            {
                _connection = new NpgsqlConnection(_connectionString);
                _connection.Open();
            }
            return _connection;
        }

        public void Dispose()
        {
            if(_connection != null)
            {
                _connection.Dispose();
                _connection = null;
            }
        }


    }
}

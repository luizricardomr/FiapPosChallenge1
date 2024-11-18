namespace FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure.Query
{
    public static class Query
    {

        public static string ListDDD(int? id = null)
        {
            string query = "SELECT * FROM ddd a";

            if (id.HasValue)
            {
                query += @" WHERE a.Id = @Id";
            }
            return query;
        }

        public static string GetContatoByDDD(int id)
        {
            string query = "SELECT * FROM contato  where idddd = @Id";
            return query;
        }
    }
}

namespace FIAP.NET.Grupo13.CadastroDeContatos.Service
{
    public interface ICacheService
    {
        object Get(string key);

        void Set(string key, object content);

        void Remove(string key);
    }

}

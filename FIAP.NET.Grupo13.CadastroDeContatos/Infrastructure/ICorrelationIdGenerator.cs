namespace FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure
{
    public interface ICorrelationIdGenerator
    {
        string Get();
        void Set(string correlationId);
    }
}

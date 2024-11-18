namespace FIAP.NET.Grupo13.CadastroDeContatos.Infrastructure
{
    public class BaseLogger<T>
    {
        protected readonly ILogger<T> _logger;
        protected readonly ICorrelationIdGenerator _correlationId;
        public BaseLogger(ILogger<T> logger, 
                          ICorrelationIdGenerator correlationId = null)
        {
            _logger = logger;
            _correlationId = correlationId;
        }
        public virtual void LogInformation(string message)
        {
            _logger.LogInformation($"[CorrelationId: {_correlationId.Get()}]{message}");
        }

        public virtual void LogError(string message)
        {
            _logger.LogInformation($"[CorrelationId: {_correlationId.Get()}]{message}");
        }

        public virtual void LogWarning(string message)
        {
            _logger.LogInformation($"[CorrelationId: {_correlationId.Get()}]{message}");
        }

    }
}

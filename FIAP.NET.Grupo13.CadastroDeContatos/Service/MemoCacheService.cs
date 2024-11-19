using Microsoft.Extensions.Caching.Memory;

namespace FIAP.NET.Grupo13.CadastroDeContatos.Service
{
    public class MemoCacheService: ICacheService
    {
        private readonly IMemoryCache _cache;

        public MemoCacheService(IMemoryCache cache)
        {
            _cache = cache;
        }

        public object? Get(string key) => _cache.TryGetValue(key, out var cachedValue) ? cachedValue : null;

        public void Remove(string key) => _cache.Remove(key);

        public void Set(string key, object content) => _cache.Set(key, content, TimeSpan.FromMinutes(10));
    }
}

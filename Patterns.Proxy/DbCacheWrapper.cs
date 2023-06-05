namespace Patterns.Proxy
{
    internal class DbCacheWrapper : IDbAccessor
    {
        private readonly IDbAccessor _dbAccessor;
        private readonly Dictionary<string, string> _inMemStorage;

        // Wrapping actual dbAccessor
        public DbCacheWrapper(IDbAccessor dbAccessor)
        {
            _dbAccessor = dbAccessor;
            _inMemStorage = new();
        }

        public string GetValue(string key)
        {
            if (_inMemStorage.ContainsKey(key))
            {
                return _inMemStorage[key];
            }

            var value = _dbAccessor.GetValue(key);

            _inMemStorage[key] = value;

            return value;
        }
    }
}

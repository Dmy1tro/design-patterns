namespace Patterns.Proxy;

internal class Example
{
    public static void Run()
    {
        IDbAccessor dbAccessor = new DbAccessor();
        IDbAccessor dbCacheWrapper = new DbCacheWrapper(dbAccessor);

        // First call fetch value from db.
        dbCacheWrapper.GetValue("qwerty");

        // Second call fetch value from cache.
        dbCacheWrapper.GetValue("qwerty");
    }
}

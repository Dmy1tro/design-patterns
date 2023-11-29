namespace Patterns.Proxy;

internal interface IDbAccessor
{
    string GetValue(string key);
}

namespace Patterns.Proxy
{
    internal class DbAccessor : IDbAccessor
    {
        public string GetValue(string key)
        {
            // emulating long and heavy db call.
            Task.Delay(3_000).GetAwaiter().GetResult();

            // no logic here, just return something.
            return $"{key}_{key}_{key}";
        }
    }
}

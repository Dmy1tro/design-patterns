using System.Diagnostics;
using Patterns.Decorator.Handlers;

namespace Patterns.Decorator.Decorators;

internal class LoggerDecorator : IHandler
{
    private readonly IHandler _handler;

    public LoggerDecorator(IHandler handler)
    {
        _handler = handler;
    }

    public int Handle()
    {
        var sw = Stopwatch.StartNew();
        var result =  _handler.Handle();
        sw.Stop();

        Console.WriteLine($"Executing done with time {sw.ElapsedMilliseconds} ms.");

        return result;
    }
}

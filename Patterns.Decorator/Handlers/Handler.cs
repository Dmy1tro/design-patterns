using Patterns.Decorator.Decorators;

namespace Patterns.Decorator.Handlers;

interface IHandler
{
    int Handle();
}

internal class Handler : IHandler
{
    public int Handle()
    {
        return 1;
    }

    public void Example()
    {
        var handler = new Handler();

        var exceptionDecorator = new ExceptionHandlerDecorator(handler);
        var loggerDecorator = new LoggerDecorator(exceptionDecorator);

        exceptionDecorator.Handle();
    }
}

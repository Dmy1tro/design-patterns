using Patterns.Decorator.Handlers;

namespace Patterns.Decorator.Decorators;

internal class ExceptionHandlerDecorator : IHandler
{
    private readonly IHandler _handler;

    public ExceptionHandlerDecorator(IHandler handler)
    {
        _handler = handler;
    }

    public int Handle()
    {
        try
        {
            return _handler.Handle();
        }
        catch (ArgumentNullException ex)
        {
            // Handle different types of error
        }
        catch (IndexOutOfRangeException ex)
        {

        }
        catch (Exception ex)
        {

        }
        finally
        {
        }

        return -1;
    }
}

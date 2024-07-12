using Journey.Exception.ExceptionsBase;

public abstract class NotFoundException : JourneyException
{
    public NotFoundException(string message) : base(message)
    {

    }
}


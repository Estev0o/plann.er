using Journey.Exception.ExceptionsBase;
using System.Net;

public class NotFoundException : JourneyException
{
    public NotFoundException(string errorMessage) : base(errorMessage)
    {
    }

    public override IList<string> GetErrorMessage()
    {
        return new List<string> { Message };
    }

    public override HttpStatusCode GetStatusCode()
    {
        return HttpStatusCode.NotFound;
    }
}

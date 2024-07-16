namespace Journey.Communication.Responses
{
    public class ResponseErrorsJson
    {
        public IList<string> Errors { get; set; } = new List<string>();

        public ResponseErrorsJson(IList<string> errors)
        {
            Errors = errors;
        }
    }
}

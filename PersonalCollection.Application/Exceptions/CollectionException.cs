namespace PersonalCollection.Application.Exceptions;
public class CollectionException : Exception
{
    public int StatusCode { get; set; }

    public CollectionException(int code, string message) : base(message)
    {
        StatusCode = code;
    }
}

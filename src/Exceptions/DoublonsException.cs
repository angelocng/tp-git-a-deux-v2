public class DoublonsException : Exception
{
    public DoublonsException() : base(){
        
    }

    public DoublonsException(string message) : base(message)
    {

    }

    public DoublonsException(string message, Exception innerException) : base(message, innerException)
    {

    }
}

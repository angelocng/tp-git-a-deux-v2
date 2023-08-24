namespace src.Exceptions 
{
    class InvalidPersonException : Exception 
    {
        public InvalidPersonException() : base() { }
        public InvalidPersonException(string message) : base(message) { }
        public InvalidPersonException(string message, Exception inner) : base(message, inner) { }
    }
}
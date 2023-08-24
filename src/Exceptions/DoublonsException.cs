namespace src
{
    public class DoublonsException : Exception
    {
        public DoublonsException() : base("Cette personne existe déjà !"){
            
        }

        public DoublonsException(string message) : base(message)
        {

        }

        public DoublonsException(string message, Exception innerException) : base(message, innerException)
        {

        }
    }
}

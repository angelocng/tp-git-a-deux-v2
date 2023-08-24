namespace src
{
    [Serializable]
    public class MoreThanTenRegisteredPerson : Exception 
    { 
        public MoreThanTenRegisteredPerson(){}
        public MoreThanTenRegisteredPerson(string message) : base (message)
        {

        }

        public MoreThanTenRegisteredPerson(string message, Exception inner) : base (message, inner){}
    }
}
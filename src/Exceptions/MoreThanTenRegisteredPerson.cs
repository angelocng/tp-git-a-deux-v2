namespace src
{
    [Serializable]
    public class MoreThanTenRegisteredPerson : Exception 
    { 
        private string personName { get; set; }
        public MoreThanTenRegisteredPerson(){}
        public MoreThanTenRegisteredPerson(string message) : base (message)
        {

        }

        public MoreThanTenRegisteredPerson(string message, Exception inner) : base (message, inner){}

        public MoreThanTenRegisteredPerson(string message, string personName) : this (message)
        {
            this.personName = personName;
        }
    }
}
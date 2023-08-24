[Serializable]
public class MoreThanTenRegisteredPerson : Exception 
{ 
    private string PersonName {get;}
    public MoreThanTenRegisteredPerson(){}
    public MoreThanTenRegisteredPerson(string message) : base (message){}

    public MoreThanTenRegisteredPerson(string message, Exception inner) : base (message, inner){}

    public MoreThanTenRegisteredPerson(string message, string personName) : this (message)
    {
        PersonName = personName;
    }
}
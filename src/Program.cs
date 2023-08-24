using System;
using src;
using System.Text.Json;

Person myPerson;
PeopleContainer peopleContainer = new PeopleContainer();
peopleContainer.AddPerson(new Person ("Marcel","Cerdan"));
peopleContainer.AddPerson(new Person("Jackie","Hicx"));
peopleContainer.AddPerson(new Person("James", "Dean"));
string? FirstnameUser;
string? LastnameUser;

do
{
Console.WriteLine("Veuillez saisir votre nom et votre prenom svp.");



LastnameUser = Console.ReadLine();


    if(LastnameUser!="q")
    {
        FirstnameUser = Console.ReadLine();
        myPerson = new Person(LastnameUser,FirstnameUser);
        string myPersonString = myPerson.ToString();
        Console.WriteLine(myPersonString);
        try 
        {
            peopleContainer.AddPerson(myPerson);
        } catch(DoublonsException ex) 
        {
            Console.WriteLine(ex.Message);
            // TODO:  LOGGER l'erreur !
        }

        
        // Si constructeur non implémenté
        // peopleContainer.AddPerson(new Person() { Lastname = LastnameUser, Firstname = FirstnameUser});
    }

}
while (LastnameUser != "q");
string myPeopleString = peopleContainer.ToString();
Console.WriteLine(myPeopleString);

peopleContainer.SortByLastName();
Console.WriteLine(peopleContainer.ToString());

peopleContainer.SortByFirstName();
Console.WriteLine(peopleContainer.ToString());

string jsonString = JsonSerializer.Serialize(peopleContainer.SortByFirstName());

File.WriteAllText("MonFichier.json", jsonString);

Console.WriteLine("Programme terminé, appuyez sur n'importe quelle touche pour quitter !");
Console.ReadLine();


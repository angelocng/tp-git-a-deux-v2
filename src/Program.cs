using System;
using src;

//niveau etape 3
// Console.WriteLine("Veuillez saisir votre nom et votre prenom svp.");
// string FirstnameUser = Console.ReadLine();
// string LastnameUser = Console.ReadLine();
//Console.WriteLine(FirstnameUser +" "+  LastnameUser);

//niveau etape 4
// Person myPerson = new Person();
// myPerson.Firstname = FirstnameUser;
// myPerson.Lastname = LastnameUser;
// string myPersonString = myPerson.ToString();
// Console.WriteLine(myPersonString);

//niveau etape 6
// PeopleContainer peopleContainer = new PeopleContainer();

// peopleContainer.AddPerson(myPerson);
// string myPeopleString = peopleContainer.ToString();
// Console.WriteLine(myPeopleString);

//niveau etape 7
Person myPerson = new Person();
PeopleContainer peopleContainer = new PeopleContainer();
string FirstnameUser;
string LastnameUser;
do
{
Console.WriteLine("Veuillez saisir votre nom et votre prenom svp.");
LastnameUser = Console.ReadLine();
FirstnameUser = Console.ReadLine();


if(
    // FirstnameUser !="q"
    // ||
    LastnameUser!="q"
    )
{
string myPersonString = myPerson.ToString();
Console.WriteLine(myPersonString);
// Si constructeur non implémenté
// peopleContainer.AddPerson(new Person() { Lastname = LastnameUser, Firstname = FirstnameUser});
peopleContainer.AddPerson(new Person(LastnameUser,FirstnameUser));
}

}
while
(
    // FirstnameUser != "q" 
    // || 
    LastnameUser != "q"
);
string myPeopleString = peopleContainer.ToString();
Console.WriteLine(myPeopleString);







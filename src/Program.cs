﻿using System;
using src;
using System.Text.Json;

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


    if(
        LastnameUser!="q"
        )
    {
        FirstnameUser = Console.ReadLine();
        myPerson = new Person(LastnameUser,FirstnameUser);
        string myPersonString = myPerson.ToString();
        Console.WriteLine(myPersonString);
        peopleContainer.AddPerson(myPerson);

        // Si constructeur non implémenté
        // peopleContainer.AddPerson(new Person() { Lastname = LastnameUser, Firstname = FirstnameUser});
    }

}
while
(
    LastnameUser != "q"
);
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


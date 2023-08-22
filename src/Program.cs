using System;
using src;

Console.WriteLine("Veuillez saisir votre nom et votre prenom svp.");
string FirstnameUser = Console.ReadLine();
string LastnameUser = Console.ReadLine();
Console.WriteLine(FirstnameUser +" "+  LastnameUser);

Person myPerson = new Person();
myPerson.Firstname = FirstnameUser;
myPerson.Lastname = LastnameUser;
myPerson.ToString();

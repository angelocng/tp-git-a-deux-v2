using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class PeopleContainer : IPersonContainer
    {
        private List<Person> myListPerson;

        public PeopleContainer(){
            myListPerson = new List<Person>();
        }

        public List<Person> SortByLastName()
        {
           myListPerson = myListPerson.OrderBy(person=> person.Lastname).ToList();
           return myListPerson; 
        }

        public List<Person> SortByFirstName()
        {
           myListPerson = myListPerson.OrderBy(person=> person.Firstname).ToList();
           return myListPerson; 
        }

        // Convertir cette méthode pour gérer les erreurs
        // 1. Vérifier que _person n'est pas null et gérer l'exception
        // 2. doublon avec une Exception
        public bool AddPerson(Person _person){

            Person? person = myListPerson.FirstOrDefault(p => p.Lastname == _person.Lastname && p.Firstname == _person.Firstname);

            if(person is Person myPerson) {
                return false;
            }
            else {
                myListPerson.Add(_person);
                return true;
            }
        }

        public override string ToString()
        {
            string myString = "Your list contain : \n";
            foreach(Person person in myListPerson){
                myString += person.ToString()+"\n";
            }
            return myString;
        }

        
    }
}

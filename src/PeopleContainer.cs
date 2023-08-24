using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using src.Exceptions;

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
        public void AddPerson(Person _person){

            if(_person==null)
            {
                throw new InvalidPersonException();
            }
            else
            {
                Person? person = myListPerson.FirstOrDefault(p => p.Lastname == _person.Lastname && p.Firstname == _person.Firstname);

                if(person is Person myPerson) 
                {

                }
                else if(myListPerson.Count()>=10)
                {
                     throw new MoreThanTenRegisteredPerson("Il y a déjà 10 utilisateurs enregistrés, merci de contacter le service informatique.");
                }
                }
                else
                {
                    myListPerson.Add(_person);
                }  
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

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

        public bool AddPerson(Person _person){

            Person? person = myListPerson.FirstOrDefault(p => p.Lastname == _person.Lastname && p.Firstname == _person.Firstname);

            if(person is Person) {
                return false;
            }
            else {
                if(myListPerson.Count()<10)
                {
                    myListPerson.Add(_person);
                    return true;
                }
                else
                {
                    throw new MoreThanTenRegisteredPerson("Il y a déjà 10 utilisateurs enregistrés, merci de contacter le service informatique.");
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

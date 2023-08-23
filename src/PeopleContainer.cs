using System;
using System.Collections.Generic;
using System.Linq;
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
           List<Person> people = myListPerson.OrderBy(person=> person.Lastname).ToList();
           return people; 
        }

        public List<Person> SortByFirstName()
        {
           List<Person> people = myListPerson.OrderBy(person=> person.Firstname).ToList();
           return people; 
        }

        public void AddPerson(Person _person){
            myListPerson.Add(_person);
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

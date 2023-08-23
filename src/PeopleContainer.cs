using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class PeopleContainer : IPersonContainer
    {
        private List<Person> myListPerson = new List<Person>();

        public PeopleContainer(List<Person> _myListPerson)
        {
            this.myListPerson = _myListPerson;
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
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    // gérer le format du nom et prénom avec Exceptions
    public class Person
    {
        private string _lastname;
        private string _firstname;

        public string? Firstname { get { return _firstname; } set { _firstname = value; } }
        public string? Lastname { get { return _lastname; } set { _lastname = value; } }

        public Person(){}
        public Person(string? _firstname, string? _lastname){
            this.Firstname = _firstname;
            this.Lastname = _lastname;
        }
        public override string ToString(){
            return $"Your lastname is {Lastname} and your firstname is {Firstname}";
        }
    }
}

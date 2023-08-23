using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Person
    {

        public string Firstname{ get ; set; }
        public string Lastname { get ; set; }

        public Person(){}
        public Person(string _firstname, string _lastname){
            this.Firstname = _firstname;
            this.Lastname = _lastname;
        }
        public override string ToString(){
            return $"Your lastname is {Lastname} and your firstname is {Firstname}";
        }
    }
}

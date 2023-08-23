using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src
{
    public class Person
    {
        private string firstname;
        private string lastname;

        public string Firstname{ get ; set; }
        public string Lastname { get ; set; }

        public override string ToString(){
            return $"Your lastname is {Lastname} and your firstname is {Firstname}";
        }
    }
}

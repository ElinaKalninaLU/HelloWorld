using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class Customer
    {
        public Customer(string n, string s)
        {
            Name = n;
            Surname = s;
        }
        public string Name { get; set; }
        public string Surname { get; set; }

        public string FullName { get {
                return Name +" " + Surname; 
            } }
    }
}

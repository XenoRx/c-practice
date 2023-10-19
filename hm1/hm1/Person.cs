using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gb_OOP
{
    internal class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public List<Person> Children { get; set; }
        public Person Spouse { get; set; }
        
        public Person(string name, Gender gender)
        {
            Name = name;
            this.Gender = gender;
            Children = new List<Person>();
        }
    }
}

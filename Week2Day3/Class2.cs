using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //protected vuol dire che non puoi accedere a questa variabile al di fuori dalla classe 
        //se non con un metodo get
        protected int Age { get; set; }

        public int MyProperty { get; set; }
        public Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        
        public Person(string firstname, string lastname, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            Age = age;
        }
        public void GetFullName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(FirstName + " " + LastName + " " + Age);
        }
    }
}

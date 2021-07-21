using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Day3
{
    class Employer : Person //employ eredita da person
    {
        //eredita FirstName e LastName

        public RoleEnum Role { get; set; }
        public new int MyProperty { get; set; }
        public Employer()
        {
          
        }
        public Employer(string firstName, string lastName, RoleEnum role)
       :base(firstName, lastName)
        {
            Role = role;
        }

        public Employer (string firstName, string lastName, RoleEnum role, int age)
        :base(firstName, lastName, age)
        {
            Role = role;
        }

        public override void PrintInfo()
        {
            //Console.WriteLine(FirstName + " " + LastName + " " + Age + " " + Role);
           //posso richiamere il metodo della classe base con la keyword base
            base.PrintInfo();
            Console.WriteLine(" " + Role);
        }
    }

    public enum RoleEnum
    {
        Techincian,
        Manager

    }
}

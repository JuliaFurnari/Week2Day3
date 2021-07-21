using System;

namespace Week2Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Mario", "Rossi");
            Employer e = new Employer("Mario", "Rossi", RoleEnum.Manager);
            Person p2 = new Person();
            p2.FirstName = "Marco";
            p2.LastName = "Verdi";

            Employer e2 = new Employer();
            e2.FirstName = "Sara";
            e2.LastName = "Bianchi";
            e2.Role = RoleEnum.Techincian;
            e2.GetFullName();

            Console.WriteLine("PrintInfo su person");
            p1.PrintInfo();

            Console.WriteLine("PrintInfo su employer");
            e2.PrintInfo();

        }
     
    }
}

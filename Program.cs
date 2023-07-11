using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ID;
            string empName;
            string gender;
            double salary;
            DateTime doj;
            Console.WriteLine("ENter ID");
            ID= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter EmployeeName");
            empName = Console.ReadLine();
            Console.WriteLine("Enter Gender");
            gender = Console.ReadLine();
            Console.WriteLine("Enter salary");
            salary=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter date of joining");
            doj = DateTime.Parse(Console.ReadLine());
            if(salary>90000)
            {
                Console.WriteLine("you have to pay 30% tax");
            }
            else
            {
                Console.WriteLine("tax will be 15%");
            }

            Console.ReadKey();

        }
    }
}

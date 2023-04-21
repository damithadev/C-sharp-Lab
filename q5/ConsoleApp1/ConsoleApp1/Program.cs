using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee ID: ");
            int IDFromUser = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name: ");
            string empNameFromUser = Console.ReadLine();

            Console.WriteLine("Enter Employee Desgination: ");
            string empDesgFromUser = Console.ReadLine();

            Employee obj = new Employee();

            obj.setEmpID(IDFromUser);
            obj.setEmpName(empNameFromUser);
            obj.setEmpDesg(empDesgFromUser);

            Console.WriteLine("Hello, " + obj.getName() + " your empoyee ID is " + obj.getEmpID() + " and you are a " + obj.getEmpDesg()) ;
           
            Console.ReadKey();
        }
    }
}

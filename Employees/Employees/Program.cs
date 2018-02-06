using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            Salesperson fred = new Salesperson();
            fred.Age = 31;
            fred.Name = "Fred";
            fred.SalesNumber = 50;

            fred.DisplayStats();
            Console.WriteLine("\n***************\n");
            //Предположим, что у Manager есть конструктор со следующей сигнатурой 
            // (string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            Manager chucky = new Manager("Chucky", 50, 92, 1000000, "333-23-2322", 9000);
            chucky.DisplayStats();
            Console.ReadLine();
          
        }
    }
}

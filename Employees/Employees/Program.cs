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
            Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            // Создание и использование открытого внутреннего класса. Все ОК!
            OuterClass.PublicInnerClass inner;
            inner = new OuterClass.PublicInnerClass();
            // Ошибка компиляции! Нет доступа к приватному классу.
           // OuterClass.PrivateInnerClass inner2;
           // inner2 = new OuterClass.PrivateInnerClass();
        



        Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            Salesperson fred = new Salesperson("Fred",43,93,3000,"932-32-3232",31);
            /* fred.Age = 31;
             fred.Name = "Fred";
             fred.SalesNumber = 50;
             fred.ID = 777;
             fred.SocialSecurityNumber = "123";*/
            fred.GiveBonus(200);
            fred.DisplayStats();
            
            Console.WriteLine("\n***************\n");
            //Предположим, что у Manager есть конструктор со следующей сигнатурой 
            // (string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            //Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            Employee cost = new Employee("Chucky", 50, 92, 1000000, "333-23-2322");
            double cost1 = cost.GetBenefitCost();
            cost.GiveBonus(300);

            cost.DisplayStats();
            Console.WriteLine(cost1);
            PTSalesPerson A = new PTSalesPerson("A", 20, 90, 50000, "123-23-22", "fsdfdf",  5 ,12);

            Console.WriteLine("\n***************\n");
            A.DisplayStats();


            Console.ReadLine();
          
        }
    }
}

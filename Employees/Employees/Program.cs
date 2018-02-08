using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{

    class Program
    {
        static void CastingExamples()
        {
            object frank = new Manager("Frank Zappa", 9, 300, 4000, "111-11-1111", 5);
            GivePromotion((Manager)frank);
            Employee moonUnit = new Manager("MoonUnit Zappa", 2, 3001, 20000, "101-11-1321", 1);
            GivePromotion(moonUnit);

            Salesperson jill = new PTSalesPerson("Jill", 834, 3002, 10000, "111-12-1119", "12321324", 90, 5);
            GivePromotion(jill);

        }
        static void GivePromotion(Employee emp)
        {
            Console.WriteLine("{0} was promoted!", emp.Name);
        }
        static void Main(string[] args)
        {
            CastingExamples();

          /*  Employee.BenefitPackage.BenefitPackageLevel myBenefitLevel = Employee.BenefitPackage.BenefitPackageLevel.Platinum;
            // Создание и использование открытого внутреннего класса. Все ОК!
            OuterClass.PublicInnerClass inner;
            inner = new OuterClass.PublicInnerClass();
            // Ошибка компиляции! Нет доступа к приватному классу.
           // OuterClass.PrivateInnerClass inner2;
           // inner2 = new OuterClass.PrivateInnerClass();
        



        Console.WriteLine("***** The Employee Class Hierarchy *****\n");
            Salesperson fred = new Salesperson("Fred",43,93,3000,"932-32-3232",31);
            fred.GiveBonus(200);
            fred.DisplayStats();
            
            Console.WriteLine("\n***************\n");
            //Предположим, что у Manager есть конструктор со следующей сигнатурой 
            // (string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts)
            Manager chucky = new Manager("Chucky", 50, 92, 100000, "333-23-2322", 9000);
            //Employee cost = new Employee("Chucky", 50, 92, 1000000, "333-23-2322");
            //double cost1 = cost.GetBenefitCost();
            chucky.GiveBonus(300);
            chucky.DisplayStats();
            //Console.WriteLine(cost1);

            PTSalesPerson A = new PTSalesPerson("A", 20, 90, 50000, "123-23-22", "fsdfdf",  5 ,12);

            Console.WriteLine("\n***************\n");
            A.DisplayStats();

  */
            Console.ReadLine();
        
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{

    abstract partial class Employee
    {
        
        public virtual void GiveBonus(float amount)
        {
            Pay += amount;
        }
        public  class BenefitPackage
        {
            public double ComputePayDeduction() { return 125.0; }
            public enum BenefitPackageLevel
            {
                Standard, Gold, Platinum
            }
        }
        //Содержит объект BenefitPackage
        protected BenefitPackage empBenefits = new BenefitPackage();

        //Открывает некоторое поведение, связанное с включенным объектом
        public double GetBenefitCost ()
        {
            return empBenefits.ComputePayDeduction();
        }
        //Открывет объект через специальное свойство
        public BenefitPackage Benefits
        {
            get { return empBenefits; }
            set { empBenefits = value; }
        }

        public int Age
        {
            get{return empAge;}
            set {empAge = value;}
        }
        //Свойства
        public string Name
        {
            get{return empName;}
            set{if (value.Length > 15){
                    Console.WriteLine("Error! Name must be less than 16 characters!");}
                else{empName = value;}
            }
        }
        //М.б. бы добавить доп. бизнес-правила для установки этих свойств, но нет необходимости
        public int ID
        {
            get{return empID;}
            set{empID = value;}
        }

        public float Pay
        {
            get{return currPay;}
            set{currPay = value;}
        }
               
        //Методы
        public string GetName()
        {
            return empName;
        }
        public void SetName(string name)
        {
            //Перед присваиванием проверить входное значение
            if (name.Length > 15)
            {
                //Ошибка!
                Console.WriteLine("Error! Name must be less than 16 characters!");
            }
            else
            {
                empName = name;
            }
        }
       
        public string SocialSecurityNumber
        {
            get
            {
                return empSSN;
            }
            set
            {
                empSSN = value;
            }
        }

        

        //Обновленный метод DisplayStats() 
        public virtual void DisplayStats ()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
            Console.WriteLine("SSN: {0}", empSSN);


        }
     
    }
    class Manager : Employee
    {
        public override void GiveBonus(float amount) { 
     Random r = new Random();
     StockOptions += r.Next(500);
   }
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empID, float currPay, string empSSN, int numbOfOpts) : base (fullName, age, empID, currPay)
        {
            //Это свойство определено в классе Manager
            this.StockOptions = numbOfOpts;
        }   
        public Manager() { }
        public override void DisplayStats()
        {
         base.DisplayStats();
            Console.WriteLine("Number of stock options: {0}", StockOptions);
        }
    }

    class Salesperson : Employee
    {
        public override sealed void GiveBonus(float amount)
        {
            int salesBonus = 0;
            if (SalesNumber >= 0 && SalesNumber <= 100)
                salesBonus = 10;
            else
            {
                if (SalesNumber >= 101 && SalesNumber <= 200)
                    salesBonus = 15;
                else
                    salesBonus = 20;
            }
            base.GiveBonus(amount * salesBonus);
          }
        

        public int SalesNumber { get; set; }
        public Salesperson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) : base (fullName, age, empID, currPay, ssn)
        {
            this.SalesNumber = numbOfSales;
        }

        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("SalesNumber: {0}", SalesNumber);
        }
        public Salesperson() { }
    }

    sealed class PTSalesPerson : Salesperson
    {
        public int WorkTime { get; set; }

        public PTSalesPerson(string fullName, int age, int empID, float currPay, string ssn,  string empSSN, int numbOfSales,int TimeWork) : base(fullName, age, empID, currPay, empSSN, numbOfSales)
        {
             this.WorkTime = TimeWork;
         }
       
        public override void DisplayStats()
        {
            base.DisplayStats();
            Console.WriteLine("WorkTime: {0}", WorkTime);
        }
        public PTSalesPerson() { }
    }

    
 
    public class OuterClass
        {
            // Открытый вложенный тип могут использовать все.
            public class PublicInnerClass { }
            // Приватный вложенный тип могут использовать только члены
            // содержащего его класса.
            private class PrivateInnerClass { }
        }
   
}

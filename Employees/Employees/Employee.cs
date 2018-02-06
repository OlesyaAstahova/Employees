using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    partial class Employee
    {
       
        public int Age
        {
            get
            {
                return empAge;
            }
            set
            {
                empAge = value;
            }
        }


        //Свойства
        public string Name
        {
            get
            {
                return empName;
            }
            set
            {
                if (value.Length > 15)
                {
                    Console.WriteLine("Error! Name must be less than 16 characters!");
                }
                else
                {
                    empName = value;
                }
            }
        }

        //М.б. бы добавить доп. бизнес-правила для установки этих свойств, но нет необходимости
        public int ID
        {
            get
            {
                return empID;
            }
            set
            {
                empID = value;
            }
        }

        public float Pay
        {
            get
            {
                return currPay;
            }
            set
            {
                currPay = value;
            }
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
        public void GiveBonus (float amount)
        {
            Pay += amount;
        }

        public string SocialSecurityNumber
        {
            get
            {
                return empSSN;
            }
        }
        //Обновленный метод DisplayStats() 
        public void DisplayStats ()
        {
            Console.WriteLine("Name: {0}", Name);
            Console.WriteLine("ID: {0}", ID);
            Console.WriteLine("Age: {0}", Age);
            Console.WriteLine("Pay: {0}", Pay);
        }
     
    }
    class Manager : Employee
    {
        public int StockOptions { get; set; }

        public Manager(string fullName, int age, int empID, float currPay, string ssn, int numbOfOpts) : base (fullName, age, empID, currPay, ssn)
        {
            //Это свойство определено в классе Manager
            StockOptions = numbOfOpts;
            //Присвоить входные параметры, используя унаследованные свойства родительского класса
            /*
            ID = empID;
            Age = age;
            Name = fullName;
            Pay = currPay;*/
            //Ошибка компиляции,т.к. свойство доступно только для чтения
           // SocialSecurityNumber = ssn;
        }
        public Manager() { }
    } 
    // В качестве общего правила, все подклассы должны явно вызвать соответствующий конструктор базового класса
    class Salesperson : Employee
    {
        public int SalesNumber { get; set; }
        public Salesperson(string fullName, int age, int empID, float currPay, string ssn, int numbOfSales) : base(fullName, age, empID, currPay, ssn)
        {
            SalesNumber = numbOfSales;
        }
        public Salesperson() { }
    }
}

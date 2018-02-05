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
        public int StockOptiona { get; set; }
    } 
    class Salesperson : Employee
    {
        public int SalesNumber { get; set; }
    }
}

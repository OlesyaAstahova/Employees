using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
   partial class Employee
    {
        //Поля данных
        protected string empName;
        protected int empID;
        protected string empSSN;
        protected float currPay;
        protected int empAge;

        //Обновленные конструкторы
        public Employee() { }
        public Employee(string name, int age, int id, float pay)
            : this(name, 20, id, pay, "Только для чтения") { }

        public Employee(string name, int age, int id, float pay, string ssn)
        {
            Name = name;
            ID = id;
            Age = age;
            Pay = pay;
            empSSN = ssn;

        }

    }
}

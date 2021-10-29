using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap6_Ex2_Lists
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

        public void IncreaseSalary(double percentage)
        {
            Salary = Salary * (1 + percentage / 100);
        }

        public override string ToString()
        {
            return (Id.ToString() + ", " + Name + ", " + Salary.ToString());
        }
    }
}

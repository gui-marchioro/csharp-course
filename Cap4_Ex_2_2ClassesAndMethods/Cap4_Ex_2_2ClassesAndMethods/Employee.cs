using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cap4_Ex_2_2ClassesAndMethods
{
    class Employee
    {
        public string name;
        public double wage;
        public double tax;

        public double LiquidWage()
        {
            return (wage - tax);
        }
        public void RaiseWage(double percent)
        {
            wage = wage * (1 + percent/100);
        }
        public override string ToString()
        {
            return String.Format("Employee: " + name + ", $" + LiquidWage().ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

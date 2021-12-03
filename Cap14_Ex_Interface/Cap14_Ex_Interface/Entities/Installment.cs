using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap14_Ex_Interface.Entities
{
    class Installment
    {
        public DateTime DueDate { get; set; }
        public double Value { get; set; }

        public Installment(DateTime dueDate, double value)
        {
            DueDate = dueDate;
            Value = value;
        }
    }
}

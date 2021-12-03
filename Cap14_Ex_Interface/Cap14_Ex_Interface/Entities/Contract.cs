using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap14_Ex_Interface.Entities
{
    class Contract
    {
        public List<Installment> installments;
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double Value { get; set; }

        public Contract(int number, DateTime date, double value)
        {
            Number = number;
            Date = date;
            Value = value;
            installments = new List<Installment>();
        }

        public void ShowInstallments()
        {
            Console.WriteLine("Installments:");
            foreach(Installment installment in installments)
            {
                Console.WriteLine(installment.DueDate + " - " + installment.Value);
            }
        }
    }
}

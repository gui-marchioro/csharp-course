using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap10_Ex1_InheritancePolymorfism.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            return (Name + " $ " + TotalPrice().ToString() + " (Customs Fee: $ " + CustomsFee);
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}

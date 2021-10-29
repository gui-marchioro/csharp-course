using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cap4_Ex1_3StaticMethods
{
    class MoneyCurrency
    {
        public static double iof = 6.0;

        public static double CurrencyExchange(double dollarCurrency, double dollarsQuantity)
        {
            return dollarCurrency * dollarsQuantity * (1 + iof/100);
        }
    }
}

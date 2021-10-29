using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Cap5_Ex_ConstructorsAndProperties
{
    class BankAccount
    {
        public const double fee = 5.0;

        private double _balance;

        public int Number { get; private set; }
        public string Owner { get; set; }       

        public BankAccount(int number, string owner)
        {
            Number = number;
            Owner = owner;
        }
        public BankAccount(int number, string owner, double initialDeposit) : this(number, owner)
        {
            Deposit(initialDeposit);
        }

        public double Balance
        {
            get { return _balance; }
        }

        public void Deposit(double value)
        {
            _balance += value;
        }
        public void Withdraw(double value)
        {
            _balance -= (value + fee);
        }
        public override string ToString()
        {
            return ("Account: " + Number.ToString() +
                ", Owner: " + Owner +
                ", Balance: $ " + Balance.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

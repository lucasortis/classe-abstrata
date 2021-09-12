using System;
using System.Globalization;
using System.Collections.Generic;
using HerancaEPolimorfismo.Entities;

namespace HerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Account> accounts = new List<Account>();

            accounts.Add(new BusinessAccount(1001, "Alex", 2000.0, 25000));
            accounts.Add(new SavingsAccount(1002, "Lucas", 2000.0, 0.01));
            accounts.Add(new BusinessAccount(1003, "Bianca", 2000.0, 25000));
            accounts.Add(new SavingsAccount(1004, "Allan", 2000.0, 0.01));

            double sum = 0;

            foreach(Account acc in accounts)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

            foreach(Account acc in accounts)
            {
                acc.Withdraw(10.00);
                Console.WriteLine(acc.Number + " Balance: $ " + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }

            

        }
    }
}

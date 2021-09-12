using System;
using HerancaEPolimorfismo.Entities;

namespace HerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Herança
            BusinessAccount acc1 = new BusinessAccount(200, 3401, "Lucas Ortis", 2000);

            Console.WriteLine(acc1.Balance);

            //Upcasting

            SavingsAccount acc2 = new SavingsAccount(10, "Alex", 2000, 0.05);
            acc2.UpdateBalance();
            Console.WriteLine(acc2.Balance);
            Account acc3 = acc2;
            Console.WriteLine(acc3.Balance);
            Account acc4 = new BusinessAccount(3, 2122, "Ana", 3000);

            //Downcasting

            BusinessAccount acc5 = (BusinessAccount)acc4;
            acc5.Loan(100.0);

            //BusinessAccount acc6 = (BusinessAccount)acc3;
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc6 = acc3 as BusinessAccount;
                acc6.Loan(200.0);
                Console.WriteLine("Loan!");
            }

            if(acc3 is SavingsAccount)
            {
                SavingsAccount acc6 = acc3 as SavingsAccount;
                acc6.UpdateBalance();
                Console.WriteLine("Update");
            }

            //sobrescrita
            Account accTesteSobrescrita = new Account(1001, "João", 500.0);
            Account accTesteSobrescrita2 = new SavingsAccount(1002, "Anna", 500.0, 0.01);

            accTesteSobrescrita.Withdraw(10);
            accTesteSobrescrita2.Withdraw(10);

            Console.WriteLine("João's balance: " + accTesteSobrescrita.Balance);
            Console.WriteLine("Ana's balance: " + accTesteSobrescrita2.Balance);        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bAccount
{
    class BankAccount
    {
        public int Accountnumber;
        public double balance;
        public void deposit(double amount)
        {
            balance = balance + amount;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount acc1 = new BankAccount();

            Console.WriteLine("Enter your Bank Account");
            acc1.Accountnumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the amount to deposit");
            double amount = double.Parse(Console.ReadLine());

            acc1.deposit(amount);

            Console.WriteLine($"{acc1.Accountnumber} your balance : {acc1.balance}");
            Console.ReadLine();


        }
    }
}


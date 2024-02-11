using System;

namespace sATM
{
    internal class Program
    {
        public static int balance = 0;

        static void Main(string[] args)
        {
            bool status = true;

            while (status)
            {
                Console.WriteLine("Select option to perform");
                Console.WriteLine("1. Check the balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");

                // Declare the operation variable inside the loop
                int operation = int.Parse(Console.ReadLine());

                int amount = 0;
                int result = 0;

                switch (operation)
                {
                    case 1:
                        Console.WriteLine($"Account balance: {balance}");
                        break;

                    case 2:
                        Console.WriteLine("Enter amount to deposit");
                        amount = int.Parse(Console.ReadLine());
                        if (amount % 100 == 0)
                        {
                            result = deposit(amount);
                            Console.WriteLine($"New account balance: {result}");
                        }
                        else
                        {
                            Console.WriteLine("You should deposit an amount which is multiple of 100");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Enter amount to withdraw");
                        amount = int.Parse(Console.ReadLine());
                        if (amount % 100 == 0)
                        {
                            if (balance >= amount)
                            {
                                result = withdraw(amount);
                                Console.WriteLine($"New account balance: {result}");
                            }
                            else if (balance == 0 || balance < amount)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter amount which is a multiple of 100");
                        }
                        break;

                    case 4:
                        status = false;
                        Console.WriteLine("Thank you");
                        break;

                    default:
                        Console.WriteLine("Invalid option. Please choose a valid option.");
                        break;
                }
            }
            Console.ReadLine(); 
        }

        static int deposit(int amount)
        {
            balance = balance + amount;
            return balance;
        }

        static int withdraw(int amount)
        {
            balance = balance - amount;
            return balance;
        }
    }
}
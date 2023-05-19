using System;
using System.ComponentModel.DataAnnotations;

namespace day3
{
    struct Account
    {
        public long number;
        public decimal balance;
        public Useraccount type;

        public static void Display()
        {
            Console.WriteLine("enter number");
            long number = long.Parse(Console.ReadLine());
            Console.WriteLine("enter balance");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("1- Checking");
            Console.WriteLine("2- Deposit");
            Console.Write("Choice : ");
            Useraccount Type = (Useraccount) int.Parse(Console.ReadLine());
            
            
            
            Console.WriteLine(number);
            Console.WriteLine(balance);
            Console.WriteLine(Type);
        }

    }
    class Program
    {
        public static int Main()
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Account.Display();
            Console.ForegroundColor = ConsoleColor.White;

            return 0;
        }
    }

}

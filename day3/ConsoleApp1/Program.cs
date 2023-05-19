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
            long number=10;
            decimal balance = 1000;
            Useraccount Type = Useraccount.Deposit;
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

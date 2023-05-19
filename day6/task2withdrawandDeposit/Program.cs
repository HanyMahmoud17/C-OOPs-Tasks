

using bankAccountTask1;
using day3;
using System.Threading.Channels;

namespace bankaccounttaskday6
{


    class Program
    {


        public static int Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            BankAccount t1 = new BankAccount();
            t1.Number = 1;
            t1.Balance = 5000;
            t1.Type = (Useraccount)(1);
            t1.Withdraw(1000);
            Console.WriteLine(t1);

            Console.WriteLine();

            t1.Type = (Useraccount)(2);
            t1.Deposit(500);
            Console.WriteLine(t1);

            Console.ForegroundColor= ConsoleColor.Magenta;
            Console.WriteLine("\n");

            BankAccount t2 = new BankAccount();
            Console.WriteLine("enter number");
            t2.Number = long.Parse(Console.ReadLine());
            Console.WriteLine("enter balance");
            t2.Balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("1- Withdraw ");
            Console.WriteLine("2- Deposit");
            Console.Write("Choice : ");
            t2.Type = (Useraccount)int.Parse(Console.ReadLine());
            

            if (t2.Type == (Useraccount)1)
            {
                Console.WriteLine("enter your Withdrawdiscount is :");
                t2.Withdraw(decimal.Parse(Console.ReadLine()));
            }
            else
            {
                Console.WriteLine("enter your Depositadding is :");
                t2.Deposit(decimal.Parse(Console.ReadLine()));
            }

            Console.WriteLine(t2);


            Console.ForegroundColor = ConsoleColor.White;

            return 0;
        }
    }
}

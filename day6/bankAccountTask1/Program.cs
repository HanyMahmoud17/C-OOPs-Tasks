
using bankAccountTask1;
using day3;

namespace bankaccounttaskday6
{


    class Program
    {
        

        public static int Main()
        {
            BankAccount t1 = new BankAccount();
            t1.Number = 1;
            t1.Balance = 3000;
            t1.Type =(Useraccount) (1);

            Console.WriteLine(t1);

            BankAccount t2 = new BankAccount();
            Console.WriteLine("enter number");
            t2.Number = long.Parse(Console.ReadLine());
            Console.WriteLine("enter balance");
            t2.Balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("1- Checking");
            Console.WriteLine("2- Deposit");
            Console.Write("Choice : ");
            t2.Type = (Useraccount)int.Parse(Console.ReadLine());


            
            Console.WriteLine(t2);

            return 0;
        } 
    }
}

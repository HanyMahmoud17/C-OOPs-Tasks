

using bankAccountTask1;
using System.Reflection.Emit;
using System.Threading.Channels;
using System.Transactions;

namespace bankAccountTask1
{


    class Program
    {

        public static int Main()
        {

            BankAccount T = new BankAccount();
            Console.WriteLine("enter number");
            T.Number = long.Parse(Console.ReadLine());
            Console.WriteLine("enter balance");
            T.Balance = decimal.Parse(Console.ReadLine());
            Console.WriteLine("1- Withdraw ");
            Console.WriteLine("2- Deposit");
            Console.Write("Choice : ");
            T.Type = (Useraccount)int.Parse(Console.ReadLine());


            if (T.Type == (Useraccount)1)
            {
                Console.WriteLine("enter your Withdrawdiscount is :");
                decimal x = decimal.Parse(Console.ReadLine());
                T.Withdraw(x);

                
               
                BankTransaction B = new BankTransaction(x);
                //Console.WriteLine(B.ToString());
                Console.WriteLine(B.Displaywithdraw());
                

            }
            else
            {
                Console.WriteLine("enter your Depositadding is :");
                decimal y = decimal.Parse(Console.ReadLine());
                T.Deposit(y);
                
                BankTransaction B = new BankTransaction(y);
                Console.WriteLine(B.DisplayDeposit());
                
                //Console.WriteLine(B.ToString());
            }
            
            

            return 0;
        }
    }
}

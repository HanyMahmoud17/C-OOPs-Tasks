
using bankAccountTask1;
using day7;

namespace bankaccounttaskday6
{


    class Program
    {
        

        public static int Main()
        {
            BankAccount T= new BankAccount();
            Console.WriteLine(T);
            BankAccount T1= new BankAccount(1);
            Console.WriteLine(T1);
            BankAccount T2 = new BankAccount(2);
            Console.WriteLine(T2);
            BankAccount T3 = new BankAccount(1, (Useraccount)2);
            Console.WriteLine(T3);







            return 0;
        } 
    }
}

using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using System.Security.Principal;


namespace bankAccountTask1
{
   public class BankAccount
    {
        private long number;
        private decimal balance;
        private Useraccount type;
        static List<BankTransaction> transactions = new List<BankTransaction>();
        //private Queue transactions;
        //Queue<BankAccount> transactions = new Queue<BankAccount>();
        
        public long Number
        {
            get { return number; } 
            set {
                if (value > 0)
                {
                    number = value;
                }
                else
                {
                    throw new Exception("un valid num");
                }
            }
        }
        public decimal Balance
        {
            get { return balance; }
            set {
                if (value > 2500)
                {
                    balance = value;
                }
                else
                {
                    throw new Exception("enter balance again");
                }
            }
           
        }
        public Useraccount Type
        {
            get { return  type; }
            set {
                if((value == (Useraccount) 1) || (value == (Useraccount) 2))
                {
                    type = value;
                }
                else
                {
                    throw new Exception("enter type again");
                }
               
            }
        }

        
        public bool Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                balance -= amount;
                
                Console.WriteLine($"your discount is {amount} and after discount your balance become {balance}");
                transactions.Add(new BankTransaction(amount));
                Console.WriteLine($"the num of transactions(Withdraw) : {transactions.Count()}");

                Console.WriteLine();

                Console.WriteLine("Did you need to make Transaction again ?");
                Console.WriteLine(" Yes enter  1, No enter 2 ? ");
                int x= int.Parse(Console.ReadLine());
                if (x == 1)
                {
                    Program.Main();

                }
                else
                {
                    return false;
                }



                
                return true;
               
            }
            else
            {
                return false;
            }

        }
        public decimal Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"your adding is {amount} and after balance become {balance}");
            transactions.Add(new BankTransaction(amount));
            Console.WriteLine($"the num of transactions(Deposit) : {transactions.Count()}");

            Console.WriteLine();

            Console.WriteLine("Did you need to make Transaction again ?");
            Console.WriteLine(" Yes enter  1, No enter 2 ? ");
            int x = int.Parse(Console.ReadLine());
            if (x == 1)
            {

                Program.Main();

                Console.WriteLine();

            }
            else
            {
                return balance;
            }

            return balance;
        }

       
        public override string ToString()
        {
           
            return $"number : {this.number} ,balance : {this.balance} , type : {this.type}";
        }
    }
}

using System;
using day3;

namespace bankAccountTask1
{
   public class BankAccount
    {
        private long number;
        private decimal balance;
        private Useraccount type;

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
                Console.WriteLine(Balance);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public decimal Deposit(decimal amount)
        {
                Balance += amount;
                return balance;
        }

        public override string ToString()
        {
           
            return $"number : {number} ,balance : {balance} , type : {type}";
        }

        //is for test only not in our task

        public override bool Equals(object obj)
        {
            if (obj is BankAccount)
            {
                //convert from parent(obj) to child(BankAccount) 
                BankAccount Temp = (BankAccount)obj;
                return ((number == Temp.number) && (balance == Temp.balance) && (type == Temp.type));
            }
            else
                return false;
        }
    }
}

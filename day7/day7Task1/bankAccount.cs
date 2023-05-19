using System;
using day7;

namespace bankAccountTask1
{
   public class BankAccount
    {
        private long number ;
        private decimal balance;
        private Useraccount type;

        #region last part
        /*
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
         */
        #endregion


        public BankAccount()
        {
            type = (Useraccount)1;
            balance = 0;
        }

        public BankAccount(Useraccount _type)
        {
    
            type = _type;
            balance = 0;
        }
        public BankAccount(decimal _balanse)
        {
            balance = _balanse;
            type = (Useraccount)1;
        }
        public BankAccount(decimal _balanse , Useraccount _type)
        {

            balance = _balanse;
            type = _type;
        }

        public override string ToString()
        {
           
            return $"number : {number} ,balance : {balance} , type : {type}";
        }
    }
}

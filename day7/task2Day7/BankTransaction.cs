using System.Data;

namespace bankAccountTask1
{
    public class BankTransaction
    {

        public readonly decimal amount;
        public  readonly DateTime dateTime;

        public BankTransaction(decimal amount)
        {
            this.amount = amount;
            dateTime = DateTime.Now;
        }

        public decimal GetAmount()
        {
            return amount;
        }
        


        public DateTime GetDateTime()
        {
            return dateTime;
        }
        // construct that start with datatype to make date

        public string Displaywithdraw()
        {
            return $"[withdraw operation ] The amount from account  :{amount},The current date and time :{dateTime}";
        }
        public string DisplayDeposit()
        {
            return $"[Deposit operation ] The amount from account  :{amount},The current date and time :{dateTime}";
        }
        public override string ToString()
        {
            return $"The amount from account :{amount},The current date and time :{dateTime}";
        }
    }
}


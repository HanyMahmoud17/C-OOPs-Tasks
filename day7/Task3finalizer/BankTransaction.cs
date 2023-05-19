using System.Data;
using System.IO;

namespace bankAccountTask1
{
    public class BankTransaction
    {

        public readonly decimal amount;
        public readonly DateTime dateTime;

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


        public override string ToString()
        {
            return $"The amount from account :{amount},The current date and time :{dateTime}";
        }

        ~BankTransaction()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("Transactions.dat", true))
                {
                    writer.WriteLine(this.ToString());
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error writing to file: " + e.Message);
            }
        }
    }
}


using ITI;
using static System.Net.Mime.MediaTypeNames;

namespace lastTaskDay4
{
    struct program
    {

        public static void Count(params string[] strings)
        {

            int numVowels = 0;
            int numConsonants = 0;
            int numNewlines = 0;
            foreach (string i in strings)
            {
              
                Console.WriteLine($"count of character :{i.Length}");
                foreach (string c in strings)
                {
                    
                        if ("AEIOUaeiou".IndexOf(c) != -1)
                        {
                            numVowels++;
                            Console.WriteLine("Number of vowels: " + numVowels);
                        }
                        else
                        {
                            numConsonants++;
                            Console.WriteLine("Number of consonants: " + numConsonants);
                        }
                    
               
                }
            }
           
        }
        static int Main()
        {
            Console.WriteLine("Enter File Name : ");
            string FileName = Console.ReadLine();
            Console.WriteLine("Enter Message : ");
            string Message = Console.ReadLine();

            Count(Message);


            if (Logger.Log(FileName, Message) == true)
                Console.WriteLine("Logged");
            else
                Console.WriteLine("Error");
            return 0;
        }
    }
}

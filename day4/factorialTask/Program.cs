

namespace FactorialTaskDay4
{
    class program
    {
        public static void Factorial(int x)
        {

            int i;
            int fact = 1;
            for (i = 1; i <= x; i++)
            {
                fact = fact * i;
            }
            Console.Write("Factorial of " + x + " is: " + fact);
        }
        public static int Main()
        {
            Console.Write("Enter any Number: ");
            int number = int.Parse(Console.ReadLine());
            Factorial(number);




            return 0;
        }
    }
}

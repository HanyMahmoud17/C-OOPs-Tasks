using System;

namespace FactorialExampleDay4

{

    class Program

    {
        public static int GetFactorial(int number)

        {

            if (number == 0)

            {

                return 1;

            }

            return number * GetFactorial(number - 1);

        }
        public static int Main()

        {

            Console.WriteLine("Enter a number");

            int number = int.Parse(Console.ReadLine());

            int fact = GetFactorial(number);

            Console.WriteLine("{0} factorial is {1}", number, fact);

            return 0;

           

        }





    }

}

using System;

namespace day3
{
    class Utils
    {
        public static int Greater(int x,int y)
        {
            if (x > y)
            {
                Console.WriteLine($"the bigger number is {x}");
                return x;   
            }
            else
            {
                Console.WriteLine($"the bigger number is {y}");
                return y;  
            }
        }
    }
    class Test
    {
        public int A;
        public int B;
        public static int test() 
        {
             
            Console.WriteLine("enter num 1 :");
            int A=int.Parse(Console.ReadLine());
            Console.WriteLine("enter num 2 :");
            int B = int.Parse(Console.ReadLine());

            int result=Utils.Greater(A, B);

            return result;
          
        }   

    }
    class Program
    {
        public static int Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            
            Utils.Greater(1, 2);

            Console.WriteLine("\n");
            
            Test.test();
            
            Console.ForegroundColor = ConsoleColor.White;


            return 0;
        }
    }

}

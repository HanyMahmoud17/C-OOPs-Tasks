using System;

namespace Day4
{
    struct program
    {
        static int Main()
        {
            int[] evens = new int[5] { 0, 2, 4, 6, 8 };
            int crowd = evens[1];
            Console.WriteLine(crowd);

            int[] copy = new int[evens.Length];
            // 0 here is start index in evens
            evens.CopyTo(copy, 0);
            //after this i use string.join to to cnvert from array to string and make space by , of element
            Console.WriteLine(String.Join(", ", copy));
           
            string[] names=new string[2] {"hany","ahmed"};
            foreach (string item in names)
            {
                Console.WriteLine(item);
            }

            return 0;
        }
    }

}
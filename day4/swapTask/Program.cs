

namespace SwapTaskDay4
{
    class program
    {
        public static void Swap(ref int x, ref int y)
        {
            int num = x;
            x = y;
            y = num;

        }
        public static int Main()
        {
            int A = 1;
            int B = 2;
            Swap(ref A, ref B);

            Console.WriteLine($"A: {A}, B: {B}");

            return 0;
        }
    }
}
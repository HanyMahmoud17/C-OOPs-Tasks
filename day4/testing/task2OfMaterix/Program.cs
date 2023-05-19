using System;

class MatrixMultiplication
{
    static void Main()
    {
        int[,] matrix1 = new int[2, 2];
        int[,] matrix2 = new int[2, 2];
        int[,] result = new int[2, 2];

        Console.WriteLine("Enter values for matrix 1 (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter values for matrix 2 (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Multiply matrices
        result[0, 0] = matrix1[0, 0] * matrix2[0, 0] + matrix1[0, 1] * matrix2[1, 0];
        result[0, 1] = matrix1[0, 0] * matrix2[0, 1] + matrix1[0, 1] * matrix2[1, 1];
        result[1, 0] = matrix1[1, 0] * matrix2[0, 0] + matrix1[1, 1] * matrix2[1, 0];
        result[1, 1] = matrix1[1, 0] * matrix2[0, 1] + matrix1[1, 1] * matrix2[1, 1];

        // Print result
        Console.WriteLine("Result:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


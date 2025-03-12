using System;

class Program
{
    static void Main()
    { 
        Console.Write("Введіть розмірність масиву: ");
        int n = int.Parse(Console.ReadLine());

        Console.Write("Введіть порогове число: ");
        int threshold = int.Parse(Console.ReadLine());

        // 1. Одновимірний масив
        int[] array1D = new int[n];
        Random rand = new Random();

        Console.WriteLine("\nОдновимірний масив до змін:");
        for (int i = 0; i < n; i++)
        {
            array1D[i] = rand.Next(1, 20);
            Console.Write(array1D[i] + " ");
        }

        // Обробка масиву
        for (int i = 0; i < n; i++)
        {
            if (array1D[i] < threshold)
            {
                array1D[i] *= 2;
            }
        }

        Console.WriteLine("\nОдновимірний масив після змін:");
        foreach (int num in array1D)
        {
            Console.Write(num + " ");
        }

        // 2. Двовимірний масив
        Console.Write("\n\nВведіть кількість рядків: ");
        int rows = int.Parse(Console.ReadLine());

        Console.Write("Введіть кількість стовпців: ");
        int cols = int.Parse(Console.ReadLine());

        int[,] array2D = new int[rows, cols];

        Console.WriteLine("\nДвовимірний масив до змін:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array2D[i, j] = rand.Next(1, 20);
                Console.Write(array2D[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Обробка двовимірного масиву
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (array2D[i, j] < threshold)
                {
                    array2D[i, j] *= 2;
                }
            }
        }

        Console.WriteLine("\nДвовимірний масив після змін:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(array2D[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}

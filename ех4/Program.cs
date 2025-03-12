using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть кількість рядків (n): ");
        int n = int.Parse(Console.ReadLine());

        int[][] jaggedArray = new int[n][];
        Random rand = new Random();

        int maxCols = 0;

        Console.WriteLine("\nСхідчастий масив:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть кількість елементів у рядку {i + 1}: ");
            int m = int.Parse(Console.ReadLine());
            jaggedArray[i] = new int[m];

            if (m > maxCols) maxCols = m;  

            for (int j = 0; j < m; j++)
            {
                jaggedArray[i][j] = rand.Next(-10, 21);  
                Console.Write(jaggedArray[i][j] + "\t");
            }
            Console.WriteLine();
        }

        // Масив для збереження сум парних додатних елементів у кожному стовпці
        int[] sumArray = new int[maxCols];

        // Обчислення суми парних додатних елементів для кожного стовпця
        for (int j = 0; j < maxCols; j++)
        { 
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                if (j < jaggedArray[i].Length && jaggedArray[i][j] > 0 && jaggedArray[i][j] % 2 == 0)
                {
                    sum += jaggedArray[i][j];
                }
            }
            sumArray[j] = sum; 
        }

        // Виведення нового масиву
        Console.WriteLine("\nСума парних додатних елементів у кожному стовпці:");
        foreach (int sum in sumArray)
        {
            Console.Write(sum + " ");
        }
    }

}

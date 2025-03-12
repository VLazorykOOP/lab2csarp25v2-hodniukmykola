using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність масиву (n x n): ");
        int n = int.Parse(Console.ReadLine());

        int[,] array = new int[n, n];
        Random rand = new Random(); 

        // Заповнення масиву випадковими числами
        Console.WriteLine("\nМатриця:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = rand.Next(1, 100);
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        // Підрахунок середнього арифметичного під побічною діагоналлю
        int sum = 0, count = 0;
        for (int i = 1; i < n; i++)  // Починаємо з 1-го рядка (під побічною діагоналлю)
        {
            for (int j = 0; j < n - i; j++)  // Обмежуємо колонки, щоб не брати діагональ
            {
                sum += array[i, j];
                count++;
            }
        }

        double average = count > 0 ? (double)sum / count : 0;
        Console.WriteLine($"\nСереднє арифметичне елементів під побічною діагоналлю: {average:F2}");
    }
}

using System;

class Program
{
    static void Main()
    {
        Console.Write("Введіть розмірність масиву: ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];
        Random rand = new Random();

        // Заповнення масиву випадковими числами
        Console.WriteLine("\nПочатковий масив:");
        for (int i = 0; i < n; i++)
        {
            array[i] = rand.Next(1, 100);
            Console.Write(array[i] + " ");
        }

        // Знаходження максимального елемента та його індексу
        int maxIndex = 0;
        for (int i = 1; i < n; i++)
        {
            if (array[i] > array[maxIndex])
            {
                maxIndex = i;
            }
        }

        // Обмін першого і максимального елемента
        int temp = array[0];
        array[0] = array[maxIndex];
        array[maxIndex] = temp;

        Console.WriteLine("\n\nМасив після заміни:");
        foreach (int num in array)
        {
            Console.Write(num + " ");
        }
    }
}

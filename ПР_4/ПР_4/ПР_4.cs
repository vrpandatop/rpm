using System;

class Program
{
    static void Main()
    {
        Console.Write("Введите размер массива N: ");
        int N = int.Parse(Console.ReadLine());

        int[] arr = new int[N];

        Random rnd = new Random();

        for (int i = 0; i < N; i++)
        {
            arr[i] = rnd.Next(-100, 101); 
        }

        Console.WriteLine("\nИсходный массив:");
        for (int i = 0; i < N; i++)
        {
            Console.Write($"{arr[i]} ");
        }
        Console.WriteLine();

        int count = 0;

        Console.WriteLine("\nЧётные числа в порядке возрастания индексов:");
        for (int i = 0; i < N; i++)
        {
            if (arr[i] % 2 == 0) 
            {
                Console.Write($"{arr[i]} ");
                count++;
            }
        }

        if (count == 0)
        {
            Console.WriteLine("Чётных чисел нет.");
        }

        Console.WriteLine($"\n\nКоличество чётных чисел: {count}");
    }
}
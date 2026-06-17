using System;

class Program
{
    static void Main()
    {
        int size = 20;
        int[] original = new int[size];

        Random rnd = new Random();

        for (int i = 0; i < size; i++)
        {
            original[i] = rnd.Next(-99, 100);
        }

        Console.WriteLine("Исходный массив:");
        PrintArray(original);
        Console.WriteLine();

        int[] copy1 = (int[])original.Clone();
        SortPositiveInsertion(copy1);
        Console.WriteLine("После сортировки положительных элементов (вставками):");
        PrintArray(copy1);
        Console.WriteLine();

        int[] copy2 = (int[])original.Clone();
        SortNegativeBubble(copy2);
        Console.WriteLine("После сортировки отрицательных элементов (пузырьком):");
        PrintArray(copy2);
        Console.WriteLine();

        int[] copy3 = (int[])original.Clone();
        Array.Sort(copy3);
        Array.Reverse(copy3);
        Console.WriteLine("Весь массив, отсортированный по убыванию:");
        PrintArray(copy3);
    }

    static void PrintArray(int[] arr)
    {
        foreach (int num in arr)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }

    static void SortPositiveInsertion(int[] arr)
    {
        int n = arr.Length;

        for (int i = 1; i < n; i++)
        {
            if (arr[i] <= 0) continue;

            int key = arr[i];
            int j = i - 1;

            while (j >= 0 && arr[j] > 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
            }
            arr[j + 1] = key;
        }
    }

    static void SortNegativeBubble(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - 1 - i; j++)
            {
                if (arr[j] < 0 && arr[j + 1] < 0)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }
    }
}
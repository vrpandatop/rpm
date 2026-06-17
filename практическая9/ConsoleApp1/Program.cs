using System;

namespace Practice14_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число N: ");
            int N = int.Parse(Console.ReadLine());

            int sumRec = SumRecursive(N);
            Console.WriteLine($"Рекурсивная сумма от 1 до {N}: {sumRec}");

            int sumIter = SumIterative(N);
            Console.WriteLine($"Итеративная сумма от 1 до {N}: {sumIter}");
        }

        static int SumRecursive(int n)
        {
            if (n == 1)
                return 1;
            else
                return n + SumRecursive(n - 1);
        }
        static int SumIterative(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
            }
            return sum;
        }
    }
}
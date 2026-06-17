using System;

namespace PracticalWork11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            int rows = int.Parse(Console.ReadLine());

            Console.Write("Введите количество столбцов: ");
            int cols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rows, cols];
            Random rand = new Random();

            Console.WriteLine("\nИсходная матрица (случайные числа от -10 до 10):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-10, 11);
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n1) Число неотрицательных элементов в каждой строке:");
            int[] task1 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] >= 0)
                        count++;
                }
                task1[i] = count;
                Console.WriteLine($"   Строка {i + 1}: {count}");
            }

                        Console.WriteLine("\n2) Среднее арифметическое положительных элементов в каждом столбце:");
            double[] task2 = new double[cols];
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
                if (count > 0)
                {
                    task2[j] = (double)sum / count;
                    Console.WriteLine($"   Столбец {j + 1}: {task2[j]:F2}");
                }
                else
                {
                    task2[j] = 0;
                    Console.WriteLine($"   Столбец {j + 1}: нет положительных элементов");
                }
            }

            Console.WriteLine("\n3) Минимальное значение в каждой строке:");
            int[] task3 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
                task3[i] = min;
                Console.WriteLine($"   Строка {i + 1}: {min}");
            }

            Console.WriteLine("\n4) Максимальное значение в каждом столбце:");
            int[] task4 = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int max = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
                task4[j] = max;
                Console.WriteLine($"   Столбец {j + 1}: {max}");
            }

                        Console.WriteLine("\n5) Номер максимального значения в каждой строке (нумерация с 1):");
            int[] task5 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int maxIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] > matrix[i, maxIndex])
                        maxIndex = j;
                }
                task5[i] = maxIndex + 1;
                Console.WriteLine($"   Строка {i + 1}: {maxIndex + 1}");
            }

            Console.WriteLine("\n6) Номер минимального значения в каждом столбце (нумерация с 1):");
            int[] task6 = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int minIndex = 0;
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] < matrix[minIndex, j])
                        minIndex = i;
                }
                task6[j] = minIndex + 1;
                Console.WriteLine($"   Столбец {j + 1}: {minIndex + 1}");
            }

            Console.Write("\nВведите число для сравнения (задание 7): ");
            int заданноеЗначение7 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n7) Количество элементов в каждой строке меньше {заданноеЗначение7}:");
            int[] task7 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < заданноеЗначение7)
                        count++;
                }
                task7[i] = count;
                Console.WriteLine($"   Строка {i + 1}: {count}");
            }

            Console.Write("\nВведите число для сравнения (задание 8): ");
            int заданноеЗначение8 = int.Parse(Console.ReadLine());

            Console.WriteLine($"\n8) Первый элемент, не равный {заданноеЗначение8}:");
            int? task8 = null;
            bool found = false;
            for (int i = 0; i < rows && !found; i++)
            {
                for (int j = 0; j < cols && !found; j++)
                {
                    if (matrix[i, j] != заданноеЗначение8)
                    {
                        task8 = matrix[i, j];
                        Console.WriteLine($"   Найден элемент [{i + 1}, {j + 1}]: {matrix[i, j]}");
                        found = true;
                    }
                }
            }
            if (!found)
            {
                Console.WriteLine("   Все элементы равны заданному значению");
            }

            Console.WriteLine("\n9) Проверка упорядоченности строк по возрастанию (1 - да, 0 - нет):");
            int[] task9 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                bool isAscending = true;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] <= matrix[i, j - 1])
                    {
                        isAscending = false;
                        break;
                    }
                }
                task9[i] = isAscending ? 1 : 0;
                Console.WriteLine($"   Строка {i + 1}: {task9[i]}");
            }

            Console.WriteLine("\n10) Количество четных чисел в каждой строке:");
            int[] task10 = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                        count++;
                }
                task10[i] = count;
                Console.WriteLine($"   Строка {i + 1}: {count}");
            }

            Console.WriteLine("\n11) Сумма положительных элементов в каждом столбце:");
            int[] task11 = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                        sum += matrix[i, j];
                }
                task11[j] = sum;
                Console.WriteLine($"   Столбец {j + 1}: {sum}");
            }

            Console.WriteLine("\n12) Произведение положительных элементов в каждом столбце:");
            int[] task12 = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int product = 1;
                bool hasPositive = false;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                    {
                        product *= matrix[i, j];
                        hasPositive = true;
                    }
                }
                if (hasPositive)
                {
                    task12[j] = product;
                    Console.WriteLine($"   Столбец {j + 1}: {product}");
                }
                else
                {
                    task12[j] = 0;
                    Console.WriteLine($"   Столбец {j + 1}: нет положительных элементов");
                }
            }

            Console.WriteLine("\n13) Количество положительных элементов в каждом столбце:");
            int[] task13 = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                        count++;
                }
                task13[j] = count;
                Console.WriteLine($"   Столбец {j + 1}: {count}");
            }

            Console.WriteLine("\n14) Среднее арифметическое положительных элементов в каждом столбце:");
            double[] task14 = new double[cols];
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
                if (count > 0)
                {
                    task14[j] = (double)sum / count;
                    Console.WriteLine($"   Столбец {j + 1}: {task14[j]:F2}");
                }
                else
                {
                    task14[j] = 0;
                    Console.WriteLine($"   Столбец {j + 1}: нет положительных элементов");
                }
            }

            Console.WriteLine("\n15) Среднее геометрическое положительных элементов в каждом столбце:");
            double[] task15 = new double[cols];
            for (int j = 0; j < cols; j++)
            {
                double product = 1.0;
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                    {
                        product *= matrix[i, j];
                        count++;
                    }
                }
                if (count > 0)
                {
                    task15[j] = Math.Pow(product, 1.0 / count);
                    Console.WriteLine($"   Столбец {j + 1}: {task15[j]:F2}");
                }
                else
                {
                    task15[j] = 0;
                    Console.WriteLine($"   Столбец {j + 1}: нет положительных элементов");
                }
            }

            Console.WriteLine("\n16) Сумма отрицательных элементов в каждом столбце:");
            int[] task16 = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] < 0)
                        sum += matrix[i, j];
                }
                task16[j] = sum;
                Console.WriteLine($"   Столбец {j + 1}: {sum}");
            }

            Console.WriteLine("\n17) Произведение отрицательных элементов в каждом столбце:");
            int[] task17 = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int product = 1;
                bool hasNegative = false;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] < 0)
                    {
                        product *= matrix[i, j];
                        hasNegative = true;
                    }
                }
                if (hasNegative)
                {
                    task17[j] = product;
                    Console.WriteLine($"   Столбец {j + 1}: {product}");
                }
                else
                {
                    task17[j] = 0;
                    Console.WriteLine($"   Столбец {j + 1}: нет отрицательных элементов");
                }
            }

            Console.WriteLine("\n18) Минимальный элемент в каждой строке и деление строки на этот элемент:");

            int[] minInRow = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int min = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
                minInRow[i] = min;
                Console.WriteLine($"   Минимальный элемент строки {i + 1}: {min}");
            }

            int[,] matrix18 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                if (minInRow[i] != 0) 
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix18[i, j] = matrix[i, j] / minInRow[i];
                    }
                }
                else
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix18[i, j] = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("   Матрица после деления каждой строки на минимальный элемент:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix18[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n19) Минимальный положительный элемент в каждой строке:");
            int?[] task19 = new int?[rows];
            for (int i = 0; i < rows; i++)
            {
                int? minPositive = null;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        if (!minPositive.HasValue || matrix[i, j] < minPositive)
                            minPositive = matrix[i, j];
                    }
                }
                task19[i] = minPositive;
                if (minPositive.HasValue)
                    Console.WriteLine($"   Строка {i + 1}: {minPositive}");
                else
                    Console.WriteLine($"   Строка {i + 1}: нет положительных элементов");
            }

            Console.WriteLine("\n20) Максимальный отрицательный элемент в каждой строке:");
            int?[] task20 = new int?[rows];
            for (int i = 0; i < rows; i++)
            {
                int? maxNegative = null;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        if (!maxNegative.HasValue || matrix[i, j] > maxNegative)
                            maxNegative = matrix[i, j];
                    }
                }
                task20[i] = maxNegative;
                if (maxNegative.HasValue)
                    Console.WriteLine($"   Строка {i + 1}: {maxNegative}");
                else
                    Console.WriteLine($"   Строка {i + 1}: нет отрицательных элементов");
            }

            Console.WriteLine("\n21) Минимальный элемент в каждом столбце и умножение столбца на этот элемент:");

            int[] minInCol = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int min = matrix[0, j];
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] < min)
                        min = matrix[i, j];
                }
                minInCol[j] = min;
                Console.WriteLine($"   Минимальный элемент столбца {j + 1}: {min}");
            }

            int[,] matrix21 = new int[rows, cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix21[i, j] = matrix[i, j] * minInCol[j];
                }
            }

            Console.WriteLine("   Матрица после умножения каждого столбца на минимальный элемент:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix21[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n22) Максимальный элемент в каждой строке и прибавление его к элементам строки:");

            int[] maxInRow = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                int max = matrix[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] > max)
                        max = matrix[i, j];
                }
                maxInRow[i] = max;
                Console.WriteLine($"   Максимальный элемент строки {i + 1}: {max}");
            }

            int[,] matrix22 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix22[i, j] = matrix[i, j] + maxInRow[i];
                }
            }

            Console.WriteLine("   Матрица после прибавления максимального элемента к каждой строке:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix22[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n23) Минимальный элемент и его номер в каждой строке, затем вычитание номера из элементов:");

            int[] minValues23 = new int[rows];
            int[] minIndexes23 = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                        minIndex = j;
                }
                minValues23[i] = matrix[i, minIndex];
                minIndexes23[i] = minIndex + 1; 
                Console.WriteLine($"   Строка {i + 1}: минимальный элемент = {minValues23[i]}, номер = {minIndexes23[i]}");
            }

            int[,] matrix23 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix23[i, j] = matrix[i, j] - minIndexes23[i];
                }
            }

            Console.WriteLine("   Матрица после вычитания номера минимального элемента из каждой строки:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix23[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n24) Номер минимального элемента в каждой строке, затем прибавление номера к элементам:");

            int[] minIndexes24 = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int minIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] < matrix[i, minIndex])
                        minIndex = j;
                }
                minIndexes24[i] = minIndex + 1;
                Console.WriteLine($"   Строка {i + 1}: номер минимального элемента = {minIndexes24[i]}");
            }

            int[,] matrix24 = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix24[i, j] = matrix[i, j] + minIndexes24[i];
                }
            }

            Console.WriteLine("   Матрица после прибавления номера минимального элемента к каждой строке:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix24[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n25) Номер максимального элемента в каждом столбце, затем умножение элементов на номер:");

            int[] maxIndexes25 = new int[cols];

            for (int j = 0; j < cols; j++)
            {
                int maxIndex = 0;
                for (int i = 1; i < rows; i++)
                {
                    if (matrix[i, j] > matrix[maxIndex, j])
                        maxIndex = i;
                }
                maxIndexes25[j] = maxIndex + 1; 
                Console.WriteLine($"   Столбец {j + 1}: номер максимального элемента = {maxIndexes25[j]}");
            }

            int[,] matrix25 = new int[rows, cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix25[i, j] = matrix[i, j] * maxIndexes25[j];
                }
            }

            Console.WriteLine("   Матрица после умножения каждого столбца на номер максимального элемента:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix25[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n26) Номер максимального элемента в каждой строке, затем деление элементов на номер:");

            int[] maxIndexes26 = new int[rows];

            for (int i = 0; i < rows; i++)
            {
                int maxIndex = 0;
                for (int j = 1; j < cols; j++)
                {
                    if (matrix[i, j] > matrix[i, maxIndex])
                        maxIndex = j;
                }
                maxIndexes26[i] = maxIndex + 1; 
                Console.WriteLine($"   Строка {i + 1}: номер максимального элемента = {maxIndexes26[i]}");
            }

            double[,] matrix26 = new double[rows, cols]; 
            for (int i = 0; i < rows; i++)
            {
                if (maxIndexes26[i] != 0) 
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix26[i, j] = (double)matrix[i, j] / maxIndexes26[i];
                    }
                }
                else
                {
                    for (int j = 0; j < cols; j++)
                    {
                        matrix26[i, j] = matrix[i, j];
                    }
                }
            }

            Console.WriteLine("   Матрица после деления каждой строки на номер максимального элемента:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix26[i, j].ToString("F2") + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n27) Среднее арифметическое положительных элементов в каждой строке:");
            double[] task27 = new double[rows];
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > 0)
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
                if (count > 0)
                {
                    task27[i] = (double)sum / count;
                    Console.WriteLine($"   Строка {i + 1}: {task27[i]:F2}");
                }
                else
                {
                    task27[i] = 0;
                    Console.WriteLine($"   Строка {i + 1}: нет положительных элементов");
                }
            }

            Console.WriteLine("\n28) Среднее арифметическое отрицательных элементов в каждой строке:");
            double[] task28 = new double[rows];
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                int count = 0;
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] < 0)
                    {
                        sum += matrix[i, j];
                        count++;
                    }
                }
                if (count > 0)
                {
                    task28[i] = (double)sum / count;
                    Console.WriteLine($"   Строка {i + 1}: {task28[i]:F2}");
                }
                else
                {
                    task28[i] = 0;
                    Console.WriteLine($"   Строка {i + 1}: нет отрицательных элементов");
                }
            }

            Console.WriteLine("\n29) Среднее арифметическое элементов в каждой строке и умножение строки на него:");

            double[] averageInRow = new double[rows];
            for (int i = 0; i < rows; i++)
            {
                int sum = 0;
                for (int j = 0; j < cols; j++)
                {
                    sum += matrix[i, j];
                }
                averageInRow[i] = (double)sum / cols;
                Console.WriteLine($"   Среднее арифметическое строки {i + 1}: {averageInRow[i]:F2}");
            }

            double[,] matrix29 = new double[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix29[i, j] = matrix[i, j] * averageInRow[i];
                }
            }

            Console.WriteLine("   Матрица после умножения каждой строки на её среднее арифметическое:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix29[i, j].ToString("F2") + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n30) Среднее геометрическое элементов в каждом столбце и вычитание его из элементов:");

            double[] geometricInCol = new double[cols];
            for (int j = 0; j < cols; j++)
            {
                double product = 1.0;
                bool hasZero = false;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] == 0)
                    {
                        hasZero = true;
                        break;
                    }
                    product *= matrix[i, j];
                }

                if (!hasZero)
                {
                    geometricInCol[j] = Math.Pow(product, 1.0 / rows);
                    Console.WriteLine($"   Среднее геометрическое столбца {j + 1}: {geometricInCol[j]:F2}");
                }
                else
                {
                    geometricInCol[j] = 0;
                    Console.WriteLine($"   Столбец {j + 1}: содержит 0, среднее геометрическое = 0");
                }
            }

            double[,] matrix30 = new double[rows, cols];
            for (int j = 0; j < cols; j++)
            {
                for (int i = 0; i < rows; i++)
                {
                    matrix30[i, j] = matrix[i, j] - geometricInCol[j];
                }
            }

            Console.WriteLine("   Матрица после вычитания среднего геометрического из каждого столбца:");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("   ");
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix30[i, j].ToString("F2") + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nПрограмма завершена. Нажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();

            Console.WriteLine("1 - ПР 3.1.1");
            Console.WriteLine("2 - ПР 3.1.2");
            Console.WriteLine("3 - ПР 3.1.3");
            Console.WriteLine("4 - ПР 3.1.4");
            Console.WriteLine("5 - ПР 3.1.5");
            Console.WriteLine("6 - ПР 3.2.1");
            Console.WriteLine("7 - ПР 3.2.2");
            Console.WriteLine("8 - ПР 3.2.3");
            Console.WriteLine("9 - ПР 3.2.4");
            Console.WriteLine("10 - ПР 3.2.5");
            Console.WriteLine("0 - Выход");

            Console.Write("\nВыбор: ");
            string choice = Console.ReadLine();

            Console.Clear();

            switch (choice)
            {
                case "1":
                    for (int i = 1; i <= 20; i++)
                        Console.WriteLine($"{i} дюйм = {i * 2.54:F2} см");
                    break;

                case "2":
                    for (int i = 2; i <= 100; i += 2)
                        if (i % 5 == 0)
                            Console.Write(i + " ");
                    break;

                case "3":
                    for (int i = -500; i <= 500; i++)
                    {
                        if (Math.Abs(i) >= 100)
                        {
                            int hundreds = Math.Abs(i) / 100;
                            if (hundreds % 2 == 0)
                                Console.Write(i + " ");
                        }
                    }
                    break;

                case "4":
                    int sum = 0;
                    for (int i = -99; i <= 99; i++)
                        if (i < 0 && i % 2 != 0)
                            sum += Math.Abs(i);

                    Console.WriteLine("Сумма = " + sum);
                    break;

                case "5":
                    for (int i = 100; i <= 700; i++)
                        if ((i / 100) % 2 != 0)
                            Console.Write(i + " ");
                    break;

                case "6":
                    for (double x = 0.1; x <= 2.1; x += 0.2)
                    {
                        double y = x * x + Math.Sin(5 * x);
                        Console.WriteLine($"x={x:F1}, y={y:F4}");
                    }
                    break;

                case "7":
                    for (double x = 1.0; x <= 3.0; x += 0.2)
                    {
                        double y = x * x - Math.Pow(Math.Cos(Math.PI * x), 2);
                        Console.WriteLine($"x={x:F1}, y={y:F4}");
                    }
                    break;

                case "8":
                    for (double x = 0.2; x <= 2.2; x += 0.2)
                    {
                        double y = 1.8 * x * x - Math.Sin(10 * x);
                        Console.WriteLine($"x={x:F1}, y={y:F4}");
                    }
                    break;

                case "9":
                    for (double x = 2.0; x <= 4.0; x += 0.2)
                    {
                        double y = Math.Pow(2, x) - 2 * x * x - 1;
                        Console.WriteLine($"x={x:F1}, y={y:F4}");
                    }
                    break;

                case "10":
                    for (double x = 0.1; x <= 2.2; x += 0.2)
                    {
                        double y = Math.Pow(x, 3) - Math.Pow(Math.Cos(x + 1), 2);
                        Console.WriteLine($"x={x:F1}, y={y:F4}");
                    }
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Неверный ввод");
                    break;
            }

            Console.WriteLine("\n\nНажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
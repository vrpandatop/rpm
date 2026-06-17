using System;

public class InvalidProgressionException : Exception
{
    public InvalidProgressionException(string message) : base(message) { }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Vvedite perviy element: ");
            int first = int.Parse(Console.ReadLine());

            Console.Write("Vvedite ranost: ");
            int diff = int.Parse(Console.ReadLine());

            Console.Write("Vvedite kolichestvo: ");
            int count = int.Parse(Console.ReadLine());

            if (count <= 0)
            {
                throw new InvalidProgressionException("Kolichestvo dolzhno bit bolshe 0");
            }
            for (int i = 0; i < count; i++)
            {
                Console.Write(first + i * diff);
                if (i < count - 1) Console.Write("");
            }
        }
        catch (InvalidProgressionException ex)
        {
            Console.Write(ex.Message);
        }

    }
}

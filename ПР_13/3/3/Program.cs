using System;

public class GuessOutOfRangeException : Exception
{
    public GuessOutOfRangeException(string message) : base(message) { }
}
class Program
{
    static void Main()
    {
        Random rand = new Random();
        int sekret = rand.Next (1, 101);

        try
        {
            Console.Write("Ugaday chislo (1-100)");
            int guess = int.Parse(Console.ReadLine());
        
            if (guess < 1m || guess > 100)
            {
                throw new GuessOutOfRangeException("Chislo vne diapazona");
            }
            if (guess == sekret)
            {
                Console.WriteLine("Pobeda");
            }
            else
            {
                Console.WriteLine($"Ne ugadal. Bilo:{sekret}");
            }
        }
        catch (GuessOutOfRangeException ex)
        {
            Console.Write(ex.Message);
        }
        catch ( FormatException)
        { 
            Console.WriteLine("Oshibka: vvedite chislo");
        }

    }
}

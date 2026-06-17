using System;
using System.Numerics;

public class PhoneNumberFormatException : Exception
{
    public PhoneNumberFormatException(string message) : base(message) { }
}
class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Vvedite nomer: ");
            string phone = Console.ReadLine();


            if (!phone.StartsWith("+"))
            {
                throw new PhoneNumberFormatException("Nomer dolzhen nachinatsya c + ");
            }
            foreach (char c in phone)
            {
                if (char.IsLetter(c))
                {
                    throw new FormatException("Nomer ne dolzhen soderzhat bukvi ");
                }
            }
            Console.WriteLine(" Nomer verniy");
        }
        catch (PhoneNumberFormatException ex)
        {
            Console.Write(ex.Message);
        }
        catch (FormatException mm)
        {
            Console.Write(mm.Message);
        }

    }
}

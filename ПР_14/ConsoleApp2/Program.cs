using System;


    public class Clock
{
    public int Hours { get; set; }

    public static implicit operator Clock(int hours)
    {
        return new Clock { Hours = hours };
    }

    public static explicit operator int(Clock clock)
    {
        return clock.Hours * 60;
    }
}

public class Celcius
{
    public double Gradus { get; set; }

    public static implicit operator Celcius(Farengait f)
    {
        return new Celcius { Gradus = (5.0 / 9.0) * (f.Gradus - 32) };
    }

    public static explicit operator Farengait(Celcius c)
    {
        return new Farengait { Gradus = (9.0 / 5.0) * c.Gradus + 32 };
    }
}

public class Farengait
{
    public double Gradus { get; set; }
}

public class Dollar
{
    public decimal Sum { get; set; }

    public static explicit operator Euro(Dollar dollar)
    {
        return new Euro { Sum = dollar.Sum / 1.18m };
    }
}

public class Euro
{
    public decimal Sum { get; set; }


    public static implicit operator Dollar(Euro euro)
    {
        return new Dollar { Sum = euro.Sum * 1.18m };
    }
}


public class FootballPlayer
{
    public string Name { get; set; }
    public int Number { get; set; }

    public FootballPlayer(string name, int number)
    {
        Name = name;
        Number = number;
    }
}

public class FootballTeam
{
    private FootballPlayer[] players = new FootballPlayer[11];

    public FootballPlayer this[int index]
    {
        get
        {
            if (index >= 0 && index < players.Length)
                return players[index];
            else
            {
                Console.WriteLine("Ошибка: неверный индекс!");
                return null;
            }
        }
        set
        {
            if (index >= 0 && index < players.Length)
                players[index] = value;
            else
                Console.WriteLine("Ошибка: неверный индекс!");
        }
    }
}


public class Word
{
    public string Source { get; }
    public string Target { get; set; }

    public Word(string source, string target)
    {
        Source = source;
        Target = target;
    }
}

public class Dictionary
{
    private Word[] words;

    public Dictionary()
    {
        words = new Word[]
        {
                new Word("red", "красный"),
                new Word("blue", "синий"),
                new Word("green", "зеленый")
        };
    }


    public string this[string source]
    {
        get
        {
            foreach (var w in words)
            {
                if (w.Source == source)
                    return w.Target;
            }
            return "Слово не найдено";
        }
        set
        {
            foreach (var w in words)
            {
                if (w.Source == source)
                {
                    w.Target = value;
                    return;
                }
            }
            Console.WriteLine("Слово не найдено для изменения");
        }
    }
}


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1");
        Clock clock = 5;
        Console.WriteLine($"Clock hours: {clock.Hours}");
        int minutes = (int)clock;
        Console.WriteLine($"Minutes: {minutes}");

        Console.WriteLine("\n2");
        Farengait f = new Farengait { Gradus = 100 };
        Celcius c = f;
        Console.WriteLine($"{f.Gradus}°F = {c.Gradus:F2}°C");
        Celcius c2 = new Celcius { Gradus = 37 };
        Farengait f2 = (Farengait)c2;
        Console.WriteLine($"{c2.Gradus}°C = {f2.Gradus:F2}°F");

        Console.WriteLine("\n3");
        Euro euro = new Euro { Sum = 100 };
        Dollar dollar = euro;
        Console.WriteLine($"{euro.Sum} евро = {dollar.Sum} долларов");
        Dollar dollar2 = new Dollar { Sum = 118 };
        Euro euro2 = (Euro)dollar2;
        Console.WriteLine($"{dollar2.Sum} долларов = {euro2.Sum:F2} евро");

        Console.WriteLine("\n4");
        FootballTeam team = new FootballTeam();
        team[0] = new FootballPlayer("Иванов", 10);
        team[11] = new FootballPlayer("Петров", 7);
        var player = team[0];
        if (player != null)
            Console.WriteLine($"Игрок: {player.Name}, номер {player.Number}");

        Console.WriteLine("\n5");
        Dictionary dict = new Dictionary();
        Console.WriteLine($"red -> {dict["red"]}");
        dict["blue"] = "голубой";
        Console.WriteLine($"blue -> {dict["blue"]}");
        Console.WriteLine($"yellow -> {dict["yellow"]}");

        Console.WriteLine("\n6");

        (int id, string name, char grade, string city, ulong population) tuple = (1, "Alice", 'A', "Moscow", 12500000);

        Console.WriteLine($"Весь кортеж: {tuple}");
        Console.WriteLine($"1-й элемент: {tuple.Item1}, 3-й: {tuple.Item3}, 4-й: {tuple.Item4}");

        var (id2, name2, grade2, city2, pop2) = tuple;
        Console.WriteLine($"Распаковано: id={id2}, name={name2}, grade={grade2}, city={city2}, pop={pop2}");

        var tuple2 = (1, "Alice", 'A', "Moscow", 12500000UL);
        Console.WriteLine($"Кортежи равны? {tuple == tuple2}");
        Console.ReadKey();
    }
}

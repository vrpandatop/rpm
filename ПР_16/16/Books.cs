public class Books
{
    string name;
    double price;
    int kol = 1;

    public string Name
    { get { return name; } }

    public double Price { get { return price; } }

    public int Kol { get { return kol; } set { kol = value; } }

    public Books(string name, double price)
    {
        this.name = name;
        this.price = price;
    }

    public string Print() => $"Name - {this.Name}, price - {this.price}, kol = {this.kol}";

    public double Total()
    {
        return this.price * this.kol;
    }
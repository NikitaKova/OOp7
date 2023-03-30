namespace HomeWork07;

public class View
{
    public View()
    {
    }

    public int getPositiveInt()
    {
        string? s = Console.ReadLine();
        int x;
        if (int.TryParse(s, out x))
            return x;
        else
            return -1;
    }

    public string? getString()
    {
        string? s = Console.ReadLine();
        return s;
    }

    public void print(String data)
    {
        Console.WriteLine(data);
    }

    public void clear()
    {
        Console.Clear();
    }


}
class Program
{
    public static void Main(string[] args)
    {
        string? name;
        Console.WriteLine("What is your name? ");
        string? readResult = Console.ReadLine();
        if (readResult == null)
        {
            name = "Guest";
        }
        Console.WriteLine($"Hi, {name}!");
    }
}
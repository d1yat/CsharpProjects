class Program
{
    public static void Main(string[] args)
    {
        string? name = "Guest";
        Console.WriteLine("What is your name? ");
        name = Console.ReadLine();
        Console.WriteLine($"Hi, {name}!");
    }
}

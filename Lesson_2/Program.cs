internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, what's your name?");

        string name = Console.ReadLine();

        Console.WriteLine(name);

        Console.WriteLine("Okey, how many years you will be after 10 years?");

        int age = int.Parse(Console.ReadLine());

        Console.WriteLine(age);
    }
}
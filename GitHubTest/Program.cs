namespace GitHubTest;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Jonas L. Hellum");
        CountTo(10);
    }

    static void CountTo(int num)
    {
        for (int i = 1; i <= num; i++)
        {
            Console.WriteLine(i);
        }
    }
}
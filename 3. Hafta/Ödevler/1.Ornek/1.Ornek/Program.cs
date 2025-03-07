using _1.Ornek;

internal class Program
{
    private static void Main(string[] args)
    {
        Manager manager = new Manager(1, "Ahmet", 6000, "Yönetim", 5);
        manager.DisplayManagerInfo();

        Console.WriteLine();

        Developer developer = new Developer(2, "Mehmet", 5000, "Yazılım", "C# ve .NET geliştiricisi");
        developer.DisplayDeveloperInfo();
    }
}
using _2.Ornek;

internal class Program
{
    private static void Main(string[] args)
    {
        SavingsAccount savings = new SavingsAccount("Ahmet Yılmaz", 1000);
        savings.savingsinfo();

        Console.WriteLine("");

        CheckingAccount checking = new CheckingAccount("Mehmet Kaya", 2000);
        checking.checkinginfo();

    }
}
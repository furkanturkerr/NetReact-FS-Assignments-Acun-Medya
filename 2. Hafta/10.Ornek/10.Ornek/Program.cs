
internal class Program
{
    private static void Main(string[] args)
    {
        //10 - Bir sayı listesinde 10’dan küçük olanları silen algoritmayı yazınız.

        List<int> sayi = new List<int> { 5, 62, 4, 17, 96 };

        sayi.RemoveAll(x => x < 10);

        foreach (int num in sayi)
        {
            Console.WriteLine(num);
        }
    }
}
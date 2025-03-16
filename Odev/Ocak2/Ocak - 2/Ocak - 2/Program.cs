internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıdan iki sayı alıp toplamını ekrana yazdıran bir program yazın.

        Console.Write("1. Sayıyı Gir: ");
        int s1 = int.Parse(Console.ReadLine());

        Console.Write("2. Sayıyı Gir: ");
        int s2 = int.Parse(Console.ReadLine());

        int t = s1 + s2;
        Console.Write($"Toplam: {t}");
    }
}
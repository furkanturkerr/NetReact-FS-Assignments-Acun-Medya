internal class Program
{
    private static void Main(string[] args)
    {
        //1 - For döngüsü ile sayının rakamlarının toplamını bulan algoritmayı yazınız.

        Console.Write("Sayıyı Giriniz: ");
        int sayi = int.Parse(Console.ReadLine());

        int toplam = 0;
        for(; sayi > 0; sayi /= 10)
        {
            toplam += sayi % 10;
        }

        Console.WriteLine("Sayının Rakamları Toplamı: " + toplam);
    }
}
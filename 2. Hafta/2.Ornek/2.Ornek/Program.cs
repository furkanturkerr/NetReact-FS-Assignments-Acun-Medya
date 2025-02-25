using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        //2 -  while döngüsü ile kullanıcıdan belirli şartlara uyan bir değer alan algoritmayı yazınız(Kullanıcıdan 10 ile 100 arasında bir sayı al ve eğer bu 
        //    aralık dışında girerse tekrar iste.)

        Console.Write("10 ile 100 arasında bir sayı gir; ");
        int sayi = int.Parse(Console.ReadLine());

        while(sayi < 10 || sayi > 100){
            Console.WriteLine("10 ile 100 arasında bir sayı girmediniz tekrar giriniz; ");
            sayi = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Sayınız: " + sayi);
    }
}
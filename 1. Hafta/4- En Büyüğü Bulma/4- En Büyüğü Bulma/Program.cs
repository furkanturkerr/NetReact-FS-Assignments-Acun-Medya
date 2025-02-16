internal class Program
{
    private static void Main(string[] args)
    {
        //4-Üç Sayının En Büyüğünü Bulma (if-else)

        Console.Write("1. Sayıyı Gir: ");
        int sayi1 = int.Parse(Console.ReadLine());
        Console.Write("2. Sayıyı Gir: ");
        int sayi2 = int.Parse(Console.ReadLine());
        Console.Write("3. Sayıyı Gir: ");
        int sayi3 = int.Parse(Console.ReadLine());

        if(sayi1 >= sayi2 && sayi1 >= sayi3)
        {
            Console.WriteLine("Büyük Sayı: " + sayi1);
        }
        else if(sayi2 >= sayi1 && sayi2 >= sayi3){
            Console.WriteLine("Büyük Sayı: " + sayi2);
        }
        else 
        {
            Console.WriteLine("Büyük Sayı: " + sayi3);
        }

        Console.ReadKey();
    }
}
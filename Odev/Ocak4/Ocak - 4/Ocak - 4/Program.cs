internal class Program
{
    private static void Main(string[] args)
    {
        //1’den 10’a kadar olan sayıları ekrana yazdıran bir for döngüsü yazın.

        for(int i=1; i<=10; i++)
        {
            Console.WriteLine(i);
        }

        //Kullanıcıdan alınan bir sayıya kadar olan sayıların toplamını hesaplayan bir program yazın.

        Console.Write("Bir Sayı gir: ");
        int s1 = int.Parse(Console.ReadLine());

        int toplam = 0;

        for(int i=1; i< s1; i++)
        {
            toplam += i;  
        }

        Console.WriteLine(toplam);
    }
}
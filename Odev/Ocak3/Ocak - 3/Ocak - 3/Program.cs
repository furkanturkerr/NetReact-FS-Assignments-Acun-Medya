internal class Program
{
    private static void Main(string[] args)
    {
        //Kullanıcıdan bir sayı alıp tek mi çift mi olduğunu bulan bir C# programı yazın.

        Console.Write("Sayı gir: ");
        int s = int.Parse(Console.ReadLine());

        if (s % 2 != 0)
        {
            Console.WriteLine("Sayı Tek");
        }
        else
        {
            Console.WriteLine("Sayı Çift");
        }

        //Girilen bir sayının pozitif, negatif veya sıfır olup olmadığını belirleyen bir program yazın.

        Console.Write("Sayı gir: ");
        int s1 = int.Parse(Console.ReadLine());

        if (s1 > 0){
            Console.WriteLine("Sayı Pozitif");
        }
        else  if(s1 < 0)
        {
            Console.WriteLine("Sayı Negaif");
        }
        else
        {
            Console.WriteLine("Sayı 0 a eşit");
        }
    }
}
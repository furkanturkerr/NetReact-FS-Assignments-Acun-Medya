internal class Program
{
    private static void Main(string[] args)
    {
        //3 -  foreach döngüsü ile kişilerin yaş kategorisini belirleyen algoritmayı yazınız.(0 - 12: Çocuk, 13 - 19: Genç, 20 - 64: Yetişkin, 65 +: Yaşlı.)

        List<int> yaslar = new List<int>(); 
        int yas;

        while (true)
        {
            Console.WriteLine("Ailenin Yaşlarını Gir (Bitince \"0 yaz\")");
            yas = int.Parse(Console.ReadLine());

            if (yas == 0) 
            {
                break;
            }

            yaslar.Add(yas);
        }

        foreach (int sayi in yaslar) 
        {
            if (sayi > 0 && sayi <= 12)
            {
                Console.WriteLine($"Çocuk {sayi}");
            }
            else if (sayi > 12 && sayi <= 19)
            {
                Console.WriteLine($"Genç {sayi}");
            }
            else if (sayi > 19 && sayi <= 64)
            {
                Console.WriteLine($"Yetişkin {sayi}");
            }
            else if (sayi >= 65)
            {
                Console.WriteLine($"Yaşlı {sayi}");
            }
        }


    }
}
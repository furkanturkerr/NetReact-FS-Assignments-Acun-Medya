internal class Program
{
    private static void Main(string[] args)
    {
        //7 - Bir string dizisinin boyutunu dinamik olarak genişleten algoritmayı yazınız.

        string[] dizi = new string[1];
        string[] yenidizi = new string[5];

        Console.Write("Kelime gir");
        dizi[0] = Console.ReadLine(); 

        int diziboyutu = 1;

        Console.WriteLine("Dizi Boyutu doldu");

        Console.WriteLine("Dizi boyutu artırıldı.");
        if(dizi.Length == diziboyutu)
        {
            for(int i=0; i < yenidizi.Length; i++)
            {
                yenidizi[i] = Console.ReadLine();
            }
                
        }

        for(int a=0; a < dizi.Length; a++)
        {
            Console.WriteLine($"{a+1}. Kelime: {dizi[a]}");
        }

        for (int a = 0; a < yenidizi.Length; a++)
        {
            Console.WriteLine($"{a+2}. Kelime: {yenidizi[a]}");
        }

    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //5 elemanlı bir int dizisi oluşturup, kullanıcıdan aldığı değerlerle diziyi dolduran ve ekrana yazdıran bir program yazın.
        //Bir dizinin içindeki en büyük sayıyı bulan bir C# programı yazın.

        int[] dizi = new int[5];

        Console.WriteLine("5 adet sayı gir: ");
        for (int i=0; i<dizi.Length; i++)
        {
            dizi[i] = int.Parse(Console.ReadLine());
        }

        foreach(int sayılar in dizi)
        {
            Console.WriteLine(sayılar);
        }

        int max = dizi[0];

        for (int i = 0; i < dizi.Length; i++)
        {
            if (dizi[i] > max)
            {
                max = dizi[i];
            }
        }

        Console.WriteLine($"En büyük sayı: {max}");

    }
}
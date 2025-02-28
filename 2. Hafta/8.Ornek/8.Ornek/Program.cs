internal class Program
{
    private static void Main(string[] args)
    {
        //8 - Kullanıcının girdiği kelimeleri listeye kaydeden ve tersten yazdıran algoritmayı yazınız.

        Console.Write("5 tane kelime Gir: ");

        List<string> kelime = new List<string>();
        for(int i=0; i < 5; i++)
        {
            string a = Console.ReadLine();
            kelime.Add(a);
        }

        kelime.Reverse(); //tersten sıralıyormuş

        Console.WriteLine("Kelimeler tersten sıralandı:");
        foreach (string kelimeler in kelime)
        {
            Console.WriteLine(kelimeler);
        }


    }
}
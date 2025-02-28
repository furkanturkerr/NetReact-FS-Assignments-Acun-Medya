internal class Program
{
    private static void Main(string[] args)
    {
        //6 - Kullanıcının girdiği bir cümleyi diziye kaydeden ve alfabetik olarak sıralayan algoritmayı yazınız.

        string[] cumle = new string[4];
        Array.Sort(cumle);


        Console.Write("4 adet kelime gir: ");
        for(int i=0; i < cumle.Length; i++)
        {
            cumle[i] = Console.ReadLine();
        }

        foreach(string sirala in cumle)
        {
            Console.WriteLine(sirala);
        }


    }
}
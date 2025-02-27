internal class Program
{
    private static void Main(string[] args)
    {
        //5 - Bir dizide en uzun ve en kısa kelimeyi bulan algoritmayı yazınız.

        string[] kelime = new string[5];
        kelime[0] = "yazzılım";
        kelime[1] = "messi";
        kelime[2] = "acunmedya";
        kelime[3] = "MustafaKemalATATÜRK";
        kelime[4] = "İsmetİnönü";

        string enuzun = kelime[0];
        string enkisa = kelime[0];

        foreach (string a in kelime)
        {
            if(a.Length > enuzun.Length)
            {
                enuzun = a;
            }
            if (a.Length < enkisa.Length)
            {
                enkisa = a;
            }
        }

        Console.WriteLine($"En uzun kelime: {enuzun}");
        Console.WriteLine($"En kısa kelime: {enkisa}");
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        //11 - Öğrenci notlarının olduğu bir listede 50’nin altındaki tüm notları 50 olarak güncelleyen bir algoritma yazınız.

        List<int> notlar = new List<int> { 45, 75, 32, 90, 50, 48 };

        for (int i = 0; i < notlar.Count; i++)
        {
            if (notlar[i] < 50)
            {
                notlar[i] = 50;
            }
        }

        foreach (int not in notlar)
        {
            Console.WriteLine(not);
        }
    }
}
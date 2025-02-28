//9 - Kullanıcıdan ratgele sayılar alıp listeye ekleyen, bu sayıların ortalamasını alan ve bu sayıları küçükten büyüğe sıralayan algoritmayı yazınız.

int a;
int toplam = 0;
int sayac = 0;
double ortalama = 0;
List<int> sayi = new List<int>();
Console.WriteLine("rastgele sayılar gir. Çıkmak için \"00\" yaz");

while (true)
{
    Console.Write("Sayı: ");
    a = int.Parse(Console.ReadLine());
    
    if(a == 00)
    {
        break;
    }

    sayi.Add(a);
    toplam += a;
    sayac++;
}

ortalama = (toplam/sayac);
Console.Write("Ortalama: " + ortalama);
Console.WriteLine();
Console.WriteLine("Küçükten Büyüğe: ");
sayi.Sort();
foreach (int num in sayi)
{
    Console.WriteLine(num);
}
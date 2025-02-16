

//3 - Basit Hesap Makinesi(switch-case)

Console.Write("1. Sayıyı Gir: ");
double sayi1 = double.Parse(Console.ReadLine());

Console.Write("2. Sayıyı Gir: ");
double sayi2 = double.Parse(Console.ReadLine());

Console.Write(" (+ - / *) İşlem: ");
char islem = char.Parse(Console.ReadLine());

double sonuc = 0;

switch (islem)
{
    case '+':
        sonuc = sayi1 + sayi2;
        break;
    case '-':
        if (sayi2 > sayi1)
        {
            sonuc = sayi2 - sayi1;
        }
        else
        {
            sonuc = sayi1 - sayi2;
        }
        break;
    case '*':
        sonuc = sayi1 * sayi2;
        break;
    case '/':
        if (sayi2 != 0)
        {
            sonuc = sayi1 / sayi2;
        }
        else
        {
            Console.WriteLine("Sıfıra bölünemez");
        }

        break;
    default:
        Console.WriteLine("Geçersiz işlem");
        return;
}

Console.WriteLine("Sonuç: " + sonuc);
Console.ReadKey();
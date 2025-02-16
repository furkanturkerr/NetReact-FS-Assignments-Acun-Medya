

//1: Sayının Pozitif, Negatif veya Sıfır Olduğunu Belirleme (if-else)


Console.WriteLine("Bir Sayı Gir");
double sayi1 = double.Parse(Console.ReadLine());

if(sayi1 > 0 )
{
    Console.WriteLine("Pozitif");
}
else if (sayi1 < 0)
{
    Console.WriteLine("Negatif");
}
else
{
    Console.WriteLine("0'a Eşit");
}
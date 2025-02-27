//4 - Bir dizide tekrar eden elemanları bulan algoritmayı yazınız.

int[] numbers = new int[5];
Console.Write("5 tane sayı gir: ");

for(int i=0; i < 5; i++)
{
    numbers[i] = int.Parse(Console.ReadLine());
}

bool tekrar = false;

Console.WriteLine("Tekrar eden sayılar:");
for (int i = 0; i < numbers.Length; i++)
{
    for (int j = i + 1; j < numbers.Length; j++)
    {
        if (numbers[i] == numbers[j])
        {
            Console.WriteLine(numbers[i]);
            tekrar = true;
            break;
        }
    }
}

if(tekrar != true)
{
    Console.WriteLine("Tekrar eden sayı yok");
}

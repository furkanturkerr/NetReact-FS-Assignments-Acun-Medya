
//5 - Şifre Güçlülüğünü Kontrol Etme (if-else)
//🎯 Amaç: Kullanıcının girdiği şifrenin güçlü olup olmadığını kontrol eden program yaz.
//📌 Koşullar:

//Şifre en az 8 karakter uzunluğunda olmalı.
//Şifre içinde @, #, $, % gibi özel karakterler içermeli.
//Şifre en az 1 büyük harf içermeli.


Console.WriteLine("Şifre Gir");
string sifre = Console.ReadLine();

string ozelKarakterler = "@#$%";


if (sifre.Length < 8)
{
    Console.WriteLine("Şifre en az 8 karakter uzunluğunda olmalı.");
}
else if (!sifre.Any(char.IsUpper))
{
    Console.WriteLine("Şifre en az 1 büyük harf içermeli.");
}
else if(!sifre.Any(ozelKarakterler.Contains))
{
    Console.WriteLine("Şifre içinde @, #, $, % gibi özel karakterler içermeli.");
}
else
{
    Console.WriteLine("Şifre Geçerli");
}
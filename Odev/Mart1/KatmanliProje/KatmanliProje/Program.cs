using System;
using Business;
using Entities;

class Program
{
    static void Main()
    {
        ProgrammingLanguageService languageService = new ProgrammingLanguageService();
        TechnologyService technologyService = new TechnologyService();

        while (true)
        {
            Console.WriteLine("1 - Programlama Dili Ekle");
            Console.WriteLine("2 - Programlama Dillerini Listele");
            Console.WriteLine("3 - Çıkış");
            Console.Write("Seçiminiz: ");
            int secim = int.Parse(Console.ReadLine());

            if (secim == 1)
            {
                Console.Write("Programlama Dili Adı: ");
                string name = Console.ReadLine();
                ProgrammingLanguage language = new ProgrammingLanguage { Id = new Random().Next(1, 1000), Name = name };
                languageService.AddLanguage(language);
                Console.WriteLine("Eklendi!\n");
            }
            else if (secim == 2)
            {
                var languages = languageService.GetAllLanguages();
                Console.WriteLine("Programlama Dilleri:");
                foreach (var lang in languages)
                {
                    Console.WriteLine($"ID: {lang.Id}, Ad: {lang.Name}");
                }
                Console.WriteLine();
            }
            else if (secim == 3)
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz Seçim!\n");
            }
        }
    }
}
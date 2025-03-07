internal class Program
{
    private static void Main(string[] args)
    {
        PersonManager personManager = new PersonManager();
        Customer customer = new Customer
        {
            id = 1,
            FirstName = "furkan",
            LastName = "türker",
            adress = "Samsun"
        };

        Student student = new Student
        {
            id = 1,
            FirstName = "Ali",
            LastName = "veli",
            Departmant = "Computer"
        };

        personManager.Add(student);
        personManager.Add(customer);

        Console.ReadLine();
    }

    interface IPerson
    {
        int id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }

    class Customer : IPerson
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string adress { get; set; }
    }

    class Student : IPerson
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Departmant { get; set; }
    }

    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
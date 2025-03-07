internal class Program
{
    private static void Main(string[] args)
    {
        Database database = new Oracle();
        database.Delete();
        database.add();

        Database database2 = new Oracle();
        database.Delete();
        database.add();

        Console.ReadLine();
    }

    abstract class Database
    {
        public void add()
        {
            Console.WriteLine("Added by default");
        }

        public abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Sql");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Deleted by Oracle");
        }
    }



}
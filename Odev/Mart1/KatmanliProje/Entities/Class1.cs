namespace Entities
{
    public class ProgrammingLanguage
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Technology
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}

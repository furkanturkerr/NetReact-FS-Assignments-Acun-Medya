namespace DataAccess
{
    public class ProgrammingLanguageRepository
    {
        private List<ProgrammingLanguage> _languages = new List<ProgrammingLanguage>();

        public void Add(ProgrammingLanguage language) => _languages.Add(language);
        public List<ProgrammingLanguage> GetAll() => _languages;
        public void Delete(int id) => _languages.RemoveAll(l => l.Id == id);
        public void Update(ProgrammingLanguage language)
        {
            var lang = _languages.FirstOrDefault(l => l.Id == language.Id);
            if (lang != null) lang.Name = language.Name;
        }
        public ProgrammingLanguage GetById(int id) => _languages.FirstOrDefault(l => l.Id == id);
    }
}
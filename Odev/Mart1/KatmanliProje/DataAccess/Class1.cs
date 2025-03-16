using Entities;
using System.Collections.Generic;
using System.Linq;

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

    public class TechnologyRepository
    {
        private List<Technology> _technologies = new List<Technology>();

        public void Add(Technology tech) => _technologies.Add(tech);
        public List<Technology> GetAll() => _technologies;
        public void Delete(int id) => _technologies.RemoveAll(t => t.Id == id);
        public void Update(Technology tech)
        {
            var t = _technologies.FirstOrDefault(t => t.Id == tech.Id);
            if (t != null) t.Name = tech.Name;
        }
        public Technology GetById(int id) => _technologies.FirstOrDefault(t => t.Id == id);
    }
}
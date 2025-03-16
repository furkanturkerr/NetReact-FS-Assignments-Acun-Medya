using Entities;
using DataAccess;
using System.Collections.Generic;

namespace Business
{
    public class ProgrammingLanguageService
    {
        private ProgrammingLanguageRepository _repository = new ProgrammingLanguageRepository();

        public void AddLanguage(ProgrammingLanguage language) => _repository.Add(language);
        public List<ProgrammingLanguage> GetAllLanguages() => _repository.GetAll();
        public void DeleteLanguage(int id) => _repository.Delete(id);
        public void UpdateLanguage(ProgrammingLanguage language) => _repository.Update(language);
        public ProgrammingLanguage GetLanguageById(int id) => _repository.GetById(id);
    }

    public class TechnologyService
    {
        private TechnologyRepository _repository = new TechnologyRepository();

        public void AddTechnology(Technology tech) => _repository.Add(tech);
        public List<Technology> GetAllTechnologies() => _repository.GetAll();
        public void DeleteTechnology(int id) => _repository.Delete(id);
        public void UpdateTechnology(Technology tech) => _repository.Update(tech);
        public Technology GetTechnologyById(int id) => _repository.GetById(id);
    }
}
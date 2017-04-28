using DI.Data;
using DI.Data.Models;
using DI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DI.Services
{
    public class SchoolService
    {
        private IRepository<School> _repository;

        public SchoolService(IRepository<School> repository)
        {
            _repository = repository;
        }

        public List<School> GetAll()
        {
            return _repository.GetAll().ToList();
        }

        public School GetById(int id)
        {
            return _repository.Get(id);
        }

        public void Add(School school)
        {
            _repository.Add(school);
        }

        public void Update(School school)
        {
            _repository.Update(school);
        }

        public void Delete(int id)
        {
            School school = _repository.Get(id);
            if (school != null) _repository.Delete(school);
        }
    }
}
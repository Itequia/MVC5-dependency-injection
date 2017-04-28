using DI.Data.Models;
using DI.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DI.Data.Repositories;

namespace DI.Test.Data
{
    public class SchoolRepositoryStub : IRepository<School>
    {
        List<School> fakeSchoolTable = new List<School>() {
                new School() { Id = 1, Name = "School 1" },
                new School() { Id = 2, Name = "School 2" },
                new School() { Id = 3, Name = "School 3" },
                new School() { Id = 4, Name = "School 4" },
                new School() { Id = 5, Name = "School 5" },
                new School() { Id = 6, Name = "School 6" },
                new School() { Id = 7, Name = "School 7" },
                new School() { Id = 8, Name = "School 8" },
                new School() { Id = 9, Name = "School 9" },
                new School() { Id = 10, Name = "School 10" },
                new School() { Id = 11, Name = "School 11" }
        };

        public void Add(School entity)
        {
            fakeSchoolTable.Add(entity);
        }

        public void Delete(School entity)
        {
            fakeSchoolTable.Remove(entity);
        }

        public IQueryable<School> GetAll()
        {
            return fakeSchoolTable.AsQueryable();
        }

        public School Get(int id)
        {
            return fakeSchoolTable.FirstOrDefault(x => x.Id == id);
        }

        public void Update(School entity)
        {

            var listItem = fakeSchoolTable.FirstOrDefault(x => x.Id == entity.Id);
            entity.Name = entity.Name;
            entity.Students = entity.Students;
        }
    }
}

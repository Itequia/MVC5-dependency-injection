using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DI.Services;
using Ninject;
using DI.Data.Repositories;
using DI.Data.Models;
using DI.Test.Data;
using Moq;
using System.Collections.Generic;
using System.Linq;

namespace DI.Test
{
    [TestClass]
    public class SchoolTest
    {
        private readonly StandardKernel _ninject;
        public SchoolTest()
        {
            _ninject = new StandardKernel(new TestNinjectModule());
        }

        [TestMethod]
        public void TestAllMethod()
        {
            IRepository<School> repo = _ninject.Get<IRepository<School>>();
            SchoolService service = new SchoolService(repo);
            Assert.IsTrue(service.GetAll().Count == 11);
        }
    }
}

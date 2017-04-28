using DI.Data.Models;
using DI.Data.Repositories;
using DI.Test.Data;
using Ninject.Modules;

public class TestNinjectModule : NinjectModule
{
    public override void Load()
    {
        Bind<IRepository<School>>().To<SchoolRepositoryStub>();
    }
}
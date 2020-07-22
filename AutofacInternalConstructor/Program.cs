using Autofac;
using Core;
using DataService;
using Infrastructure;
using System;

namespace AutofacInternalConstructor
{
    class Program
    {
        public IContainer Container;
        static void Main(string[] args)
        {
            var program = new Program();
            program.Setup();
            program.Run();
        }

        void Run()
        {
            //var repository = Container.Resolve<IRepositoryFacade>();
            //Console.WriteLine(repository.GetData());
            var dataService = Container.Resolve<IDataService>();
            Console.WriteLine(dataService.Get());

            // InternalRepository can be resolved but has only explicitly
            // implemented interface members. Since IInternalRepository is
            // an internal interface you can't cast to it to gain access
            // to its propreties and methods.
            var instance = Container.Resolve<InternalRepository>();
            System.Diagnostics.Debug.Assert(instance != null, "Can't resolve InternalRepository");
        }

        void Setup()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Data>().As<IDataService>();
            builder.RegisterType<RepositoryFacade>().As<IRepositoryFacade>();
            builder.RegisterType<InternalRepository>()
                .FindConstructorsWith(new AllConstructorFinder())
                .AsSelf();

            Container = builder.Build();
        }
    }
}

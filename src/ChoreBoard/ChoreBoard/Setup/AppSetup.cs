using Autofac;
using ChoreBoard.Core;
using ChoreBoard.Core.Providers;
using ChoreBoard.Core.Models;
using ChoreBoard.Data.DataAccess;
using ChoreBoard.Temp;
using ChoreBoard.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Setup
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder builder)
        {
            RegisterCoreTypes(builder);
            RegisterViewModels(builder);
        }

        private void RegisterCoreTypes(ContainerBuilder builder)
        {
            builder.RegisterType<DateTimeProvider>().As<IDateTimeProvider>();
            builder.RegisterType<MockChoreDataStore>().As<IDataService<IChore>>();
            builder.RegisterType<MockCategoryDataStore>().As<IDataService<IChoreCategory>>();

            //Model interfaces
            builder.RegisterType<Chore>().As<IChore>();
            builder.RegisterType<ChoreCategory>().As<IChoreCategory>();
        }

        private void RegisterViewModels(ContainerBuilder builder)
        {
            var viewModelType = typeof(MenuViewModel);

            builder.RegisterAssemblyTypes(viewModelType.Assembly)
                   .Where(type => type.Namespace == viewModelType.Namespace)
                   .AsSelf();
        }
    }
}

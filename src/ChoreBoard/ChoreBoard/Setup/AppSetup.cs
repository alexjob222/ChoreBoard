using Autofac;
using ChoreBoard.Core;
using ChoreBoard.Core.Interfaces;
using ChoreBoard.Data;
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
            RegisterInterfaces(builder);
            RegisterViewModels(builder);
        }

        private void RegisterInterfaces(ContainerBuilder builder)
        {
            builder.RegisterType<DateTimeProvider>().As<IDateTimeProvider>();
            builder.RegisterType<MockChoreDataStore>().As<IDataService<Chore>>();
            builder.RegisterType<MockCategoryDataStore>().As<IDataService<ChoreCategory>>();
        }

        private void RegisterViewModels(ContainerBuilder builder)
        {
            builder.RegisterType<ChoreListViewModel>().AsSelf();
            builder.RegisterType<MenuViewModel>().AsSelf();
            builder.RegisterType<NewChoreViewModel>().AsSelf();
        }
    }
}

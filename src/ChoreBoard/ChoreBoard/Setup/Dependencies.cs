using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Setup
{
    public static class Dependencies
    {
        public static IContainer Container { get; internal set; }

        public static T Resolve<T>()
        {
            using (var scope = Container.BeginLifetimeScope())
            {
                return scope.Resolve<T>();
            }
        }
    }
}

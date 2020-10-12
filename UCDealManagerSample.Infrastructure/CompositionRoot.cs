using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace UCDealManagerSample.Infrastructure
{
    public static class CompositionRoot
    {

        private static Autofac.IContainer _container;

        public static void SetContainer(Autofac.IContainer container)
        {
            _container = container;
        }

        internal static ILifetimeScope BeginLifeTimeScope()
        {
            return _container.BeginLifetimeScope();
        }
    }
}

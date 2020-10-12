using Autofac;
using Autofac.Extensions.DependencyInjection;
using Autofac.Extras.CommonServiceLocator;
using CommonServiceLocator;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace UCDealManagerSample.Infrastructure
{
    public class ApplicationStartup
    {
        public static IServiceProvider Inizialize(IServiceCollection services, string connectionString)
        {
            return RegisterAutofacServiceProvider(services, connectionString);
        }

        private static IServiceProvider RegisterAutofacServiceProvider(IServiceCollection services, string connectionString)
        {
            var containerBuilder = new ContainerBuilder();
            containerBuilder.Populate(services);

            // add module registration

            
            //
            var containeBuilded = containerBuilder.Build();

            ServiceLocator.SetLocatorProvider(() => new AutofacServiceLocator(containeBuilded));

            var autofactServiceProvider = new AutofacServiceProvider(containeBuilded);

            return autofactServiceProvider;

        }
    }
}

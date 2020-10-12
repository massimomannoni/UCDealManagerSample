using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace UCDealManagerSample.Infrastructure.Database
{
    public class DataAccessModule : Autofac.Module
    {
        private readonly string _dataConnectionString;

        public DataAccessModule(string connectionString)
        {
            _dataConnectionString = connectionString;
        }

        protected override void Load(ContainerBuilder builder)
        {
           // register interfaces here
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using TelerikStudy.SofiaCarRentalModel.Entities;

namespace TelerikStudy.SofiaCarRentalModel
{
    public partial class FluentModel : OpenAccessContext, IFluentModelUnitOfWork
    {
        private static string connectionStringName = @"SofiaCarRentalConnection";

        private static BackendConfiguration backend = GetBackendConfiguration();

        private static MetadataSource metadataSource =
            new FluentModelMetadataSource();

        public FluentModel()
            : base(connectionStringName, backend, metadataSource)
        { }

        public FluentModel(string connection)
            : base(connection, backend, metadataSource)
        { }

        public FluentModel(BackendConfiguration backendConfiguration)
            : base(connectionStringName, backendConfiguration, metadataSource)
        { }

        public FluentModel(string connection, MetadataSource metadataSource)
            : base(connection, backend, metadataSource)
        { }

        public FluentModel(string connection,
                           BackendConfiguration backendConfiguration,
                           MetadataSource metadataSource)
            : base(connection, backendConfiguration, metadataSource)
        { }

        public IQueryable<RentalRate> RentalRates
        {
            get
            {
                return this.GetAll<RentalRate>();
            }
        }

        public IQueryable<RentalOrder> RentalOrders
        {
            get
            {
                return this.GetAll<RentalOrder>();
            }
        }

        public IQueryable<Employee> Employees
        {
            get
            {
                return this.GetAll<Employee>();
            }
        }

        public IQueryable<Customer> Customers
        {
            get
            {
                return this.GetAll<Customer>();
            }
        }

        public IQueryable<Category> Categories
        {
            get
            {
                return this.GetAll<Category>();
            }
        }

        public IQueryable<Car> Cars
        {
            get
            {
                return this.GetAll<Car>();
            }
        }

        public static BackendConfiguration GetBackendConfiguration()
        {
            BackendConfiguration backend = new BackendConfiguration();
            backend.Backend = "MsSql";
            backend.ProviderName = "System.Data.SqlClient";

            CustomizeBackendConfiguration(ref backend);

            return backend;
        }

        /// <summary>
        /// Allows you to customize the BackendConfiguration of FluentModel.
        /// </summary>
        /// <param name="config">The BackendConfiguration of FluentModel.</param>
        static partial void CustomizeBackendConfiguration
            (ref BackendConfiguration config);

    }

    public interface IFluentModelUnitOfWork : IUnitOfWork
    {
        IQueryable<RentalRate> RentalRates
        {
            get;
        }
        IQueryable<RentalOrder> RentalOrders
        {
            get;
        }
        IQueryable<Employee> Employees
        {
            get;
        }
        IQueryable<Customer> Customers
        {
            get;
        }
        IQueryable<Category> Categories
        {
            get;
        }
        IQueryable<Car> Cars
        {
            get;
        }
    }
}

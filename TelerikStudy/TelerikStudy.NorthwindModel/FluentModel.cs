using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using TelerikStudy.NorthwindModel.Entities;

namespace TelerikStudy.NorthwindModel
{
    public partial class FluentModel : OpenAccessContext, IFluentModelUnitOfWork
    {
        private static string connectionStringName = @"NorthwindConnection";

        private static BackendConfiguration backend = GetBackendConfiguration();

        private static MetadataSource metadataSource = new FluentModelMetadataSource();

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

        public FluentModel(string connection, BackendConfiguration backendConfiguration, MetadataSource metadataSource)
            : base(connection, backendConfiguration, metadataSource)
        { }

        public IQueryable<Territory> Territories
        {
            get
            {
                return this.GetAll<Territory>();
            }
        }

        public IQueryable<Supplier> Suppliers
        {
            get
            {
                return this.GetAll<Supplier>();
            }
        }

        public IQueryable<Shipper> Shippers
        {
            get
            {
                return this.GetAll<Shipper>();
            }
        }

        public IQueryable<Region> Regions
        {
            get
            {
                return this.GetAll<Region>();
            }
        }

        public IQueryable<Product> Products
        {
            get
            {
                return this.GetAll<Product>();
            }
        }

        public IQueryable<Order> Orders
        {
            get
            {
                return this.GetAll<Order>();
            }
        }

        public IQueryable<OrderDetail> OrderDetails
        {
            get
            {
                return this.GetAll<OrderDetail>();
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

        public IQueryable<CustomerDemographic> CustomerDemographics
        {
            get
            {
                return this.GetAll<CustomerDemographic>();
            }
        }

        public IQueryable<Category> Categories
        {
            get
            {
                return this.GetAll<Category>();
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
        static partial void CustomizeBackendConfiguration(ref BackendConfiguration config);

    }

    public interface IFluentModelUnitOfWork : IUnitOfWork
    {
        IQueryable<Territory> Territories
        {
            get;
        }
        IQueryable<Supplier> Suppliers
        {
            get;
        }
        IQueryable<Shipper> Shippers
        {
            get;
        }
        IQueryable<Region> Regions
        {
            get;
        }
        IQueryable<Product> Products
        {
            get;
        }
        IQueryable<Order> Orders
        {
            get;
        }
        IQueryable<OrderDetail> OrderDetails
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
        IQueryable<CustomerDemographic> CustomerDemographics
        {
            get;
        }
        IQueryable<Category> Categories
        {
            get;
        }
    }
}

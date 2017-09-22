﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Metadata.Fluent;
using TelerikStudy.NorthwindModel.Entities;

namespace TelerikStudy.NorthwindModel
{
    public partial class FluentModelMetadataSource : FluentMetadataSource
    {

        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> mappingConfigurations = new List<MappingConfiguration>();

            MappingConfiguration<Territory> territoryConfiguration = this.GetTerritoryMappingConfiguration();
            mappingConfigurations.Add(territoryConfiguration);

            MappingConfiguration<Supplier> supplierConfiguration = this.GetSupplierMappingConfiguration();
            mappingConfigurations.Add(supplierConfiguration);

            MappingConfiguration<Shipper> shipperConfiguration = this.GetShipperMappingConfiguration();
            mappingConfigurations.Add(shipperConfiguration);

            MappingConfiguration<Region> regionConfiguration = this.GetRegionMappingConfiguration();
            mappingConfigurations.Add(regionConfiguration);

            MappingConfiguration<Product> productConfiguration = this.GetProductMappingConfiguration();
            mappingConfigurations.Add(productConfiguration);

            MappingConfiguration<Order> orderConfiguration = this.GetOrderMappingConfiguration();
            mappingConfigurations.Add(orderConfiguration);

            MappingConfiguration<OrderDetail> orderdetailConfiguration = this.GetOrderDetailMappingConfiguration();
            mappingConfigurations.Add(orderdetailConfiguration);

            MappingConfiguration<Employee> employeeConfiguration = this.GetEmployeeMappingConfiguration();
            mappingConfigurations.Add(employeeConfiguration);

            MappingConfiguration<Customer> customerConfiguration = this.GetCustomerMappingConfiguration();
            mappingConfigurations.Add(customerConfiguration);

            MappingConfiguration<CustomerDemographic> customerdemographicConfiguration = this.GetCustomerDemographicMappingConfiguration();
            mappingConfigurations.Add(customerdemographicConfiguration);

            MappingConfiguration<Category> categoryConfiguration = this.GetCategoryMappingConfiguration();
            mappingConfigurations.Add(categoryConfiguration);

            return mappingConfigurations;
        }

        protected override void SetContainerSettings(MetadataContainer container)
        {
            container.Name = "FluentModel";
            container.DefaultNamespace = "Northwind.Model";
            container.NameGenerator.SourceStrategy = Telerik.OpenAccess.Metadata.NamingSourceStrategy.Property;
            container.NameGenerator.RemoveCamelCase = false;
        }
        public MappingConfiguration<Territory> GetTerritoryMappingConfiguration()
        {
            MappingConfiguration<Territory> configuration = this.GetTerritoryClassConfiguration();
            this.PrepareTerritoryPropertyConfigurations(configuration);
            this.PrepareTerritoryAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Territory> GetTerritoryClassConfiguration()
        {
            MappingConfiguration<Territory> configuration = new MappingConfiguration<Territory>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Territories");

            return configuration;
        }

        public void PrepareTerritoryPropertyConfigurations(MappingConfiguration<Territory> configuration)
        {
            configuration.HasProperty(x => x.TerritoryID).IsIdentity().HasFieldName("_territoryID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("TerritoryID").IsNotNullable().HasColumnType("nvarchar").HasLength(20);
            configuration.HasProperty(x => x.TerritoryDescription).HasFieldName("_territoryDescription").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("TerritoryDescription").IsNotNullable().HasColumnType("nchar").HasLength(50);
            configuration.HasProperty(x => x.RegionID).HasFieldName("_regionID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("RegionID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
        }

        public void PrepareTerritoryAssociationConfigurations(MappingConfiguration<Territory> configuration)
        {
            configuration.HasAssociation(x => x.Region).HasFieldName("_region").WithOpposite(x => x.Territories).ToColumn("RegionID").HasConstraint((x, y) => x.RegionID == y.RegionID).IsRequired().WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Employees).HasFieldName("_employees").WithOpposite(x => x.Territories).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Supplier> GetSupplierMappingConfiguration()
        {
            MappingConfiguration<Supplier> configuration = this.GetSupplierClassConfiguration();
            this.PrepareSupplierPropertyConfigurations(configuration);
            this.PrepareSupplierAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Supplier> GetSupplierClassConfiguration()
        {
            MappingConfiguration<Supplier> configuration = new MappingConfiguration<Supplier>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Suppliers");

            return configuration;
        }

        public void PrepareSupplierPropertyConfigurations(MappingConfiguration<Supplier> configuration)
        {
            configuration.HasProperty(x => x.SupplierID).IsIdentity(KeyGenerator.Autoinc).HasFieldName("_supplierID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("SupplierID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CompanyName).HasFieldName("_companyName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CompanyName").IsNotNullable().HasColumnType("nvarchar").HasLength(40);
            configuration.HasProperty(x => x.ContactName).HasFieldName("_contactName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ContactName").IsNullable().HasColumnType("nvarchar").HasLength(30);
            configuration.HasProperty(x => x.ContactTitle).HasFieldName("_contactTitle").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ContactTitle").IsNullable().HasColumnType("nvarchar").HasLength(30);
            configuration.HasProperty(x => x.Address).HasFieldName("_address").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Address").IsNullable().HasColumnType("nvarchar").HasLength(60);
            configuration.HasProperty(x => x.City).HasFieldName("_city").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("City").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.Region).HasFieldName("_region").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Region").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.PostalCode).HasFieldName("_postalCode").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("PostalCode").IsNullable().HasColumnType("nvarchar").HasLength(10);
            configuration.HasProperty(x => x.Country).HasFieldName("_country").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Country").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.Phone).HasFieldName("_phone").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Phone").IsNullable().HasColumnType("nvarchar").HasLength(24);
            configuration.HasProperty(x => x.Fax).HasFieldName("_fax").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Fax").IsNullable().HasColumnType("nvarchar").HasLength(24);
            configuration.HasProperty(x => x.HomePage).HasFieldName("_homePage").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("HomePage").IsNullable().HasColumnType("ntext").HasLength(0);
        }

        public void PrepareSupplierAssociationConfigurations(MappingConfiguration<Supplier> configuration)
        {
            configuration.HasAssociation(x => x.Products).HasFieldName("_products").WithOpposite(x => x.Supplier).ToColumn("SupplierID").HasConstraint((y, x) => x.SupplierID == y.SupplierID).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Shipper> GetShipperMappingConfiguration()
        {
            MappingConfiguration<Shipper> configuration = this.GetShipperClassConfiguration();
            this.PrepareShipperPropertyConfigurations(configuration);
            this.PrepareShipperAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Shipper> GetShipperClassConfiguration()
        {
            MappingConfiguration<Shipper> configuration = new MappingConfiguration<Shipper>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Shippers");

            return configuration;
        }

        public void PrepareShipperPropertyConfigurations(MappingConfiguration<Shipper> configuration)
        {
            configuration.HasProperty(x => x.ShipperID).IsIdentity(KeyGenerator.Autoinc).HasFieldName("_shipperID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipperID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CompanyName).HasFieldName("_companyName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CompanyName").IsNotNullable().HasColumnType("nvarchar").HasLength(40);
            configuration.HasProperty(x => x.Phone).HasFieldName("_phone").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Phone").IsNullable().HasColumnType("nvarchar").HasLength(24);
        }

        public void PrepareShipperAssociationConfigurations(MappingConfiguration<Shipper> configuration)
        {
            configuration.HasAssociation(x => x.Orders).HasFieldName("_orders").WithOpposite(x => x.Shipper).ToColumn("ShipVia").HasConstraint((y, x) => x.ShipVia == y.ShipperID).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Region> GetRegionMappingConfiguration()
        {
            MappingConfiguration<Region> configuration = this.GetRegionClassConfiguration();
            this.PrepareRegionPropertyConfigurations(configuration);
            this.PrepareRegionAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Region> GetRegionClassConfiguration()
        {
            MappingConfiguration<Region> configuration = new MappingConfiguration<Region>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Region");

            return configuration;
        }

        public void PrepareRegionPropertyConfigurations(MappingConfiguration<Region> configuration)
        {
            configuration.HasProperty(x => x.RegionID).IsIdentity().HasFieldName("_regionID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("RegionID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.RegionDescription).HasFieldName("_regionDescription").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("RegionDescription").IsNotNullable().HasColumnType("nchar").HasLength(50);
        }

        public void PrepareRegionAssociationConfigurations(MappingConfiguration<Region> configuration)
        {
            configuration.HasAssociation(x => x.Territories).HasFieldName("_territories").WithOpposite(x => x.Region).ToColumn("RegionID").HasConstraint((y, x) => x.RegionID == y.RegionID).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Product> GetProductMappingConfiguration()
        {
            MappingConfiguration<Product> configuration = this.GetProductClassConfiguration();
            this.PrepareProductPropertyConfigurations(configuration);
            this.PrepareProductAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Product> GetProductClassConfiguration()
        {
            MappingConfiguration<Product> configuration = new MappingConfiguration<Product>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Products");

            return configuration;
        }

        public void PrepareProductPropertyConfigurations(MappingConfiguration<Product> configuration)
        {
            configuration.HasProperty(x => x.ProductID).IsIdentity(KeyGenerator.Autoinc).HasFieldName("_productID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ProductID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.ProductName).HasFieldName("_productName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ProductName").IsNotNullable().HasColumnType("nvarchar").HasLength(40);
            configuration.HasProperty(x => x.SupplierID).HasFieldName("_supplierID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("SupplierID").IsNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CategoryID).HasFieldName("_categoryID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CategoryID").IsNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.QuantityPerUnit).HasFieldName("_quantityPerUnit").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("QuantityPerUnit").IsNullable().HasColumnType("nvarchar").HasLength(20);
            configuration.HasProperty(x => x.UnitPrice).HasFieldName("_unitPrice").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("UnitPrice").IsNullable().HasColumnType("money").HasPrecision(0).HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.UnitsInStock).HasFieldName("_unitsInStock").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("UnitsInStock").IsNullable().HasColumnType("smallint").HasPrecision(0).HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.UnitsOnOrder).HasFieldName("_unitsOnOrder").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("UnitsOnOrder").IsNullable().HasColumnType("smallint").HasPrecision(0).HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.ReorderLevel).HasFieldName("_reorderLevel").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ReorderLevel").IsNullable().HasColumnType("smallint").HasPrecision(0).HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.Discontinued).HasFieldName("_discontinued").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Discontinued").IsNotNullable().HasColumnType("bit").HasPrecision(0).HasScale(0).HasDefaultValue();
        }

        public void PrepareProductAssociationConfigurations(MappingConfiguration<Product> configuration)
        {
            configuration.HasAssociation(x => x.Category).HasFieldName("_category").WithOpposite(x => x.Products).ToColumn("CategoryID").HasConstraint((x, y) => x.CategoryID == y.CategoryID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Supplier).HasFieldName("_supplier").WithOpposite(x => x.Products).ToColumn("SupplierID").HasConstraint((x, y) => x.SupplierID == y.SupplierID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.OrderDetails).HasFieldName("_orderDetails").WithOpposite(x => x.Product).ToColumn("ProductID").HasConstraint((y, x) => x.ProductID == y.ProductID).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Order> GetOrderMappingConfiguration()
        {
            MappingConfiguration<Order> configuration = this.GetOrderClassConfiguration();
            this.PrepareOrderPropertyConfigurations(configuration);
            this.PrepareOrderAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Order> GetOrderClassConfiguration()
        {
            MappingConfiguration<Order> configuration = new MappingConfiguration<Order>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Orders");

            return configuration;
        }

        public void PrepareOrderPropertyConfigurations(MappingConfiguration<Order> configuration)
        {
            configuration.HasProperty(x => x.OrderID).IsIdentity(KeyGenerator.Autoinc).HasFieldName("_orderID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("OrderID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CustomerID).HasFieldName("_customerID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CustomerID").IsNullable().HasColumnType("nchar").HasLength(5);
            configuration.HasProperty(x => x.EmployeeID).HasFieldName("_employeeID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("EmployeeID").IsNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.OrderDate).HasFieldName("_orderDate").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("OrderDate").IsNullable().HasColumnType("datetime");
            configuration.HasProperty(x => x.RequiredDate).HasFieldName("_requiredDate").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("RequiredDate").IsNullable().HasColumnType("datetime");
            configuration.HasProperty(x => x.ShippedDate).HasFieldName("_shippedDate").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShippedDate").IsNullable().HasColumnType("datetime");
            configuration.HasProperty(x => x.ShipVia).HasFieldName("_shipVia").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipVia").IsNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Freight).HasFieldName("_freight").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Freight").IsNullable().HasColumnType("money").HasPrecision(0).HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.ShipName).HasFieldName("_shipName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipName").IsNullable().HasColumnType("nvarchar").HasLength(40);
            configuration.HasProperty(x => x.ShipAddress).HasFieldName("_shipAddress").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipAddress").IsNullable().HasColumnType("nvarchar").HasLength(60);
            configuration.HasProperty(x => x.ShipCity).HasFieldName("_shipCity").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipCity").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.ShipRegion).HasFieldName("_shipRegion").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipRegion").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.ShipPostalCode).HasFieldName("_shipPostalCode").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipPostalCode").IsNullable().HasColumnType("nvarchar").HasLength(10);
            configuration.HasProperty(x => x.ShipCountry).HasFieldName("_shipCountry").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ShipCountry").IsNullable().HasColumnType("nvarchar").HasLength(15);
        }

        public void PrepareOrderAssociationConfigurations(MappingConfiguration<Order> configuration)
        {
            configuration.HasAssociation(x => x.Customer).HasFieldName("_customer").WithOpposite(x => x.Orders).ToColumn("CustomerID").HasConstraint((x, y) => x.CustomerID == y.CustomerID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Employee).HasFieldName("_employee").WithOpposite(x => x.Orders).ToColumn("EmployeeID").HasConstraint((x, y) => x.EmployeeID == y.EmployeeID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Shipper).HasFieldName("_shipper").WithOpposite(x => x.Orders).ToColumn("ShipVia").HasConstraint((x, y) => x.ShipVia == y.ShipperID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.OrderDetails).HasFieldName("_orderDetails").WithOpposite(x => x.Order).ToColumn("OrderID").HasConstraint((y, x) => x.OrderID == y.OrderID).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<OrderDetail> GetOrderDetailMappingConfiguration()
        {
            MappingConfiguration<OrderDetail> configuration = this.GetOrderDetailClassConfiguration();
            this.PrepareOrderDetailPropertyConfigurations(configuration);
            this.PrepareOrderDetailAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<OrderDetail> GetOrderDetailClassConfiguration()
        {
            MappingConfiguration<OrderDetail> configuration = new MappingConfiguration<OrderDetail>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Order Details");

            return configuration;
        }

        public void PrepareOrderDetailPropertyConfigurations(MappingConfiguration<OrderDetail> configuration)
        {
            configuration.HasProperty(x => x.OrderID).IsIdentity().HasFieldName("_orderID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("OrderID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.ProductID).IsIdentity().HasFieldName("_productID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ProductID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.UnitPrice).HasFieldName("_unitPrice").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("UnitPrice").IsNotNullable().HasColumnType("money").HasPrecision(0).HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.Quantity).HasFieldName("_quantity").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Quantity").IsNotNullable().HasColumnType("smallint").HasPrecision(0).HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.Discount).HasFieldName("_discount").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Discount").IsNotNullable().HasColumnType("real").HasPrecision(0).HasScale(0).HasDefaultValue();
        }

        public void PrepareOrderDetailAssociationConfigurations(MappingConfiguration<OrderDetail> configuration)
        {
            configuration.HasAssociation(x => x.Order).HasFieldName("_order").WithOpposite(x => x.OrderDetails).ToColumn("OrderID").HasConstraint((x, y) => x.OrderID == y.OrderID).IsRequired().WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Product).HasFieldName("_product").WithOpposite(x => x.OrderDetails).ToColumn("ProductID").HasConstraint((x, y) => x.ProductID == y.ProductID).IsRequired().WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Employee> GetEmployeeMappingConfiguration()
        {
            MappingConfiguration<Employee> configuration = this.GetEmployeeClassConfiguration();
            this.PrepareEmployeePropertyConfigurations(configuration);
            this.PrepareEmployeeAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Employee> GetEmployeeClassConfiguration()
        {
            MappingConfiguration<Employee> configuration = new MappingConfiguration<Employee>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Employees");

            return configuration;
        }

        public void PrepareEmployeePropertyConfigurations(MappingConfiguration<Employee> configuration)
        {
            configuration.HasProperty(x => x.EmployeeID).IsIdentity(KeyGenerator.Autoinc).HasFieldName("_employeeID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("EmployeeID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.LastName).HasFieldName("_lastName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("LastName").IsNotNullable().HasColumnType("nvarchar").HasLength(20);
            configuration.HasProperty(x => x.FirstName).HasFieldName("_firstName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("FirstName").IsNotNullable().HasColumnType("nvarchar").HasLength(10);
            configuration.HasProperty(x => x.Title).HasFieldName("_title").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Title").IsNullable().HasColumnType("nvarchar").HasLength(30);
            configuration.HasProperty(x => x.TitleOfCourtesy).HasFieldName("_titleOfCourtesy").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("TitleOfCourtesy").IsNullable().HasColumnType("nvarchar").HasLength(25);
            configuration.HasProperty(x => x.BirthDate).HasFieldName("_birthDate").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("BirthDate").IsNullable().HasColumnType("datetime");
            configuration.HasProperty(x => x.HireDate).HasFieldName("_hireDate").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("HireDate").IsNullable().HasColumnType("datetime");
            configuration.HasProperty(x => x.Address).HasFieldName("_address").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Address").IsNullable().HasColumnType("nvarchar").HasLength(60);
            configuration.HasProperty(x => x.City).HasFieldName("_city").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("City").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.Region).HasFieldName("_region").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Region").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.PostalCode).HasFieldName("_postalCode").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("PostalCode").IsNullable().HasColumnType("nvarchar").HasLength(10);
            configuration.HasProperty(x => x.Country).HasFieldName("_country").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Country").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.HomePhone).HasFieldName("_homePhone").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("HomePhone").IsNullable().HasColumnType("nvarchar").HasLength(24);
            configuration.HasProperty(x => x.Extension).HasFieldName("_extension").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Extension").IsNullable().HasColumnType("nvarchar").HasLength(4);
            configuration.HasProperty(x => x.Photo).HasFieldName("_photo").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Photo").IsNullable().HasColumnType("image");
            configuration.HasProperty(x => x.Notes).HasFieldName("_notes").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Notes").IsNullable().HasColumnType("ntext").HasLength(0);
            configuration.HasProperty(x => x.ReportsTo).HasFieldName("_reportsTo").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ReportsTo").IsNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.PhotoPath).HasFieldName("_photoPath").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("PhotoPath").IsNullable().HasColumnType("nvarchar").HasLength(255);
        }

        public void PrepareEmployeeAssociationConfigurations(MappingConfiguration<Employee> configuration)
        {
            configuration.HasAssociation(x => x.Orders).HasFieldName("_orders").WithOpposite(x => x.Employee).ToColumn("EmployeeID").HasConstraint((y, x) => x.EmployeeID == y.EmployeeID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Employee1).HasFieldName("_employee1").WithOpposite(x => x.Employees).ToColumn("ReportsTo").HasConstraint((x, y) => x.ReportsTo == y.EmployeeID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Employees).HasFieldName("_employees").WithOpposite(x => x.Employee1).ToColumn("ReportsTo").HasConstraint((y, x) => x.ReportsTo == y.EmployeeID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Territories).HasFieldName("_territories").WithOpposite(x => x.Employees).WithDataAccessKind(DataAccessKind.ReadWrite).MapJoinTable("EmployeeTerritories", (x, y) => new { EmployeeID = x.EmployeeID, TerritoryID = y.TerritoryID }).CreatePrimaryKeyFromForeignKeys();
        }

        public MappingConfiguration<Customer> GetCustomerMappingConfiguration()
        {
            MappingConfiguration<Customer> configuration = this.GetCustomerClassConfiguration();
            this.PrepareCustomerPropertyConfigurations(configuration);
            this.PrepareCustomerAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Customer> GetCustomerClassConfiguration()
        {
            MappingConfiguration<Customer> configuration = new MappingConfiguration<Customer>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Customers");

            return configuration;
        }

        public void PrepareCustomerPropertyConfigurations(MappingConfiguration<Customer> configuration)
        {
            configuration.HasProperty(x => x.CustomerID).IsIdentity().HasFieldName("_customerID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CustomerID").IsNotNullable().HasColumnType("nchar").HasLength(5);
            configuration.HasProperty(x => x.CompanyName).HasFieldName("_companyName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CompanyName").IsNotNullable().HasColumnType("nvarchar").HasLength(40);
            configuration.HasProperty(x => x.ContactName).HasFieldName("_contactName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ContactName").IsNullable().HasColumnType("nvarchar").HasLength(30);
            configuration.HasProperty(x => x.ContactTitle).HasFieldName("_contactTitle").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("ContactTitle").IsNullable().HasColumnType("nvarchar").HasLength(30);
            configuration.HasProperty(x => x.Address).HasFieldName("_address").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Address").IsNullable().HasColumnType("nvarchar").HasLength(60);
            configuration.HasProperty(x => x.City).HasFieldName("_city").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("City").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.Region).HasFieldName("_region").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Region").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.PostalCode).HasFieldName("_postalCode").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("PostalCode").IsNullable().HasColumnType("nvarchar").HasLength(10);
            configuration.HasProperty(x => x.Country).HasFieldName("_country").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Country").IsNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.Phone).HasFieldName("_phone").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Phone").IsNullable().HasColumnType("nvarchar").HasLength(24);
            configuration.HasProperty(x => x.Fax).HasFieldName("_fax").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Fax").IsNullable().HasColumnType("nvarchar").HasLength(24);
        }

        public void PrepareCustomerAssociationConfigurations(MappingConfiguration<Customer> configuration)
        {
            configuration.HasAssociation(x => x.Orders).HasFieldName("_orders").WithOpposite(x => x.Customer).ToColumn("CustomerID").HasConstraint((y, x) => x.CustomerID == y.CustomerID).WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.CustomerDemographics).HasFieldName("_customerDemographics").WithOpposite(x => x.Customers).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<CustomerDemographic> GetCustomerDemographicMappingConfiguration()
        {
            MappingConfiguration<CustomerDemographic> configuration = this.GetCustomerDemographicClassConfiguration();
            this.PrepareCustomerDemographicPropertyConfigurations(configuration);
            this.PrepareCustomerDemographicAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<CustomerDemographic> GetCustomerDemographicClassConfiguration()
        {
            MappingConfiguration<CustomerDemographic> configuration = new MappingConfiguration<CustomerDemographic>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("CustomerDemographics");

            return configuration;
        }

        public void PrepareCustomerDemographicPropertyConfigurations(MappingConfiguration<CustomerDemographic> configuration)
        {
            configuration.HasProperty(x => x.CustomerTypeID).IsIdentity().HasFieldName("_customerTypeID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CustomerTypeID").IsNotNullable().HasColumnType("nchar").HasLength(10);
            configuration.HasProperty(x => x.CustomerDesc).HasFieldName("_customerDesc").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CustomerDesc").IsNullable().HasColumnType("ntext").HasLength(0);
        }

        public void PrepareCustomerDemographicAssociationConfigurations(MappingConfiguration<CustomerDemographic> configuration)
        {
            configuration.HasAssociation(x => x.Customers).HasFieldName("_customers").WithOpposite(x => x.CustomerDemographics).WithDataAccessKind(DataAccessKind.ReadWrite).MapJoinTable("CustomerCustomerDemo", (x, y) => new { CustomerTypeID = x.CustomerTypeID, CustomerID = y.CustomerID }).CreatePrimaryKeyFromForeignKeys();
        }

        public MappingConfiguration<Category> GetCategoryMappingConfiguration()
        {
            MappingConfiguration<Category> configuration = this.GetCategoryClassConfiguration();
            this.PrepareCategoryPropertyConfigurations(configuration);
            this.PrepareCategoryAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Category> GetCategoryClassConfiguration()
        {
            MappingConfiguration<Category> configuration = new MappingConfiguration<Category>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("Categories");

            return configuration;
        }

        public void PrepareCategoryPropertyConfigurations(MappingConfiguration<Category> configuration)
        {
            configuration.HasProperty(x => x.CategoryID).IsIdentity(KeyGenerator.Autoinc).HasFieldName("_categoryID").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CategoryID").IsNotNullable().HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CategoryName).HasFieldName("_categoryName").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("CategoryName").IsNotNullable().HasColumnType("nvarchar").HasLength(15);
            configuration.HasProperty(x => x.Description).HasFieldName("_description").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Description").IsNullable().HasColumnType("ntext").HasLength(0);
            configuration.HasProperty(x => x.Picture).HasFieldName("_picture").WithDataAccessKind(DataAccessKind.ReadWrite).ToColumn("Picture").IsNullable().HasColumnType("image");
        }

        public void PrepareCategoryAssociationConfigurations(MappingConfiguration<Category> configuration)
        {
            configuration.HasAssociation(x => x.Products).HasFieldName("_products").WithOpposite(x => x.Category).ToColumn("CategoryID").HasConstraint((y, x) => x.CategoryID == y.CategoryID).WithDataAccessKind(DataAccessKind.ReadWrite);
        }

    }
}

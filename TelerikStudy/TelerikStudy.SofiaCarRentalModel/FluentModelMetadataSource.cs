﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Metadata.Fluent;
using TelerikStudy.SofiaCarRentalModel.Entities;

namespace TelerikStudy.SofiaCarRentalModel
{
    public class FluentModelMetadataSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> mappingConfigurations = new List<MappingConfiguration>();
            
            MappingConfiguration<RentalRate> rentalrateConfiguration =
            this.GetRentalRateMappingConfiguration();
            mappingConfigurations.Add(rentalrateConfiguration);

            MappingConfiguration<RentalOrder> rentalorderConfiguration =
                this.GetRentalOrderMappingConfiguration();
            mappingConfigurations.Add(rentalorderConfiguration);

            MappingConfiguration<Employee> employeeConfiguration =
                this.GetEmployeeMappingConfiguration();
            mappingConfigurations.Add(employeeConfiguration);

            MappingConfiguration<Customer> customerConfiguration =
                this.GetCustomerMappingConfiguration();
            mappingConfigurations.Add(customerConfiguration);

            MappingConfiguration<Category> categoryConfiguration =
                this.GetCategoryMappingConfiguration();
            mappingConfigurations.Add(categoryConfiguration);

            MappingConfiguration<Car> carConfiguration =
                this.GetCarMappingConfiguration();
            mappingConfigurations.Add(carConfiguration);


            return mappingConfigurations;
        }

        protected override void SetContainerSettings(MetadataContainer container)
        {
            container.NameGenerator.SourceStrategy = NamingSourceStrategy.Property;
            container.NameGenerator.RemoveCamelCase = false;
            container.NameGenerator.ResolveReservedWords = false;
        }

        public MappingConfiguration<RentalRate> GetRentalRateMappingConfiguration()
        {
            MappingConfiguration<RentalRate> configuration = GetRentalRateClassConfiguration();
            this.PrepareRentalRatePropertyConfigurations(configuration);
            this.PrepareRentalRateAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<RentalRate> GetRentalRateClassConfiguration()
        {
            MappingConfiguration<RentalRate> configuration = new MappingConfiguration<RentalRate>();
            configuration.MapType(x => new { }).WithConcurencyControl(OptimisticConcurrencyControlStrategy.Changed).ToTable("RentalRates");
            return configuration;
        }

        public void PrepareRentalRatePropertyConfigurations(MappingConfiguration<RentalRate> configuration)
        {
            configuration.HasProperty(x => x.RentalRateID).
                IsIdentity(KeyGenerator.Autoinc).
                HasFieldName("_rentalRateID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("RentalRateID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CategoryID).
                HasFieldName("_categoryID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CategoryID").IsNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Daily).
                HasFieldName("_daily").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Daily").IsNullable().
                HasColumnType("smallmoney").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Weekly).
                HasFieldName("_weekly").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Weekly").IsNullable().
                HasColumnType("smallmoney").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Monthly).
                HasFieldName("_monthly").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Monthly").IsNullable().
                HasColumnType("smallmoney").HasPrecision(0).HasScale(0);
        }

        public void PrepareRentalRateAssociationConfigurations(MappingConfiguration<RentalRate> configuration)
        {
            configuration.HasAssociation(x => x.Category).
                HasFieldName("_category").WithOpposite(x => x.RentalRates).
                ToColumn("CategoryID").
                HasConstraint((x, y) => x.CategoryID == y.CategoryID).
                WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<RentalOrder> GetRentalOrderMappingConfiguration()
        {
            MappingConfiguration<RentalOrder> configuration =
                this.GetRentalOrderClassConfiguration();
            this.PrepareRentalOrderPropertyConfigurations(configuration);
            this.PrepareRentalOrderAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<RentalOrder> GetRentalOrderClassConfiguration()
        {
            MappingConfiguration<RentalOrder> configuration =
                new MappingConfiguration<RentalOrder>();
            configuration.
                MapType(x => new { }).
                WithConcurencyControl(OptimisticConcurrencyControlStrategy.
                    Changed)
                .ToTable("RentalOrders");

            return configuration;
        }

        public void PrepareRentalOrderPropertyConfigurations(MappingConfiguration<RentalOrder> configuration)
        {
            configuration.HasProperty(x => x.RentalOrderID).
                IsIdentity(KeyGenerator.Autoinc).
                HasFieldName("_rentalOrderID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("RentalOrderID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.DateProcessed).
                HasFieldName("_dateProcessed").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("DateProcessed").IsNullable().
                HasColumnType("datetime");
            configuration.HasProperty(x => x.EmployeeID).
                HasFieldName("_employeeID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("EmployeeID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CustomerID).
                HasFieldName("_customerID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CustomerID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CarID).
                HasFieldName("_carID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CarID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.TankLevel).
                HasFieldName("_tankLevel").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("TankLevel").IsNullable().
                HasColumnType("varchar").HasLength(40);
            configuration.HasProperty(x => x.MileageStart).
                HasFieldName("_mileageStart").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("MileageStart").IsNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.MileageEnd).
                HasFieldName("_mileageEnd").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("MileageEnd").IsNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.RentStartDate).
                HasFieldName("_rentStartDate").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("RentStartDate").IsNotNullable().
                HasColumnType("datetime");
            configuration.HasProperty(x => x.RentEndDate).
                HasFieldName("_rentEndDate").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("RentEndDate").IsNotNullable().
                HasColumnType("datetime");
            configuration.HasProperty(x => x.Days).
                HasFieldName("_days").
                WithDataAccessKind(DataAccessKind.ReadOnly).
                ToColumn("Days").IsNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.RateApplied).
                HasFieldName("_rateApplied").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("RateApplied").IsNullable().
                HasColumnType("money").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.OrderTotal).
                HasFieldName("_orderTotal").
                WithDataAccessKind(DataAccessKind.ReadOnly).
                ToColumn("OrderTotal").IsNullable().
                HasColumnType("money").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.OrderStatus).
                HasFieldName("_orderStatus").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("OrderStatus").IsNullable().
                HasColumnType("varchar").HasLength(50);
        }

        public void PrepareRentalOrderAssociationConfigurations(MappingConfiguration<RentalOrder> configuration)
        {
            configuration.HasAssociation(x => x.Car).
                HasFieldName("_car").WithOpposite(x => x.RentalOrders).
                ToColumn("CarID").
                HasConstraint((x, y) => x.CarID == y.CarID).
                IsRequired().WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Customer).
                HasFieldName("_customer").WithOpposite(x => x.RentalOrders).
                ToColumn("CustomerID").
                HasConstraint((x, y) => x.CustomerID == y.CustomerID).
                IsRequired().WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Employee).
                HasFieldName("_employee").
                WithOpposite(x => x.RentalOrders).
                ToColumn("EmployeeID").
                HasConstraint((x, y) => x.EmployeeID == y.EmployeeID).
                IsRequired().WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Employee> GetEmployeeMappingConfiguration()
        {
            MappingConfiguration<Employee> configuration =
                this.GetEmployeeClassConfiguration();
            this.PrepareEmployeePropertyConfigurations(configuration);
            this.PrepareEmployeeAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Employee> GetEmployeeClassConfiguration()
        {
            MappingConfiguration<Employee> configuration =
                new MappingConfiguration<Employee>();
            configuration.
                MapType(x => new { }).
                WithConcurencyControl(OptimisticConcurrencyControlStrategy.
                    Changed).
                ToTable("Employees");

            return configuration;
        }

        public void PrepareEmployeePropertyConfigurations(MappingConfiguration<Employee> configuration)
        {
            configuration.HasProperty(x => x.EmployeeID).
                IsIdentity(KeyGenerator.Autoinc).
                HasFieldName("_employeeID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("EmployeeID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.EmployeeNumber).
                HasFieldName("_employeeNumber").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("EmployeeNumber").IsNullable().
                HasColumnType("nchar").HasLength(5);
            configuration.HasProperty(x => x.FirstName).
                HasFieldName("_firstName").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("FirstName").IsNullable().
                HasColumnType("varchar").HasLength(32);
            configuration.HasProperty(x => x.LastName).
                HasFieldName("_lastName").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("LastName").IsNotNullable().
                HasColumnType("varchar").HasLength(32);
            configuration.HasProperty(x => x.FullName).
                HasFieldName("_fullName").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("FullName").IsNullable().
                HasColumnType("varchar").HasLength(66);
            configuration.HasProperty(x => x.Title).
                HasFieldName("_title").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Title").IsNullable().
                HasColumnType("varchar").HasLength(80);
            configuration.HasProperty(x => x.HourlySalary).
                HasFieldName("_hourlySalary").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("HourlySalary").IsNullable().
                HasColumnType("smallmoney").HasPrecision(0).HasScale(0);
        }

        public void PrepareEmployeeAssociationConfigurations(MappingConfiguration<Employee> configuration)
        {
            configuration.HasAssociation(x => x.RentalOrders).
                HasFieldName("_rentalOrders").
                WithOpposite(x => x.Employee).ToColumn("EmployeeID").
                HasConstraint((y, x) => x.EmployeeID == y.EmployeeID).
                WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Customer> GetCustomerMappingConfiguration()
        {
            MappingConfiguration<Customer> configuration =
                this.GetCustomerClassConfiguration();
            this.PrepareCustomerPropertyConfigurations(configuration);
            this.PrepareCustomerAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Customer> GetCustomerClassConfiguration()
        {
            MappingConfiguration<Customer> configuration =
                new MappingConfiguration<Customer>();
            configuration.
                MapType(x => new { }).
                WithConcurencyControl(OptimisticConcurrencyControlStrategy.
                    Changed).
                ToTable("Customers");

            return configuration;
        }

        public void PrepareCustomerPropertyConfigurations(MappingConfiguration<Customer> configuration)
        {
            configuration.HasProperty(x => x.CustomerID).
                IsIdentity(KeyGenerator.Autoinc).
                HasFieldName("_customerID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CustomerID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.DrvLicNumber).
                HasFieldName("_drvLicNumber").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("DrvLicNumber").IsNullable().
                HasColumnType("varchar").HasLength(50);
            configuration.HasProperty(x => x.FullName).
                HasFieldName("_fullName").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("FullName").IsNullable().
                HasColumnType("varchar").HasLength(80);
            configuration.HasProperty(x => x.Address).
                HasFieldName("_address").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Address").IsNotNullable().
                HasColumnType("varchar").HasLength(100);
            configuration.HasProperty(x => x.Country).
                HasFieldName("_country").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Country").IsNotNullable().
                HasColumnType("varchar").HasLength(100);
            configuration.HasProperty(x => x.City).
                HasFieldName("_city").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("City").IsNullable().
                HasColumnType("varchar").HasLength(50);
            configuration.HasProperty(x => x.State).
                HasFieldName("_state").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("State").IsNullable().
                HasColumnType("varchar").HasLength(50);
            configuration.HasProperty(x => x.ZIPCode).
                HasFieldName("_zIPCode").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("ZIPCode").IsNullable().
                HasColumnType("varchar").HasLength(20);
        }

        public void PrepareCustomerAssociationConfigurations(MappingConfiguration<Customer> configuration)
        {
            configuration.HasAssociation(x => x.RentalOrders).
                HasFieldName("_rentalOrders").
                WithOpposite(x => x.Customer).ToColumn("CustomerID").
                HasConstraint((y, x) => x.CustomerID == y.CustomerID).
                WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Category> GetCategoryMappingConfiguration()
        {
            MappingConfiguration<Category> configuration =
                this.GetCategoryClassConfiguration();
            this.PrepareCategoryPropertyConfigurations(configuration);
            this.PrepareCategoryAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Category> GetCategoryClassConfiguration()
        {
            MappingConfiguration<Category> configuration =
                new MappingConfiguration<Category>();
            configuration.
                MapType(x => new { }).
                WithConcurencyControl(OptimisticConcurrencyControlStrategy.
                    Changed).
                ToTable("Categories");

            return configuration;
        }

        public void PrepareCategoryPropertyConfigurations(MappingConfiguration<Category> configuration)
        {
            configuration.HasProperty(x => x.CategoryID).
                IsIdentity(KeyGenerator.Autoinc).
                HasFieldName("_categoryID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CategoryID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CategoryName).
                HasFieldName("_categoryName").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CategoryName").IsNotNullable().
                HasColumnType("varchar").HasLength(50);
            configuration.HasProperty(x => x.ImageFileName).
                HasFieldName("_imageFileName").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("ImageFileName").IsNullable().
                HasColumnType("varchar").HasLength(256).HasDefaultValue();
        }

        public void PrepareCategoryAssociationConfigurations(MappingConfiguration<Category> configuration)
        {
            configuration.HasAssociation(x => x.RentalRates).
                HasFieldName("_rentalRates").
                WithOpposite(x => x.Category).ToColumn("CategoryID").
                HasConstraint((y, x) => x.CategoryID == y.CategoryID).
                WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Cars).
                HasFieldName("_cars").
                WithOpposite(x => x.Category).ToColumn("CategoryID").
                HasConstraint((y, x) => x.CategoryID == y.CategoryID).
                WithDataAccessKind(DataAccessKind.ReadWrite);
        }

        public MappingConfiguration<Car> GetCarMappingConfiguration()
        {
            MappingConfiguration<Car> configuration =
                this.GetCarClassConfiguration();
            this.PrepareCarPropertyConfigurations(configuration);
            this.PrepareCarAssociationConfigurations(configuration);

            return configuration;
        }

        public MappingConfiguration<Car> GetCarClassConfiguration()
        {
            MappingConfiguration<Car> configuration =
                new MappingConfiguration<Car>();
            configuration.
                MapType(x => new { }).
                WithConcurencyControl(OptimisticConcurrencyControlStrategy.
                    Changed).
                ToTable("Cars");

            return configuration;
        }

        public void PrepareCarPropertyConfigurations(MappingConfiguration<Car> configuration)
        {
            configuration.HasProperty(x => x.CarID).
                IsIdentity(KeyGenerator.Autoinc).
                HasFieldName("_carID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CarID").IsNotNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.TagNumber).
                HasFieldName("_tagNumber").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("TagNumber").IsNotNullable().
                HasColumnType("varchar").HasLength(20);
            configuration.HasProperty(x => x.Make).
                HasFieldName("_make").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Make").IsNullable().
                HasColumnType("varchar").HasLength(50);
            configuration.HasProperty(x => x.Model).
                HasFieldName("_model").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Model").IsNotNullable().
                HasColumnType("varchar").HasLength(50);
            configuration.HasProperty(x => x.CarYear).
                HasFieldName("_carYear").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CarYear").IsNullable().
                HasColumnType("smallint").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.CategoryID).
                HasFieldName("_categoryID").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("CategoryID").IsNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Mp3Player).
                HasFieldName("_mp3Player").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Mp3Player").IsNullable().
                HasColumnType("bit").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.DVDPlayer).
                HasFieldName("_dVDPlayer").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("DVDPlayer").IsNullable().
                HasColumnType("bit").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.AirConditioner).
                HasFieldName("_airConditioner").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("AirConditioner").IsNullable().
                HasColumnType("bit").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.ABS).
                HasFieldName("_aBS").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("ABS").IsNullable().
                HasColumnType("bit").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.ASR).
                HasFieldName("_aSR").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("ASR").IsNullable().
                HasColumnType("bit").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Navigation).
                HasFieldName("_navigation").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Navigation").IsNullable().
                HasColumnType("bit").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Available).
                HasFieldName("_available").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Available").IsNullable().
                HasColumnType("bit").HasPrecision(0).HasScale(0);
            configuration.HasProperty(x => x.Latitude).
                HasFieldName("_latitude").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Latitude").IsNullable().
                HasColumnType("float").HasPrecision(0).
                HasScale(0).HasDefaultValue();
            configuration.HasProperty(x => x.Longitude).
                HasFieldName("_longitude").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Longitude").IsNullable().
                HasColumnType("float").HasPrecision(0).HasScale(0).
                HasDefaultValue();
            configuration.HasProperty(x => x.ImageFileName).
                HasFieldName("_imageFileName").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("ImageFileName").IsNullable().
                HasColumnType("varchar").HasLength(256).HasDefaultValue();
            configuration.HasProperty(x => x.Rating).
                HasFieldName("_rating").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("Rating").IsNullable().
                HasColumnType("decimal").
                HasPrecision(9).HasScale(2).HasDefaultValue();
            configuration.HasProperty(x => x.NumberOfRatings).
                HasFieldName("_numberOfRatings").
                WithDataAccessKind(DataAccessKind.ReadWrite).
                ToColumn("NumberOfRatings").IsNullable().
                HasColumnType("int").HasPrecision(0).HasScale(0).
                HasDefaultValue();
        }

        public void PrepareCarAssociationConfigurations(MappingConfiguration<Car> configuration)
        {
            configuration.HasAssociation(x => x.RentalOrders).
                HasFieldName("_rentalOrders").
                WithOpposite(x => x.Car).ToColumn("CarID").
                HasConstraint((y, x) => x.CarID == y.CarID).
                WithDataAccessKind(DataAccessKind.ReadWrite);
            configuration.HasAssociation(x => x.Category).
                HasFieldName("_category").
                WithOpposite(x => x.Cars).ToColumn("CategoryID").
                HasConstraint((x, y) => x.CategoryID == y.CategoryID).
                WithDataAccessKind(DataAccessKind.ReadWrite);
        }
    }
}

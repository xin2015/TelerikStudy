﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Order
    {
        private int _orderID;
        public virtual int OrderID
        {
            get
            {
                return this._orderID;
            }
            set
            {
                this._orderID = value;
            }
        }

        private string _customerID;
        public virtual string CustomerID
        {
            get
            {
                return this._customerID;
            }
            set
            {
                this._customerID = value;
            }
        }

        private int? _employeeID;
        public virtual int? EmployeeID
        {
            get
            {
                return this._employeeID;
            }
            set
            {
                this._employeeID = value;
            }
        }

        private DateTime? _orderDate;
        public virtual DateTime? OrderDate
        {
            get
            {
                return this._orderDate;
            }
            set
            {
                this._orderDate = value;
            }
        }

        private DateTime? _requiredDate;
        public virtual DateTime? RequiredDate
        {
            get
            {
                return this._requiredDate;
            }
            set
            {
                this._requiredDate = value;
            }
        }

        private DateTime? _shippedDate;
        public virtual DateTime? ShippedDate
        {
            get
            {
                return this._shippedDate;
            }
            set
            {
                this._shippedDate = value;
            }
        }

        private int? _shipVia;
        public virtual int? ShipVia
        {
            get
            {
                return this._shipVia;
            }
            set
            {
                this._shipVia = value;
            }
        }

        private decimal? _freight;
        public virtual decimal? Freight
        {
            get
            {
                return this._freight;
            }
            set
            {
                this._freight = value;
            }
        }

        private string _shipName;
        public virtual string ShipName
        {
            get
            {
                return this._shipName;
            }
            set
            {
                this._shipName = value;
            }
        }

        private string _shipAddress;
        public virtual string ShipAddress
        {
            get
            {
                return this._shipAddress;
            }
            set
            {
                this._shipAddress = value;
            }
        }

        private string _shipCity;
        public virtual string ShipCity
        {
            get
            {
                return this._shipCity;
            }
            set
            {
                this._shipCity = value;
            }
        }

        private string _shipRegion;
        public virtual string ShipRegion
        {
            get
            {
                return this._shipRegion;
            }
            set
            {
                this._shipRegion = value;
            }
        }

        private string _shipPostalCode;
        public virtual string ShipPostalCode
        {
            get
            {
                return this._shipPostalCode;
            }
            set
            {
                this._shipPostalCode = value;
            }
        }

        private string _shipCountry;
        public virtual string ShipCountry
        {
            get
            {
                return this._shipCountry;
            }
            set
            {
                this._shipCountry = value;
            }
        }

        private Customer _customer;
        public virtual Customer Customer
        {
            get
            {
                return this._customer;
            }
            set
            {
                this._customer = value;
            }
        }

        private Employee _employee;
        public virtual Employee Employee
        {
            get
            {
                return this._employee;
            }
            set
            {
                this._employee = value;
            }
        }

        private Shipper _shipper;
        public virtual Shipper Shipper
        {
            get
            {
                return this._shipper;
            }
            set
            {
                this._shipper = value;
            }
        }

        private IList<OrderDetail> _orderDetails = new List<OrderDetail>();
        public virtual IList<OrderDetail> OrderDetails
        {
            get
            {
                return this._orderDetails;
            }
        }

    }
}

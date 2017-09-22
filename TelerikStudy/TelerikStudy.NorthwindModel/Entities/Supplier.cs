﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Supplier
    {
        private int _supplierID;
        public virtual int SupplierID
        {
            get
            {
                return this._supplierID;
            }
            set
            {
                this._supplierID = value;
            }
        }

        private string _companyName;
        public virtual string CompanyName
        {
            get
            {
                return this._companyName;
            }
            set
            {
                this._companyName = value;
            }
        }

        private string _contactName;
        public virtual string ContactName
        {
            get
            {
                return this._contactName;
            }
            set
            {
                this._contactName = value;
            }
        }

        private string _contactTitle;
        public virtual string ContactTitle
        {
            get
            {
                return this._contactTitle;
            }
            set
            {
                this._contactTitle = value;
            }
        }

        private string _address;
        public virtual string Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }

        private string _city;
        public virtual string City
        {
            get
            {
                return this._city;
            }
            set
            {
                this._city = value;
            }
        }

        private string _region;
        public virtual string Region
        {
            get
            {
                return this._region;
            }
            set
            {
                this._region = value;
            }
        }

        private string _postalCode;
        public virtual string PostalCode
        {
            get
            {
                return this._postalCode;
            }
            set
            {
                this._postalCode = value;
            }
        }

        private string _country;
        public virtual string Country
        {
            get
            {
                return this._country;
            }
            set
            {
                this._country = value;
            }
        }

        private string _phone;
        public virtual string Phone
        {
            get
            {
                return this._phone;
            }
            set
            {
                this._phone = value;
            }
        }

        private string _fax;
        public virtual string Fax
        {
            get
            {
                return this._fax;
            }
            set
            {
                this._fax = value;
            }
        }

        private string _homePage;
        public virtual string HomePage
        {
            get
            {
                return this._homePage;
            }
            set
            {
                this._homePage = value;
            }
        }

        private IList<Product> _products = new List<Product>();
        public virtual IList<Product> Products
        {
            get
            {
                return this._products;
            }
        }

    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Employee
    {
        private int _employeeID;
        public virtual int EmployeeID
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

        private string _lastName;
        public virtual string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                this._lastName = value;
            }
        }

        private string _firstName;
        public virtual string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                this._firstName = value;
            }
        }

        private string _title;
        public virtual string Title
        {
            get
            {
                return this._title;
            }
            set
            {
                this._title = value;
            }
        }

        private string _titleOfCourtesy;
        public virtual string TitleOfCourtesy
        {
            get
            {
                return this._titleOfCourtesy;
            }
            set
            {
                this._titleOfCourtesy = value;
            }
        }

        private DateTime? _birthDate;
        public virtual DateTime? BirthDate
        {
            get
            {
                return this._birthDate;
            }
            set
            {
                this._birthDate = value;
            }
        }

        private DateTime? _hireDate;
        public virtual DateTime? HireDate
        {
            get
            {
                return this._hireDate;
            }
            set
            {
                this._hireDate = value;
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

        private string _homePhone;
        public virtual string HomePhone
        {
            get
            {
                return this._homePhone;
            }
            set
            {
                this._homePhone = value;
            }
        }

        private string _extension;
        public virtual string Extension
        {
            get
            {
                return this._extension;
            }
            set
            {
                this._extension = value;
            }
        }

        private byte[] _photo;
        public virtual byte[] Photo
        {
            get
            {
                return this._photo;
            }
            set
            {
                this._photo = value;
            }
        }

        private string _notes;
        public virtual string Notes
        {
            get
            {
                return this._notes;
            }
            set
            {
                this._notes = value;
            }
        }

        private int? _reportsTo;
        public virtual int? ReportsTo
        {
            get
            {
                return this._reportsTo;
            }
            set
            {
                this._reportsTo = value;
            }
        }

        private string _photoPath;
        public virtual string PhotoPath
        {
            get
            {
                return this._photoPath;
            }
            set
            {
                this._photoPath = value;
            }
        }

        private IList<Order> _orders = new List<Order>();
        public virtual IList<Order> Orders
        {
            get
            {
                return this._orders;
            }
        }

        private Employee _employee1;
        public virtual Employee Employee1
        {
            get
            {
                return this._employee1;
            }
            set
            {
                this._employee1 = value;
            }
        }

        private IList<Employee> _employees = new List<Employee>();
        public virtual IList<Employee> Employees
        {
            get
            {
                return this._employees;
            }
        }

        private IList<Territory> _territories = new List<Territory>();
        public virtual IList<Territory> Territories
        {
            get
            {
                return this._territories;
            }
        }

    }
}

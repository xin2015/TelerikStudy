﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.Model.Entities
{
    public partial class RentalOrder
    {
        private int _rentalOrderID;
        public virtual int RentalOrderID
        {
            get
            {
                return this._rentalOrderID;
            }
            set
            {
                this._rentalOrderID = value;
            }
        }

        private DateTime? _dateProcessed;
        public virtual DateTime? DateProcessed
        {
            get
            {
                return this._dateProcessed;
            }
            set
            {
                this._dateProcessed = value;
            }
        }

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

        private int _customerID;
        public virtual int CustomerID
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

        private int _carID;
        public virtual int CarID
        {
            get
            {
                return this._carID;
            }
            set
            {
                this._carID = value;
            }
        }

        private string _tankLevel;
        public virtual string TankLevel
        {
            get
            {
                return this._tankLevel;
            }
            set
            {
                this._tankLevel = value;
            }
        }

        private int? _mileageStart;
        public virtual int? MileageStart
        {
            get
            {
                return this._mileageStart;
            }
            set
            {
                this._mileageStart = value;
            }
        }

        private int? _mileageEnd;
        public virtual int? MileageEnd
        {
            get
            {
                return this._mileageEnd;
            }
            set
            {
                this._mileageEnd = value;
            }
        }

        private DateTime _rentStartDate;
        public virtual DateTime RentStartDate
        {
            get
            {
                return this._rentStartDate;
            }
            set
            {
                this._rentStartDate = value;
            }
        }

        private DateTime _rentEndDate;
        public virtual DateTime RentEndDate
        {
            get
            {
                return this._rentEndDate;
            }
            set
            {
                this._rentEndDate = value;
            }
        }

        private int? _days;
        public virtual int? Days
        {
            get
            {
                return this._days;
            }
            set
            {
                this._days = value;
            }
        }

        private decimal? _rateApplied;
        public virtual decimal? RateApplied
        {
            get
            {
                return this._rateApplied;
            }
            set
            {
                this._rateApplied = value;
            }
        }

        private decimal? _orderTotal;
        public virtual decimal? OrderTotal
        {
            get
            {
                return this._orderTotal;
            }
            set
            {
                this._orderTotal = value;
            }
        }

        private string _orderStatus;
        public virtual string OrderStatus
        {
            get
            {
                return this._orderStatus;
            }
            set
            {
                this._orderStatus = value;
            }
        }

        private Car _car;
        public virtual Car Car
        {
            get
            {
                return this._car;
            }
            set
            {
                this._car = value;
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

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.SofiaCarRentalModel.Entities
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

        private string _employeeNumber;
        public virtual string EmployeeNumber
        {
            get
            {
                return this._employeeNumber;
            }
            set
            {
                this._employeeNumber = value;
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

        private string _fullName;
        public virtual string FullName
        {
            get
            {
                return this._fullName;
            }
            set
            {
                this._fullName = value;
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

        private decimal? _hourlySalary;
        public virtual decimal? HourlySalary
        {
            get
            {
                return this._hourlySalary;
            }
            set
            {
                this._hourlySalary = value;
            }
        }

        private IList<RentalOrder> _rentalOrders =
            new List<RentalOrder>();
        public virtual IList<RentalOrder> RentalOrders
        {
            get
            {
                return this._rentalOrders;
            }
        }

    }
}

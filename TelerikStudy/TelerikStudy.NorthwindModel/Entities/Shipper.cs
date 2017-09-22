using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Shipper
    {
        private int _shipperID;
        public virtual int ShipperID
        {
            get
            {
                return this._shipperID;
            }
            set
            {
                this._shipperID = value;
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

        private IList<Order> _orders = new List<Order>();
        public virtual IList<Order> Orders
        {
            get
            {
                return this._orders;
            }
        }

    }
}

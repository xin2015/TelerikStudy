using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class CustomerDemographic
    {
        private string _customerTypeID;
        public virtual string CustomerTypeID
        {
            get
            {
                return this._customerTypeID;
            }
            set
            {
                this._customerTypeID = value;
            }
        }

        private string _customerDesc;
        public virtual string CustomerDesc
        {
            get
            {
                return this._customerDesc;
            }
            set
            {
                this._customerDesc = value;
            }
        }

        private IList<Customer> _customers = new List<Customer>();
        public virtual IList<Customer> Customers
        {
            get
            {
                return this._customers;
            }
        }

    }
}

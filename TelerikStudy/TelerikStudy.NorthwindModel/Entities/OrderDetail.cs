using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class OrderDetail
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

        private int _productID;
        public virtual int ProductID
        {
            get
            {
                return this._productID;
            }
            set
            {
                this._productID = value;
            }
        }

        private decimal _unitPrice;
        public virtual decimal UnitPrice
        {
            get
            {
                return this._unitPrice;
            }
            set
            {
                this._unitPrice = value;
            }
        }

        private short _quantity;
        public virtual short Quantity
        {
            get
            {
                return this._quantity;
            }
            set
            {
                this._quantity = value;
            }
        }

        private float _discount;
        public virtual float Discount
        {
            get
            {
                return this._discount;
            }
            set
            {
                this._discount = value;
            }
        }

        private Order _order;
        public virtual Order Order
        {
            get
            {
                return this._order;
            }
            set
            {
                this._order = value;
            }
        }

        private Product _product;
        public virtual Product Product
        {
            get
            {
                return this._product;
            }
            set
            {
                this._product = value;
            }
        }

    }
}

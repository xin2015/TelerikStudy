﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Product
    {
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

        private string _productName;
        public virtual string ProductName
        {
            get
            {
                return this._productName;
            }
            set
            {
                this._productName = value;
            }
        }

        private int? _supplierID;
        public virtual int? SupplierID
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

        private int? _categoryID;
        public virtual int? CategoryID
        {
            get
            {
                return this._categoryID;
            }
            set
            {
                this._categoryID = value;
            }
        }

        private string _quantityPerUnit;
        public virtual string QuantityPerUnit
        {
            get
            {
                return this._quantityPerUnit;
            }
            set
            {
                this._quantityPerUnit = value;
            }
        }

        private decimal? _unitPrice;
        public virtual decimal? UnitPrice
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

        private short? _unitsInStock;
        public virtual short? UnitsInStock
        {
            get
            {
                return this._unitsInStock;
            }
            set
            {
                this._unitsInStock = value;
            }
        }

        private short? _unitsOnOrder;
        public virtual short? UnitsOnOrder
        {
            get
            {
                return this._unitsOnOrder;
            }
            set
            {
                this._unitsOnOrder = value;
            }
        }

        private short? _reorderLevel;
        public virtual short? ReorderLevel
        {
            get
            {
                return this._reorderLevel;
            }
            set
            {
                this._reorderLevel = value;
            }
        }

        private bool _discontinued;
        public virtual bool Discontinued
        {
            get
            {
                return this._discontinued;
            }
            set
            {
                this._discontinued = value;
            }
        }

        private Category _category;
        public virtual Category Category
        {
            get
            {
                return this._category;
            }
            set
            {
                this._category = value;
            }
        }

        private Supplier _supplier;
        public virtual Supplier Supplier
        {
            get
            {
                return this._supplier;
            }
            set
            {
                this._supplier = value;
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

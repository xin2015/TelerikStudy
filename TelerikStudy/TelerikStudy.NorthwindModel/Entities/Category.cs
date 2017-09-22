using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Category
    {
        private int _categoryID;
        public virtual int CategoryID
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

        private string _categoryName;
        public virtual string CategoryName
        {
            get
            {
                return this._categoryName;
            }
            set
            {
                this._categoryName = value;
            }
        }

        private string _description;
        public virtual string Description
        {
            get
            {
                return this._description;
            }
            set
            {
                this._description = value;
            }
        }

        private byte[] _picture;
        public virtual byte[] Picture
        {
            get
            {
                return this._picture;
            }
            set
            {
                this._picture = value;
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

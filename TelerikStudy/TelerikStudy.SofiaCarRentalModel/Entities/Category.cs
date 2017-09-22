using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.SofiaCarRentalModel.Entities
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

        private string _imageFileName;
        public virtual string ImageFileName
        {
            get
            {
                return this._imageFileName;
            }
            set
            {
                this._imageFileName = value;
            }
        }

        private IList<RentalRate> _rentalRates =
            new List<RentalRate>();
        public virtual IList<RentalRate> RentalRates
        {
            get
            {
                return this._rentalRates;
            }
        }

        private IList<Car> _cars = new List<Car>();
        public virtual IList<Car> Cars
        {
            get
            {
                return this._cars;
            }
        }

    }
}

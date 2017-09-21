using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.Model.Entities
{
    public partial class RentalRate
    {
        private int _rentalRateID;
        public virtual int RentalRateID
        {
            get
            {
                return this._rentalRateID;
            }
            set
            {
                this._rentalRateID = value;
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

        private decimal? _daily;
        public virtual decimal? Daily
        {
            get
            {
                return this._daily;
            }
            set
            {
                this._daily = value;
            }
        }

        private decimal? _weekly;
        public virtual decimal? Weekly
        {
            get
            {
                return this._weekly;
            }
            set
            {
                this._weekly = value;
            }
        }

        private decimal? _monthly;
        public virtual decimal? Monthly
        {
            get
            {
                return this._monthly;
            }
            set
            {
                this._monthly = value;
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

    }
}

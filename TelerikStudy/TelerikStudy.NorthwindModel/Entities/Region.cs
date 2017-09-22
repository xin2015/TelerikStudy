using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Region
    {
        private int _regionID;
        public virtual int RegionID
        {
            get
            {
                return this._regionID;
            }
            set
            {
                this._regionID = value;
            }
        }

        private string _regionDescription;
        public virtual string RegionDescription
        {
            get
            {
                return this._regionDescription;
            }
            set
            {
                this._regionDescription = value;
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

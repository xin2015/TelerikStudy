using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.NorthwindModel.Entities
{
    public partial class Territory
    {
        private string _territoryID;
        public virtual string TerritoryID
        {
            get
            {
                return this._territoryID;
            }
            set
            {
                this._territoryID = value;
            }
        }

        private string _territoryDescription;
        public virtual string TerritoryDescription
        {
            get
            {
                return this._territoryDescription;
            }
            set
            {
                this._territoryDescription = value;
            }
        }

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

        private Region _region;
        public virtual Region Region
        {
            get
            {
                return this._region;
            }
            set
            {
                this._region = value;
            }
        }

        private IList<Employee> _employees = new List<Employee>();
        public virtual IList<Employee> Employees
        {
            get
            {
                return this._employees;
            }
        }

    }
}

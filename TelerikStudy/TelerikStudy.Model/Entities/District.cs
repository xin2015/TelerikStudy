﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.Model.Entities
{
    public class District : IAuditedEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Order { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModificationTime { get; set; }

        private IList<Station> stations = new List<Station>();
        public IList<Station> Stations
        {
            get
            {
                return stations;
            }
        }
    }
}

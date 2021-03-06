﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.Model.Entities
{
    public class Station : IAuditedEntity
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Order { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime ModificationTime { get; set; }

        private IList<StationHourMonitorAirQuality> hourMonitorAirQualities = new List<StationHourMonitorAirQuality>();
        public IList<StationHourMonitorAirQuality> HourMonitorAirQualities
        {
            get
            {
                return hourMonitorAirQualities;
            }
        }

        private IList<District> districts = new List<District>();
        public IList<District> Districts
        {
            get
            {
                return districts;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.Model.Entities
{
    public interface IAirQualityEntity : ICodeTimeEntity
    {
        double? SO2 { get; set; }
        double? NO2 { get; set; }
        double? PM10 { get; set; }
        double? CO { get; set; }
        double? O3 { get; set; }
        double? PM25 { get; set; }
        double? AQI { get; set; }
        string PrimaryPollutant { get; set; }
        string Type { get; set; }
    }
}

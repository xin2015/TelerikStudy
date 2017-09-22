using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelerikStudy.Model;
using TelerikStudy.Model.Entities;

namespace TelerikStudy.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FluentModel db = new FluentModel())
            {
                db.UpdateSchema();

                Random rand = new Random();
                StationHourMonitorAirQuality aq1 = new StationHourMonitorAirQuality()
                {
                    Code = "430700052",
                    Time = DateTime.Today,
                    SO2 = rand.Next(100),
                    NO2 = rand.Next(100),
                    PM10 = rand.Next(100),
                    CO = rand.Next(10),
                    O3 = rand.Next(100),
                    PM25 = rand.Next(50),
                    AQI = rand.Next(100),
                    Type = "良",
                    PrimaryPollutant = "PM10",
                };
                Station station1 = new Station()
                {
                    Code = "430700052",
                    Name = "市二中",
                    Status = true,
                    Longitude = 112,
                    Latitude = 22,
                    CreationTime = DateTime.Now,
                    Order = 1
                };
                aq1.Station = station1;
                db.Add(aq1);
                StationHourMonitorAirQuality aq2 = new StationHourMonitorAirQuality()
                {
                    Code = "430700051",
                    Time = DateTime.Today,
                    SO2 = rand.Next(100),
                    NO2 = rand.Next(100),
                    PM10 = rand.Next(100),
                    CO = rand.Next(10),
                    O3 = rand.Next(100),
                    PM25 = rand.Next(50),
                    AQI = rand.Next(100),
                    Type = "良",
                    PrimaryPollutant = "PM10",
                };
                Station station2 = new Station()
                {
                    Code = "430700051",
                    Name = "市监测站",
                    Status = true,
                    Longitude = 112,
                    Latitude = 22,
                    CreationTime = DateTime.Now,
                    Order = 2
                };
                station2.HourMonitorAirQualities = new List<StationHourMonitorAirQuality>();
                station2.HourMonitorAirQualities.Add(aq2);
                db.Add(station2);
                db.SaveChanges();
                Station station3 = db.GetAll<Station>().First(o => o.Code == "430700052");
                db.Delete(aq1);
                db.Delete(station3);
                db.SaveChanges();
                StationHourMonitorAirQuality aq3 = db.GetAll<StationHourMonitorAirQuality>().First(o => o.Code == "430700051");
                db.Delete(station2);
                db.SaveChanges();
            }
        }
    }
}

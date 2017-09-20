using System;
using System.Collections.Generic;
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
                MissingDataRecord mdr = new MissingDataRecord()
                {
                    Type = "StationHourMonitorAirQuality",
                    Code = "430100054",
                    Time = DateTime.Today,
                    CreationTime = DateTime.Now
                };
                db.Add(mdr);
                db.SaveChanges();
                db.ContextOptions.EnableDataSynchronization = true;
                mdr.MissTimes += 1;
                mdr.Message = "";
                mdr.ModifiedTime = mdr.CreationTime;
                db.SaveChanges();
                db.ContextOptions.EnableDataSynchronization = false;
                mdr.Status = true;
                mdr.ModifiedTime = mdr.CreationTime;
                db.SaveChanges();
            }
        }
    }
}

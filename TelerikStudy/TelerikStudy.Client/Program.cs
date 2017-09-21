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

                List<MissingDataRecord> list = new List<MissingDataRecord>();
                List<MissingDataRecordB> listb = new List<MissingDataRecordB>();
                int length = 50;
                for (int i = 0; i < length; i++)
                {
                    string type = i.ToString().PadLeft(2, '0');
                    for (int j = 0; j < length; j++)
                    {
                        string code = j.ToString().PadLeft(2, '0');
                        for (int k = 0; k < length; k++)
                        {
                            DateTime time = DateTime.Today.AddHours(-k);
                            list.Add(new MissingDataRecord()
                            {
                                Type = type,
                                Code = code,
                                Time = time,
                                CreationTime = DateTime.Now
                            });
                            listb.Add(new MissingDataRecordB()
                            {
                                Type = type,
                                Code = code,
                                Time = time,
                                CreationTime = DateTime.Now
                            });
                        }
                    }
                }
                Stopwatch sw = new Stopwatch();
                sw.Start();
                db.Add(listb);
                db.SaveChanges();
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
                sw.Restart();
                db.Add(list);
                db.SaveChanges();
                sw.Stop();
                Console.WriteLine(sw.Elapsed);
            }
        }
    }
}

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
            }
        }
    }
}

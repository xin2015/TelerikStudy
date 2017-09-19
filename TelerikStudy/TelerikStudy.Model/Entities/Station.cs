using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.Model.Entities
{
    public class Station : IEntity<int>
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool Status { get; set; }
        public double Longitude { get; set; }
        public double Latitude { get; set; }
        public int Order { get; set; }
    }
}

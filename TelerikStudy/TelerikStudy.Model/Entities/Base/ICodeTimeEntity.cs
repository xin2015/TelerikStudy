using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelerikStudy.Model.Entities
{
    public interface ICodeTimeEntity : IEntity
    {
        string Code { get; set; }
        DateTime Time { get; set; }
    }
}

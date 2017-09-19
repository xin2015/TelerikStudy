using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess.Metadata.Fluent;

namespace TelerikStudy.Model
{
    public class TelerikFluentMetadataSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> mappingConfigurations = new List<MappingConfiguration>();

            return mappingConfigurations;
        }
    }
}

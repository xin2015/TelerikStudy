using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Metadata.Fluent;
using TelerikStudy.Model.Entities;

namespace TelerikStudy.Model
{
    public class FluentModelMetadataSource : FluentMetadataSource
    {
        protected override IList<MappingConfiguration> PrepareMapping()
        {
            List<MappingConfiguration> mappingConfigurations = new List<MappingConfiguration>();
            mappingConfigurations.Add(GetMissingDataRecordMappingConfiguration());

            return mappingConfigurations;
        }

        private MappingConfiguration<MissingDataRecord> GetMissingDataRecordMappingConfiguration()
        {
            MappingConfiguration<MissingDataRecord> configuration = new MappingConfiguration<MissingDataRecord>();

            configuration.MapType().WithConcurencyControl(OptimisticConcurrencyControlStrategy.Timestamp).ToTable(typeof(MissingDataRecord).Name);

            configuration.HasProperty(x => x.Id).IsIdentity(KeyGenerator.Autoinc);
            configuration.HasProperty(x => x.Type).IsNotNullable().HasColumnType("nvarchar").HasLength(256);
            configuration.HasProperty(x => x.Code).IsNotNullable().HasColumnType("nvarchar").HasLength(64);
            configuration.HasProperty(x => x.ModifiedTime).IsVersion();
            configuration.HasProperty(x => x.Message).HasColumnType("nvarchar(MAX)");

            return configuration;
        }
    }
}

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
            mappingConfigurations.Add(GetDistrictMappingConfiguration());
            mappingConfigurations.Add(GetStationMappingConfiguration());
            mappingConfigurations.Add(GetStationHourMonitorAirQualityMappingConfiguration());

            return mappingConfigurations;
        }

        protected override void SetContainerSettings(MetadataContainer container)
        {
            container.NameGenerator.SourceStrategy = NamingSourceStrategy.Property;
            container.NameGenerator.RemoveCamelCase = false;
            container.NameGenerator.ResolveReservedWords = false;
        }

        private MappingConfiguration<MissingDataRecord> GetMissingDataRecordMappingConfiguration()
        {
            MappingConfiguration<MissingDataRecord> configuration = new MappingConfiguration<MissingDataRecord>();

            configuration.MapType().WithConcurencyControl(OptimisticConcurrencyControlStrategy.Timestamp).ToTable(typeof(MissingDataRecord).Name);

            configuration.HasProperty(x => x.Type).IsIdentity().IsNotNullable().HasColumnType("nvarchar").HasLength(256);
            configuration.HasProperty(x => x.Code).IsIdentity().IsNotNullable().HasColumnType("nvarchar").HasLength(64);
            configuration.HasProperty(x => x.Time).IsIdentity();
            configuration.HasProperty(x => x.Status).HasColumnType("bit");
            configuration.HasProperty(x => x.Message).HasColumnType("nvarchar(MAX)");
            configuration.HasProperty(x => x.ModificationTime).IsVersion();

            return configuration;
        }

        private MappingConfiguration<District> GetDistrictMappingConfiguration()
        {
            MappingConfiguration<District> configuration = new MappingConfiguration<District>();

            configuration.MapType().WithConcurencyControl(OptimisticConcurrencyControlStrategy.Timestamp).ToTable(typeof(District).Name);

            configuration.HasProperty(x => x.Code).IsIdentity().IsNotNullable().HasColumnType("nvarchar").HasLength(64);
            configuration.HasProperty(x => x.Name).IsNotNullable().HasColumnType("nvarchar").HasLength(256);
            configuration.HasProperty(x => x.Status).HasColumnType("bit");
            configuration.HasProperty(x => x.ModificationTime).IsVersion();

            configuration.HasAssociation(x => x.Stations).WithOpposite(x => x.Districts).IsManaged().MapJoinTable("DistrictStation", (x, y) => new { DistrictCode = x.Code, StationCode = y.Code }).CreatePrimaryKeyFromForeignKeys();

            return configuration;
        }

        private MappingConfiguration<Station> GetStationMappingConfiguration()
        {
            MappingConfiguration<Station> configuration = new MappingConfiguration<Station>();

            configuration.MapType().WithConcurencyControl(OptimisticConcurrencyControlStrategy.Timestamp).ToTable(typeof(Station).Name);

            configuration.HasProperty(x => x.Code).IsIdentity().IsNotNullable().HasColumnType("nvarchar").HasLength(64);
            configuration.HasProperty(x => x.Name).IsNotNullable().HasColumnType("nvarchar").HasLength(256);
            configuration.HasProperty(x => x.Status).HasColumnType("bit");
            configuration.HasProperty(x => x.ModificationTime).IsVersion();

            return configuration;
        }

        private MappingConfiguration<StationHourMonitorAirQuality> GetStationHourMonitorAirQualityMappingConfiguration()
        {
            MappingConfiguration<StationHourMonitorAirQuality> configuration = new MappingConfiguration<StationHourMonitorAirQuality>();

            configuration.MapType().ToTable(typeof(StationHourMonitorAirQuality).Name);

            configuration.HasProperty(x => x.Code).IsIdentity().IsNotNullable().HasColumnType("nvarchar").HasLength(64);
            configuration.HasProperty(x => x.Time).IsIdentity();
            configuration.HasProperty(x => x.Type).HasColumnType("nvarchar").HasLength(8);
            configuration.HasProperty(x => x.PrimaryPollutant).HasColumnType("nvarchar").HasLength(128);

            configuration.HasAssociation(x => x.Station).WithOpposite(x => x.HourMonitorAirQualities).HasConstraint((x, y) => x.Code == y.Code).IsRequired();

            return configuration;
        }

    }
}

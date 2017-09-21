using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;

namespace TelerikStudy.Model
{
    public class FluentModel : OpenAccessContext
    {
        private static string connectionString = "TelerikStudyConnection";
        private static BackendConfiguration backendConfiguration = GetBackendConfiguration();
        private static MetadataSource metadataSource = new FluentModelMetadataSource();
        public static BackendConfiguration GetBackendConfiguration()
        {
            BackendConfiguration backend = new BackendConfiguration();
            backend.Backend = "MsSql";
            backend.ProviderName = "System.Data.SqlClient";

            backend.Runtime.CacheReferenceType = CacheReferenceType.Auto;

            return backend;
        }

        public FluentModel() : base(connectionString, backendConfiguration, metadataSource)
        { }

        public void UpdateSchema()
        {
            ISchemaHandler schemaHandler = GetSchemaHandler();
            string script = null;
            if (schemaHandler.DatabaseExists())
            {
                script = schemaHandler.CreateUpdateDDLScript(null);
            }
            else
            {
                schemaHandler.CreateDatabase();
                script = schemaHandler.CreateDDLScript();
            }
            if (!string.IsNullOrEmpty(script))
            {
                schemaHandler.ExecuteDDLScript(script);
            }
        }

        //public void AddBySqlBulkCopy(DataTable dt)
        //{
        //    using (SqlBulkCopy sbc = new SqlBulkCopy(Connection.ConnectionString))
        //    {
        //        sbc.DestinationTableName = dt.TableName;
        //        sbc.BatchSize = 30000;
        //        foreach (DataColumn item in dt.Columns)
        //        {
        //            sbc.ColumnMappings.Add(item.ColumnName, item.ColumnName);
        //        }
        //        sbc.WriteToServer(dt);
        //    }
        //}
    }
}

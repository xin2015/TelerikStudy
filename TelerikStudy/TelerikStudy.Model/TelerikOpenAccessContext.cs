using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Telerik.OpenAccess;

namespace TelerikStudy.Model
{
    public class TelerikOpenAccessContext : OpenAccessContext
    {
        public static BackendConfiguration GetBackendConfiguration()
        {
            BackendConfiguration backend = new BackendConfiguration();
            backend.Backend = "MsSql";
            backend.ProviderName = "System.Data.SqlClient";

            backend.Runtime.CacheReferenceType = CacheReferenceType.Auto;
        }

        public void UpdateSchema()
        {
            using (TelerikOpenAccessContext context = new TelerikOpenAccessContext())
            {
                ISchemaHandler schemaHandler = context.GetSchemaHandler();
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
        }

    }
}

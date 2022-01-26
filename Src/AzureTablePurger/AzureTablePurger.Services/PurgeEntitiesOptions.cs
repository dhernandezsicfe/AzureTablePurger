using System.Collections.Generic;

namespace AzureTablePurger.Services
{
    public class PurgeEntitiesOptions
    {
        public string TargetAccountConnectionString { get; set; }

        public List<string> TargetTableNames { get; set; }

        public int PurgeRecordsOlderThanDays { get; set; }
    }
}
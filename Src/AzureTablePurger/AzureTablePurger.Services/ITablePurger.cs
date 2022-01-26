using System;
using System.Threading;
using System.Threading.Tasks;

namespace AzureTablePurger.Services
{
    public interface ITablePurger
    {
        Task PurgeEntitiesAsync(PurgeEntitiesOptions options, CancellationToken cancellationToken);
        Task<Tuple<int, int>> PurgeEntitiesAsync(PurgeEntitiesOptions options, string targetTableName, CancellationToken cancellationToken);
    }
}
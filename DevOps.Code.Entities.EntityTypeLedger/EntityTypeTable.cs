// Copyright © Christopher Dorst. All rights reserved.
// Licensed under the GNU General Public License, Version 3.0. See the LICENSE document in the repository root for license information.

using Microsoft.WindowsAzure.Storage.Table;

namespace DevOps.Code.Entities.EntityTypeLedger
{
    /// <summary>Azure Table Storage entity representing an entity-type</summary>
    public class EntityTypeTable : TableEntity
    {
        public EntityTypeTable()
        {
        }

        public EntityTypeTable(string accountName, string repositoryName, int entityTypeId)
        {
            EntityTypeId = entityTypeId;
            PartitionKey = accountName;
            RowKey = repositoryName;
        }

        /// <summary>Entity type unique identifier</summary>
        public int EntityTypeId { get; set; }
    }
}

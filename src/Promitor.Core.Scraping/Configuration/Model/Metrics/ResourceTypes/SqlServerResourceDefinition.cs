﻿namespace Promitor.Core.Scraping.Configuration.Model.Metrics.ResourceTypes
{
    /// <summary>
    ///     Represents an Azure SQL Server resource.
    /// </summary>
    public class SqlServerResourceDefinition : AzureResourceDefinition
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SqlServerResourceDefinition" /> class.
        /// </summary>
        /// <param name="resourceGroupName">The name of the resource group the server is in.</param>
        /// <param name="serverName">The name of the Azure SQL Server resource.</param>
        public SqlServerResourceDefinition(string resourceGroupName, string serverName)
            : base(ResourceType.SqlServer, resourceGroupName)
        {
            ServerName = serverName;
        }

        /// <summary>
        ///     The name of the Azure SQL Server resource.
        /// </summary>
        public string ServerName { get; }

        /// <inheritdoc />
        public override string GetResourceName() => ServerName;
    }
}
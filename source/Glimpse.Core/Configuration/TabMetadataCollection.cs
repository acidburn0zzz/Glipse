﻿using System;
using Glimpse.Core.Extensibility;

namespace Glimpse.Core.Configuration
{
    /// <summary>
    /// Represents a collection of <see cref="ITabMetadata"/>
    /// </summary>
    public class TabMetadataCollection : DiscoverableCollection<ITabMetadata>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TabMetadataCollection" /> class
        /// </summary>
        /// <param name="collectionSettings">The collection settings</param>
        /// <param name="logger">The logger</param>
        /// <param name="onChange">Event handler to call when the Change event is raised</param>
        public TabMetadataCollection(CollectionSettings collectionSettings, ILogger logger, EventHandler onChange = null)
            : base(collectionSettings, logger, onChange)
        {
        }
    }
}
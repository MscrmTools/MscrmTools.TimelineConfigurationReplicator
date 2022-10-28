using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;

namespace MscrmTools.TimelineConfigurationReplicator.AppCode
{
    public class TargetTimelineControl
    {
        public string CellId { get; set; }
        public Entity Form { get; set; }
        public string Id { get; set; }
        public EntityMetadata Table { get; set; }
    }
}
using System;
using System.Collections.Generic;

namespace MscrmTools.TimelineConfigurationReplicator.AppCode
{
    public class PublishTablesEventArgs : EventArgs
    {
        public PublishTablesEventArgs(List<string> logicalNames)
        {
            LogicalNames = logicalNames;
        }

        public List<string> LogicalNames { get; private set; }
    }
}
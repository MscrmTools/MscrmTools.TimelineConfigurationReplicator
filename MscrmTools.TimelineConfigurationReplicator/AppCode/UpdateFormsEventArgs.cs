using System;
using System.Collections.Generic;

namespace MscrmTools.TimelineConfigurationReplicator.AppCode
{
    public class UpdateFormsEventArgs : EventArgs
    {
        public UpdateFormsEventArgs(List<TargetTimelineControl> controls)
        {
            Controls = controls;
        }

        public List<TargetTimelineControl> Controls { get; private set; }
    }
}
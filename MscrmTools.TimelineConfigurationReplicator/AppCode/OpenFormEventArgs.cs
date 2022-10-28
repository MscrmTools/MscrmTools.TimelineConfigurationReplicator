using System;

namespace MscrmTools.TimelineConfigurationReplicator.AppCode
{
    public class OpenFormEventArgs : EventArgs
    {
        public OpenFormEventArgs(string table, Guid formId)
        {
            Table = table;
            FormId = formId;
        }

        public Guid FormId { get; private set; }
        public string Table { get; private set; }
    }
}
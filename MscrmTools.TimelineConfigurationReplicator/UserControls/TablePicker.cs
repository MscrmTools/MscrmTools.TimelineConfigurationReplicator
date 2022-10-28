using Microsoft.Xrm.Sdk.Metadata;
using MscrmTools.TimelineConfigurationReplicator.AppCode;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace MscrmTools.TimelineConfigurationReplicator.UserControls
{
    public partial class TablePicker : UserControl
    {
        private int sortColumnIndex = -1;

        public TablePicker()
        {
            InitializeComponent();
        }

        public event EventHandler<TablePickerEventArgs> OnTableSelected;

        public void Display(List<EntityMetadata> emds)
        {
            lvTables.Items.Clear();
            lvTables.Items.AddRange(emds.Select(e => new ListViewItem(e.DisplayName?.UserLocalizedLabel?.Label ?? "N/A") { Tag = e, SubItems = { new ListViewItem.ListViewSubItem { Text = e.SchemaName } } }).ToArray());
        }

        internal void Clear()
        {
            lvTables.Items.Clear();
        }

        private void lvTables_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != sortColumnIndex)
            {
                sortColumnIndex = e.Column;
                lvTables.ListViewItemSorter = new ListViewItemComparer(sortColumnIndex, SortOrder.Ascending);
            }
            else
            {
                lvTables.ListViewItemSorter = new ListViewItemComparer(sortColumnIndex, lvTables.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending);
            }

            lvTables.Sort();
        }

        private void lvTables_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvTables.SelectedItems.Count == 0) return;
            OnTableSelected?.Invoke(this, new TablePickerEventArgs((EntityMetadata)lvTables.SelectedItems[0].Tag, false));
        }

        private void tsbSourceTable_Click(object sender, EventArgs e)
        {
            if (lvTables.SelectedItems.Count == 0) return;
            OnTableSelected?.Invoke(this, new TablePickerEventArgs((EntityMetadata)lvTables.SelectedItems[0].Tag, true));
        }
    }

    public class TablePickerEventArgs : EventArgs
    {
        public TablePickerEventArgs(EntityMetadata table, bool isSource) : base()
        {
            Table = table;
            IsSource = isSource;
        }

        public bool IsSource { get; private set; }
        public EntityMetadata Table { get; private set; }
    }
}
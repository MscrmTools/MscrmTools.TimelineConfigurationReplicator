using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using MscrmTools.TimelineConfigurationReplicator.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MscrmTools.TimelineConfigurationReplicator.UserControls
{
    public partial class TargetTimelinesSelector : UserControl
    {
        private EntityMetadata currentEmd;
        private int formSortColumnIndex = -1;
        private int timeline2SortColumnIndex = -1;
        private int timelineSortColumnIndex = -1;

        public TargetTimelinesSelector()
        {
            InitializeComponent();
        }

        public event EventHandler<OpenFormEventArgs> OnFormOpenRequested;

        public event EventHandler<PublishTablesEventArgs> OnPublishTablesRequested;

        public event EventHandler<UpdateFormsEventArgs> OnUpdateFormsRequested;

        public void DisplayForms(EntityMetadata emd, List<Entity> forms)
        {
            currentEmd = emd;

            lvForms.Items.Clear();
            lvForms.Items.AddRange(forms.Select(f => new ListViewItem(f.GetAttributeValue<string>("name"))
            {
                SubItems =
                {
                    new ListViewItem.ListViewSubItem
                    {
                        Text = f.FormattedValues["type"]
                    },
                    new ListViewItem.ListViewSubItem
                    {
                        Text = (f.GetAttributeValue<string>("formxml").IndexOf("06375649-C143-495E-A496-C962E5B4488E", StringComparison.CurrentCultureIgnoreCase) >= 0).ToString()
                    }
                },
                Tag = f
            }).ToArray());
        }

        internal void Clear()
        {
            lvForms.Items.Clear();
            lvTimelines.Items.Clear();
            listView1.Items.Clear();
            tsbUpdate.Enabled = false;
            tsbPublish.Enabled = false;
        }

        internal void SetPAVisibility(bool visible)
        {
            tsbOpenForm.Visible = visible;
            toolStripSeparator1.Visible = visible;
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                return;
            }

            listView1.Items.Remove(listView1.SelectedItems[0]);

            tsbUpdate.Enabled = listView1.Items.Count > 0;
            tsbPublish.Enabled = listView1.Items.Count > 0;
        }

        private void lvForms_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != formSortColumnIndex)
            {
                formSortColumnIndex = e.Column;
                lvForms.ListViewItemSorter = new ListViewItemComparer(formSortColumnIndex, SortOrder.Ascending);
            }
            else
            {
                lvForms.Sorting = lvForms.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                lvForms.ListViewItemSorter = new ListViewItemComparer(formSortColumnIndex, lvForms.Sorting);
            }

            lvForms.Sort();
        }

        private void lvForms_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvTimelines.Items.Clear();

            if (lvForms.SelectedItems.Count == 0)
            {
                return;
            }
            var form = (Entity)lvForms.SelectedItems[0].Tag;
            var formXml = form.GetAttributeValue<string>("formxml");

            var formDoc = XDocument.Parse(formXml);
            var timelines = formDoc.Descendants("control").Where(d => d.Attribute("id").Value == "notescontrol");

            lvTimelines.Items.AddRange(timelines.Select(t => new ListViewItem(((XElement)((XElement)t.PreviousNode).DescendantNodes().First()).Attribute("description").Value)
            {
                SubItems =
                {
                    new ListViewItem.ListViewSubItem{
                        Text = t.Ancestors("tab").First().Descendants("label").First().Attribute("description").Value
                        },
                    new ListViewItem.ListViewSubItem{
                        Text =  t.Ancestors("section").First().Descendants("label").First().Attribute("description").Value
                        }
                },
                Tag = new TargetTimelineControl { Table = currentEmd, Form = form, Id = t.Attribute("uniqueid")?.Value, CellId = t.Ancestors("cell").First().Attribute("id").Value }
            }).ToArray());
        }

        private void lvTimelines_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != timelineSortColumnIndex)
            {
                timelineSortColumnIndex = e.Column;
                lvTimelines.ListViewItemSorter = new ListViewItemComparer(timelineSortColumnIndex, SortOrder.Ascending);
            }
            else
            {
                lvTimelines.Sorting = lvForms.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                lvTimelines.ListViewItemSorter = new ListViewItemComparer(timelineSortColumnIndex, lvTimelines.Sorting);
            }

            lvTimelines.Sort();
        }

        private void lvTimelines_DoubleClick(object sender, EventArgs e)
        {
            if (lvTimelines.SelectedItems.Count == 0)
            {
                return;
            }

            var newListViewItem = (ListViewItem)lvTimelines.SelectedItems[0].Clone();
            newListViewItem.SubItems.Add(new ListViewItem.ListViewSubItem { Text = currentEmd.DisplayName?.UserLocalizedLabel?.Label ?? currentEmd.LogicalName });

            if (listView1.Items.Cast<ListViewItem>().All(i => !i.Tag.Equals(newListViewItem.Tag)))
            {
                listView1.Items.Add(newListViewItem);
            }

            tsbUpdate.Enabled = listView1.Items.Count > 0;
            tsbPublish.Enabled = listView1.Items.Count > 0;
        }

        private void lvTimelines2_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            if (e.Column != timeline2SortColumnIndex)
            {
                timeline2SortColumnIndex = e.Column;
                listView1.ListViewItemSorter = new ListViewItemComparer(timeline2SortColumnIndex, SortOrder.Ascending);
            }
            else
            {
                listView1.Sorting = lvForms.Sorting == SortOrder.Ascending ? SortOrder.Descending : SortOrder.Ascending;
                listView1.ListViewItemSorter = new ListViewItemComparer(timeline2SortColumnIndex, listView1.Sorting);
            }

            listView1.Sort();
        }

        private void tsbOpenForm_Click(object sender, EventArgs e)
        {
            if (lvForms.SelectedItems.Count == 0)
            {
                return;
            }

            var form = (Entity)lvForms.SelectedItems[0].Tag;

            OnFormOpenRequested?.Invoke(this, new OpenFormEventArgs(form.GetAttributeValue<string>("objecttypecode"), form.Id));
        }

        private void tsbPublish_Click(object sender, EventArgs e)
        {
            OnPublishTablesRequested?.Invoke(this, new PublishTablesEventArgs(listView1.Items.Cast<ListViewItem>().Select(i => ((TargetTimelineControl)i.Tag).Table.LogicalName).Distinct().ToList()));
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            OnUpdateFormsRequested?.Invoke(this, new UpdateFormsEventArgs(listView1.Items.Cast<ListViewItem>().Select(i => (TargetTimelineControl)i.Tag).ToList()));
        }
    }
}
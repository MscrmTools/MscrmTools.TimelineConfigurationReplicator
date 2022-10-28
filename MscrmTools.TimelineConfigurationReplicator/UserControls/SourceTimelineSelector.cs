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
    public partial class SourceTimelineSelector : UserControl
    {
        private int formSortColumnIndex = -1;
        private int timelineSortColumnIndex = -1;

        public SourceTimelineSelector()
        {
            InitializeComponent();
        }

        public event EventHandler<OpenFormEventArgs> OnFormOpenRequested;

        public bool IsConfigurationManuallyUpdated => scintilla1.Text != lvTimelines.SelectedItems.Cast<ListViewItem>().FirstOrDefault().Tag?.ToString();
        public string SelectedConfiguration => scintilla1.Text;

        public void DisplayForms(EntityMetadata emd, List<Entity> forms)
        {
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
            scintilla1.Text = "";
        }

        internal void SetPAVisibility(bool visible)
        {
            tsbOpenForm.Visible = visible;
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

            var formXml = ((Entity)lvForms.SelectedItems[0].Tag).GetAttributeValue<string>("formxml");

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
                Tag = t.Descendants("parameters")?.FirstOrDefault()?.ToString()
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

        private void lvTimelines_SelectedIndexChanged(object sender, EventArgs e)
        {
            scintilla1.Text = "";

            if (lvTimelines.SelectedItems.Count == 0)
            {
                return;
            }

            scintilla1.Text = lvTimelines.SelectedItems[0].Tag?.ToString();
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
    }
}
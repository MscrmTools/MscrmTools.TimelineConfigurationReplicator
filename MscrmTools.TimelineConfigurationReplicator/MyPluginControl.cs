using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using Microsoft.Xrm.Sdk.Query;
using MscrmTools.TimelineConfigurationReplicator.AppCode;
using MscrmTools.TimelineConfigurationReplicator.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MscrmTools.TimelineConfigurationReplicator
{
    public partial class MyPluginControl : PluginControlBase, IHelpPlugin, IPayPalPlugin, IGitHubPlugin
    {
        private Guid solutionId;

        public MyPluginControl()
        {
            InitializeComponent();
        }

        public string DonationDescription => "Donation for Timeline Configuration Replicator";
        public string EmailAccount => "tanguy92@hotmail.com";
        public string HelpUrl => "https://github.com/MscrmTools/MscrmTools.TimelineConfigurationReplicator/wiki";
        public string RepositoryName => "MscrmTools.TimelineConfigurationReplicator";
        public string UserName => "MscrmTools";

        /// <summary>
        /// This event occurs when the connection has been updated in XrmToolBox
        /// </summary>
        public override void UpdateConnection(IOrganizationService newService, ConnectionDetail detail, string actionName, object parameter)
        {
            base.UpdateConnection(newService, detail, actionName, parameter);

            sourceTimelineSelector1.Clear();
            targetTimelinesSelector1.Clear();
            tablePicker1.Clear();

            sourceTimelineSelector1.SetPAVisibility(!string.IsNullOrEmpty(ConnectionDetail?.EnvironmentId));
            targetTimelinesSelector1.SetPAVisibility(!string.IsNullOrEmpty(ConnectionDetail?.EnvironmentId));
        }

        private void ctrls_OnFormOpenRequested(object sender, AppCode.OpenFormEventArgs e)
        {
            if (string.IsNullOrEmpty(ConnectionDetail.EnvironmentId))
            {
                MessageBox.Show(this, "Your connection does not contain EnvironmentId property. Cannot open Power Apps maker portal", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConnectionDetail.OpenUrlWithBrowserProfile(new Uri($"https://make.powerapps.com/e/{ConnectionDetail.EnvironmentId}/s/{(solutionId != Guid.Empty ? solutionId : new Guid("fd140aaf-4df4-11dd-bd17-0019b9312238"))}/entity/{e.Table}/form/edit/{e.FormId}"));
        }

        private void LoadTables(bool fromSolution)
        {
            if (fromSolution)
            {
                var sp = new SolutionPicker(Service);
                if (sp.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                {
                    solutionId = sp.SelectedSolution.FirstOrDefault()?.Id ?? Guid.Empty;
                }
                else
                {
                    return;
                }
            }
            else
            {
                solutionId = Guid.Empty;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading tables...",
                Work = (bw, evt) =>
                {
                    evt.Result = MetadataManager.GetEntitiesList(Service, solutionId);
                },
                PostWorkCallBack = (evt) =>
                {
                    tablePicker1.Display((List<EntityMetadata>)evt.Result);
                }
            });
        }

        private void tablePicker1_OnTableSelected(object sender, UserControls.TablePickerEventArgs e)
        {
            if (e.IsSource)
            {
                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Loading forms...",
                    Work = (bw, evt) =>
                    {
                        evt.Result = Service.RetrieveMultiple(new QueryExpression("systemform")
                        {
                            NoLock = true,
                            ColumnSet = new ColumnSet("name", "formxml", "type"),
                            Criteria = new FilterExpression
                            {
                                Conditions =
                                {
                                    new ConditionExpression("objecttypecode", ConditionOperator.Equal, e.Table.LogicalName)
                                }
                            }
                        }).Entities.ToList();
                    },
                    PostWorkCallBack = (evt) =>
                    {
                        sourceTimelineSelector1.DisplayForms(e.Table, (List<Entity>)evt.Result);
                    }
                });
            }
            else
            {
                WorkAsync(new WorkAsyncInfo
                {
                    Message = "Loading forms...",
                    Work = (bw, evt) =>
                    {
                        evt.Result = Service.RetrieveMultiple(new QueryExpression("systemform")
                        {
                            NoLock = true,
                            ColumnSet = new ColumnSet("name", "formxml", "type"),
                            Criteria = new FilterExpression
                            {
                                Conditions =
                                {
                                    new ConditionExpression("objecttypecode", ConditionOperator.Equal, e.Table.LogicalName)
                                }
                            }
                        }).Entities.ToList();
                    },
                    PostWorkCallBack = (evt) =>
                    {
                        targetTimelinesSelector1.DisplayForms(e.Table, (List<Entity>)evt.Result);
                    }
                });
            }
        }

        private void targetTimelinesSelector1_OnPublishTablesRequested(object sender, PublishTablesEventArgs e)
        {
            tablePicker1.Enabled = false;
            sourceTimelineSelector1.Enabled = false;
            targetTimelinesSelector1.Enabled = false;

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Publishing tables...",
                Work = (bw, evt) =>
                {
                    MetadataManager.PublishEntities(e.LogicalNames, Service);
                },
                PostWorkCallBack = (evt) =>
                 {
                     tablePicker1.Enabled = true;
                     sourceTimelineSelector1.Enabled = true;
                     targetTimelinesSelector1.Enabled = true;

                     if (evt.Error != null)
                     {
                         MessageBox.Show(this, $"An error occured when publishing tables: {evt.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                     }
                 }
            });
        }

        private void targetTimelinesSelector1_OnUpdateFormsRequested(object sender, UpdateFormsEventArgs e)
        {
            var selectedConfiguration = sourceTimelineSelector1.SelectedConfiguration;
            if (string.IsNullOrEmpty(selectedConfiguration))
            {
                if (DialogResult.No == MessageBox.Show(this, "The source configuration is empty! Are you sure you want to apply it to selected Timelines?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
            }

            if (sourceTimelineSelector1.IsConfigurationManuallyUpdated)
            {
                if (DialogResult.No == MessageBox.Show(this, "The source configuration has been manually updated! Are you sure you want to apply it to selected Timelines?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    return;
                }
            }

            if (DialogResult.No == MessageBox.Show(this, $"Are you sure you want to update form(s) for {e.Controls.Count} timeline(s)?", "Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                return;
            }

            foreach (var control in e.Controls)
            {
                var xml = control.Form.GetAttributeValue<string>("formxml");
                var xDoc = XDocument.Parse(xml);
                var controlElt = xDoc.Descendants("control").FirstOrDefault(d => d.Attribute("uniqueid")?.Value == control.Id && d.Attribute("id").Value == "notescontrol" && d.Ancestors("cell").Attributes("id").First().Value == control.CellId);
                if (controlElt == null) controlElt = xDoc.Descendants("control").FirstOrDefault(d => d.Attribute("id").Value == "notescontrol" && d.Ancestors("cell").Attributes("id").First().Value == control.CellId);
                if (controlElt != null)
                {
                    var name = controlElt.Element("parameters")?.Element("UClientUniqueName")?.Value;

                    controlElt.RemoveNodes();

                    if (!string.IsNullOrEmpty(selectedConfiguration))
                    {
                        var parsed = XElement.Parse(selectedConfiguration);
                        var parsedNameElt = parsed.Element("UClientUniqueName");

                        if (!string.IsNullOrEmpty(name))
                        {
                            if (parsedNameElt != null)
                            {
                                parsedNameElt.Value = name;
                            }
                            else
                            {
                                parsedNameElt = new XElement("UClientUniqueName");
                                parsedNameElt.Value = name;

                                parsed.AddFirst(parsedNameElt);
                            }
                        }
                        else if (parsedNameElt != null)
                        {
                            parsedNameElt.Remove();
                        }

                        controlElt.Add(parsed);
                    }
                }

                control.Form["formxml"] = xDoc.ToString();
            }

            tablePicker1.Enabled = false;
            sourceTimelineSelector1.Enabled = false;
            targetTimelinesSelector1.Enabled = false;

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Updating forms...",
                Work = (bw, evt) =>
                {
                    foreach (var form in e.Controls.Select(c => c.Form))
                    {
                        bw.ReportProgress(0, $"Updating form {form.GetAttributeValue<string>("name")}");
                        Service.Update(form);
                    }
                },
                PostWorkCallBack = (evt) =>
                {
                    tablePicker1.Enabled = true;
                    sourceTimelineSelector1.Enabled = true;
                    targetTimelinesSelector1.Enabled = true;

                    if (evt.Error != null)
                    {
                        MessageBox.Show(this, $"An error occured when updating forms: {evt.Error.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                },
                ProgressChanged = (evt) =>
                {
                    SetWorkingMessage(evt.UserState.ToString());
                }
            });
        }

        private void tsbHelpOnTimeline_Click(object sender, EventArgs e)
        {
            ConnectionDetail.OpenUrlWithBrowserProfile(new Uri("https://learn.microsoft.com/en-us/power-apps/maker/model-driven-apps/set-up-timeline-control"));
        }

        private void tsbLoadTables_ButtonClick(object sender, EventArgs e)
        {
            ExecuteMethod(LoadTables, false);
        }

        private void tsbLoadTables_DropDownItemClicked(object sender, System.Windows.Forms.ToolStripItemClickedEventArgs e)
        {
            ExecuteMethod(LoadTables, true);
        }
    }
}
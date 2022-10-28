namespace MscrmTools.TimelineConfigurationReplicator
{
    partial class MyPluginControl
    {
        /// <summary> 
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.scRight = new System.Windows.Forms.SplitContainer();
            this.tablePicker1 = new MscrmTools.TimelineConfigurationReplicator.UserControls.TablePicker();
            this.sourceTimelineSelector1 = new MscrmTools.TimelineConfigurationReplicator.UserControls.SourceTimelineSelector();
            this.targetTimelinesSelector1 = new MscrmTools.TimelineConfigurationReplicator.UserControls.TargetTimelinesSelector();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbLoadTables = new System.Windows.Forms.ToolStripSplitButton();
            this.tsmiLoadTablesFromSolution = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbHelpOnTimeline = new System.Windows.Forms.ToolStripButton();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).BeginInit();
            this.scRight.Panel1.SuspendLayout();
            this.scRight.Panel2.SuspendLayout();
            this.scRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbLoadTables,
            this.toolStripSeparator1,
            this.tsbHelpOnTimeline});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(2738, 57);
            this.toolStripMenu.TabIndex = 4;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(0, 86);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.tablePicker1);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scRight);
            this.scMain.Size = new System.Drawing.Size(2738, 1869);
            this.scMain.SplitterDistance = 723;
            this.scMain.TabIndex = 5;
            // 
            // scRight
            // 
            this.scRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scRight.Location = new System.Drawing.Point(0, 0);
            this.scRight.Name = "scRight";
            this.scRight.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scRight.Panel1
            // 
            this.scRight.Panel1.Controls.Add(this.sourceTimelineSelector1);
            // 
            // scRight.Panel2
            // 
            this.scRight.Panel2.Controls.Add(this.targetTimelinesSelector1);
            this.scRight.Size = new System.Drawing.Size(2011, 1869);
            this.scRight.SplitterDistance = 734;
            this.scRight.TabIndex = 0;
            // 
            // tablePicker1
            // 
            this.tablePicker1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePicker1.Location = new System.Drawing.Point(0, 0);
            this.tablePicker1.Name = "tablePicker1";
            this.tablePicker1.Size = new System.Drawing.Size(723, 1869);
            this.tablePicker1.TabIndex = 0;
            this.tablePicker1.OnTableSelected += new System.EventHandler<MscrmTools.TimelineConfigurationReplicator.UserControls.TablePickerEventArgs>(this.tablePicker1_OnTableSelected);
            // 
            // sourceTimelineSelector1
            // 
            this.sourceTimelineSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTimelineSelector1.Location = new System.Drawing.Point(0, 0);
            this.sourceTimelineSelector1.Name = "sourceTimelineSelector1";
            this.sourceTimelineSelector1.Size = new System.Drawing.Size(2011, 734);
            this.sourceTimelineSelector1.TabIndex = 0;
            this.sourceTimelineSelector1.OnFormOpenRequested += ctrls_OnFormOpenRequested;          
            // 
            // targetTimelinesSelector1
            // 
            this.targetTimelinesSelector1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.targetTimelinesSelector1.Location = new System.Drawing.Point(0, 0);
            this.targetTimelinesSelector1.Name = "targetTimelinesSelector1";
            this.targetTimelinesSelector1.Size = new System.Drawing.Size(2011, 1131);
            this.targetTimelinesSelector1.TabIndex = 0;
            this.targetTimelinesSelector1.OnPublishTablesRequested += new System.EventHandler<MscrmTools.TimelineConfigurationReplicator.AppCode.PublishTablesEventArgs>(this.targetTimelinesSelector1_OnPublishTablesRequested);
            this.targetTimelinesSelector1.OnUpdateFormsRequested += new System.EventHandler<MscrmTools.TimelineConfigurationReplicator.AppCode.UpdateFormsEventArgs>(this.targetTimelinesSelector1_OnUpdateFormsRequested);
            this.targetTimelinesSelector1.OnFormOpenRequested += ctrls_OnFormOpenRequested;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 34);
            // 
            // tsbLoadTables
            // 
            this.tsbLoadTables.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLoadTablesFromSolution});
            this.tsbLoadTables.Image = global::MscrmTools.TimelineConfigurationReplicator.Properties.Resources.Dataverse_16x16;
            this.tsbLoadTables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLoadTables.Name = "tsbLoadTables";
            this.tsbLoadTables.Size = new System.Drawing.Size(140, 29);
            this.tsbLoadTables.Text = "Load tables";
            this.tsbLoadTables.ButtonClick += new System.EventHandler(this.tsbLoadTables_ButtonClick);
            this.tsbLoadTables.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.tsbLoadTables_DropDownItemClicked);
            // 
            // tsmiLoadTablesFromSolution
            // 
            this.tsmiLoadTablesFromSolution.Name = "tsmiLoadTablesFromSolution";
            this.tsmiLoadTablesFromSolution.Size = new System.Drawing.Size(239, 34);
            this.tsmiLoadTablesFromSolution.Text = "From a solution";
            // 
            // tsbHelpOnTimeline
            // 
            this.tsbHelpOnTimeline.Image = global::MscrmTools.TimelineConfigurationReplicator.Properties.Resources._16_L_help;
            this.tsbHelpOnTimeline.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbHelpOnTimeline.Name = "tsbHelpOnTimeline";
            this.tsbHelpOnTimeline.Size = new System.Drawing.Size(383, 52);
            this.tsbHelpOnTimeline.Text = "Open Timeline configuration documentation";
            this.tsbHelpOnTimeline.Click += new System.EventHandler(this.tsbHelpOnTimeline_Click);
            // 
            // MyPluginControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.toolStripMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MyPluginControl";
            this.Size = new System.Drawing.Size(1825, 1303);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.scRight.Panel1.ResumeLayout(false);
            this.scRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scRight)).EndInit();
            this.scRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

     

        #endregion
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripSplitButton tsbLoadTables;
        private System.Windows.Forms.ToolStripMenuItem tsmiLoadTablesFromSolution;
        private System.Windows.Forms.SplitContainer scMain;
        private UserControls.TablePicker tablePicker1;
        private System.Windows.Forms.SplitContainer scRight;
        private UserControls.SourceTimelineSelector sourceTimelineSelector1;
        private UserControls.TargetTimelinesSelector targetTimelinesSelector1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbHelpOnTimeline;
    }
}

using System;
using System.Windows.Forms;

namespace MscrmTools.TimelineConfigurationReplicator.UserControls
{
    partial class SourceTimelineSelector
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
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.gbForms = new System.Windows.Forms.GroupBox();
            this.lvForms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scSecondary = new System.Windows.Forms.SplitContainer();
            this.gbTimelineControls = new System.Windows.Forms.GroupBox();
            this.lvTimelines = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbConfiguration = new System.Windows.Forms.GroupBox();
            this.scintilla1 = new ScintillaNET.Scintilla();
            this.gbMain = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tsbOpenForm = new System.Windows.Forms.ToolStripButton();
            this.tsMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.gbForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSecondary)).BeginInit();
            this.scSecondary.Panel1.SuspendLayout();
            this.scSecondary.Panel2.SuspendLayout();
            this.scSecondary.SuspendLayout();
            this.gbTimelineControls.SuspendLayout();
            this.gbConfiguration.SuspendLayout();
            this.gbMain.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenForm});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(2604, 57);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMain.Location = new System.Drawing.Point(3, 64);
            this.scMain.Name = "scMain";
            // 
            // scMain.Panel1
            // 
            this.scMain.Panel1.Controls.Add(this.gbForms);
            // 
            // scMain.Panel2
            // 
            this.scMain.Panel2.Controls.Add(this.scSecondary);
            this.scMain.Size = new System.Drawing.Size(2598, 1312);
            this.scMain.SplitterDistance = 600;
            this.scMain.TabIndex = 1;
            // 
            // gbForms
            // 
            this.gbForms.Controls.Add(this.lvForms);
            this.gbForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForms.Location = new System.Drawing.Point(0, 0);
            this.gbForms.Name = "gbForms";
            this.gbForms.Size = new System.Drawing.Size(600, 1312);
            this.gbForms.TabIndex = 0;
            this.gbForms.TabStop = false;
            this.gbForms.Text = "Forms";
            // 
            // lvForms
            // 
            this.lvForms.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvForms.FullRowSelect = true;
            this.lvForms.HideSelection = false;
            this.lvForms.Location = new System.Drawing.Point(3, 22);
            this.lvForms.Name = "lvForms";
            this.lvForms.Size = new System.Drawing.Size(594, 1287);
            this.lvForms.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvForms.TabIndex = 0;
            this.lvForms.UseCompatibleStateImageBehavior = false;
            this.lvForms.View = System.Windows.Forms.View.Details;
            this.lvForms.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvForms_ColumnClick);
            this.lvForms.SelectedIndexChanged += new System.EventHandler(this.lvForms_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Type";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Timeline ctrl.";
            this.columnHeader3.Width = 100;
            // 
            // scSecondary
            // 
            this.scSecondary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scSecondary.Location = new System.Drawing.Point(0, 0);
            this.scSecondary.Name = "scSecondary";
            // 
            // scSecondary.Panel1
            // 
            this.scSecondary.Panel1.Controls.Add(this.gbTimelineControls);
            // 
            // scSecondary.Panel2
            // 
            this.scSecondary.Panel2.Controls.Add(this.gbConfiguration);
            this.scSecondary.Size = new System.Drawing.Size(1994, 1312);
            this.scSecondary.SplitterDistance = 414;
            this.scSecondary.TabIndex = 0;
            // 
            // gbTimelineControls
            // 
            this.gbTimelineControls.Controls.Add(this.lvTimelines);
            this.gbTimelineControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTimelineControls.Location = new System.Drawing.Point(0, 0);
            this.gbTimelineControls.Name = "gbTimelineControls";
            this.gbTimelineControls.Size = new System.Drawing.Size(414, 1312);
            this.gbTimelineControls.TabIndex = 1;
            this.gbTimelineControls.TabStop = false;
            this.gbTimelineControls.Text = "Timelines";
            // 
            // lvTimelines
            // 
            this.lvTimelines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader5});
            this.lvTimelines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTimelines.FullRowSelect = true;
            this.lvTimelines.HideSelection = false;
            this.lvTimelines.Location = new System.Drawing.Point(3, 22);
            this.lvTimelines.Name = "lvTimelines";
            this.lvTimelines.Size = new System.Drawing.Size(408, 1287);
            this.lvTimelines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTimelines.TabIndex = 0;
            this.lvTimelines.UseCompatibleStateImageBehavior = false;
            this.lvTimelines.View = System.Windows.Forms.View.Details;
            this.lvTimelines.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTimelines_ColumnClick);
            this.lvTimelines.SelectedIndexChanged += new System.EventHandler(this.lvTimelines_SelectedIndexChanged);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tab";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Section";
            this.columnHeader5.Width = 100;
            // 
            // gbConfiguration
            // 
            this.gbConfiguration.Controls.Add(this.scintilla1);
            this.gbConfiguration.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbConfiguration.Location = new System.Drawing.Point(0, 0);
            this.gbConfiguration.Name = "gbConfiguration";
            this.gbConfiguration.Size = new System.Drawing.Size(1576, 1312);
            this.gbConfiguration.TabIndex = 0;
            this.gbConfiguration.TabStop = false;
            this.gbConfiguration.Text = "Configuration";
            // 
            // scintilla1
            // 
            this.scintilla1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scintilla1.Lexer = ScintillaNET.Lexer.Xml;
            this.scintilla1.Location = new System.Drawing.Point(3, 22);
            this.scintilla1.Name = "scintilla1";
            this.scintilla1.Size = new System.Drawing.Size(1570, 1287);
            this.scintilla1.TabIndex = 0;
            // 
            // gbMain
            // 
            this.gbMain.Controls.Add(this.scMain);
            this.gbMain.Controls.Add(this.panel1);
            this.gbMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMain.Location = new System.Drawing.Point(0, 86);
            this.gbMain.Name = "gbMain";
            this.gbMain.Size = new System.Drawing.Size(2604, 1379);
            this.gbMain.TabIndex = 2;
            this.gbMain.TabStop = false;
            this.gbMain.Text = "Source timeline configuration selection";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2598, 42);
            this.panel1.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(2598, 42);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "To select a source Timeline control configuration, select a table on the Table li" +
    "st and click on the button Set as source, then select a form, then a timeline co" +
    "ntrol";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbOpenForm
            // 
            this.tsbOpenForm.Image = global::MscrmTools.TimelineConfigurationReplicator.Properties.Resources.PowerApps_scalable;
            this.tsbOpenForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenForm.Name = "tsbOpenForm";
            this.tsbOpenForm.Size = new System.Drawing.Size(353, 52);
            this.tsbOpenForm.Text = "Open form in Power Apps maker portal";
            this.tsbOpenForm.Click += new System.EventHandler(this.tsbOpenForm_Click);
            // 
            // SourceTimelineSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbMain);
            this.Controls.Add(this.tsMain);
            this.Name = "SourceTimelineSelector";
            this.Size = new System.Drawing.Size(1736, 976);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.gbForms.ResumeLayout(false);
            this.scSecondary.Panel1.ResumeLayout(false);
            this.scSecondary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSecondary)).EndInit();
            this.scSecondary.ResumeLayout(false);
            this.gbTimelineControls.ResumeLayout(false);
            this.gbConfiguration.ResumeLayout(false);
            this.gbMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.GroupBox gbForms;
        private System.Windows.Forms.ListView lvForms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.SplitContainer scSecondary;
        private System.Windows.Forms.GroupBox gbTimelineControls;
        private System.Windows.Forms.ListView lvTimelines;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbConfiguration;
        private ScintillaNET.Scintilla scintilla1;
        private System.Windows.Forms.GroupBox gbMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private ToolStripButton tsbOpenForm;
    }
}

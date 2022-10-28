namespace MscrmTools.TimelineConfigurationReplicator.UserControls
{
    partial class TargetTimelinesSelector
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
            this.tsbUpdate = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbPublish = new System.Windows.Forms.ToolStripButton();
            this.gbTarget = new System.Windows.Forms.GroupBox();
            this.scMain = new System.Windows.Forms.SplitContainer();
            this.gbForms = new System.Windows.Forms.GroupBox();
            this.lvForms = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.scSecondary = new System.Windows.Forms.SplitContainer();
            this.gbTimelines = new System.Windows.Forms.GroupBox();
            this.lvTimelines = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gbSelectedTimelines = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblInfo = new System.Windows.Forms.Label();
            this.tsbOpenForm = new System.Windows.Forms.ToolStripButton();
            this.tsMain.SuspendLayout();
            this.gbTarget.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).BeginInit();
            this.scMain.Panel1.SuspendLayout();
            this.scMain.Panel2.SuspendLayout();
            this.scMain.SuspendLayout();
            this.gbForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scSecondary)).BeginInit();
            this.scSecondary.Panel1.SuspendLayout();
            this.scSecondary.Panel2.SuspendLayout();
            this.scSecondary.SuspendLayout();
            this.gbTimelines.SuspendLayout();
            this.gbSelectedTimelines.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsMain
            // 
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbOpenForm,
            this.toolStripSeparator1,
            this.tsbUpdate,
            this.tsbPublish});
            this.tsMain.Location = new System.Drawing.Point(0, 0);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(1641, 34);
            this.tsMain.TabIndex = 0;
            this.tsMain.Text = "toolStrip1";
            // 
            // tsbUpdate
            // 
            this.tsbUpdate.Enabled = false;
            this.tsbUpdate.Image = global::MscrmTools.TimelineConfigurationReplicator.Properties.Resources.SaveChart16;
            this.tsbUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUpdate.Name = "tsbUpdate";
            this.tsbUpdate.Size = new System.Drawing.Size(242, 52);
            this.tsbUpdate.Text = "Update selected timelines";
            this.tsbUpdate.Click += new System.EventHandler(this.tsbUpdate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 57);
            // 
            // tsbPublish
            // 
            this.tsbPublish.Enabled = false;
            this.tsbPublish.Image = global::MscrmTools.TimelineConfigurationReplicator.Properties.Resources.publishall;
            this.tsbPublish.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPublish.Name = "tsbPublish";
            this.tsbPublish.Size = new System.Drawing.Size(149, 52);
            this.tsbPublish.Text = "Publish tables";
            this.tsbPublish.Click += new System.EventHandler(this.tsbPublish_Click);
            // 
            // gbTarget
            // 
            this.gbTarget.Controls.Add(this.scMain);
            this.gbTarget.Controls.Add(this.panel1);
            this.gbTarget.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTarget.Location = new System.Drawing.Point(0, 34);
            this.gbTarget.Name = "gbTarget";
            this.gbTarget.Size = new System.Drawing.Size(1641, 943);
            this.gbTarget.TabIndex = 1;
            this.gbTarget.TabStop = false;
            this.gbTarget.Text = "Target Timelines selection";
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
            this.scMain.Size = new System.Drawing.Size(1635, 876);
            this.scMain.SplitterDistance = 399;
            this.scMain.TabIndex = 1;
            // 
            // gbForms
            // 
            this.gbForms.Controls.Add(this.lvForms);
            this.gbForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbForms.Location = new System.Drawing.Point(0, 0);
            this.gbForms.Name = "gbForms";
            this.gbForms.Size = new System.Drawing.Size(399, 876);
            this.gbForms.TabIndex = 1;
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
            this.lvForms.Size = new System.Drawing.Size(393, 851);
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
            this.scSecondary.Panel1.Controls.Add(this.gbTimelines);
            // 
            // scSecondary.Panel2
            // 
            this.scSecondary.Panel2.Controls.Add(this.gbSelectedTimelines);
            this.scSecondary.Size = new System.Drawing.Size(1232, 876);
            this.scSecondary.SplitterDistance = 271;
            this.scSecondary.TabIndex = 0;
            // 
            // gbTimelines
            // 
            this.gbTimelines.Controls.Add(this.lvTimelines);
            this.gbTimelines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTimelines.Location = new System.Drawing.Point(0, 0);
            this.gbTimelines.Name = "gbTimelines";
            this.gbTimelines.Size = new System.Drawing.Size(271, 876);
            this.gbTimelines.TabIndex = 0;
            this.gbTimelines.TabStop = false;
            this.gbTimelines.Text = "Timelines";
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
            this.lvTimelines.Size = new System.Drawing.Size(265, 851);
            this.lvTimelines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTimelines.TabIndex = 1;
            this.lvTimelines.UseCompatibleStateImageBehavior = false;
            this.lvTimelines.View = System.Windows.Forms.View.Details;
            this.lvTimelines.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTimelines_ColumnClick);
            this.lvTimelines.DoubleClick += new System.EventHandler(this.lvTimelines_DoubleClick);
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
            // gbSelectedTimelines
            // 
            this.gbSelectedTimelines.Controls.Add(this.listView1);
            this.gbSelectedTimelines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSelectedTimelines.Location = new System.Drawing.Point(0, 0);
            this.gbSelectedTimelines.Name = "gbSelectedTimelines";
            this.gbSelectedTimelines.Size = new System.Drawing.Size(957, 876);
            this.gbSelectedTimelines.TabIndex = 0;
            this.gbSelectedTimelines.TabStop = false;
            this.gbSelectedTimelines.Text = "Selected timelines to update";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(3, 22);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(951, 851);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTimelines2_ColumnClick);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader7
            // 
            this.columnHeader7.DisplayIndex = 1;
            this.columnHeader7.Text = "Name";
            this.columnHeader7.Width = 200;
            // 
            // columnHeader8
            // 
            this.columnHeader8.DisplayIndex = 2;
            this.columnHeader8.Text = "Tab";
            this.columnHeader8.Width = 100;
            // 
            // columnHeader9
            // 
            this.columnHeader9.DisplayIndex = 3;
            this.columnHeader9.Text = "Section";
            this.columnHeader9.Width = 100;
            // 
            // columnHeader10
            // 
            this.columnHeader10.DisplayIndex = 0;
            this.columnHeader10.Text = "Table";
            this.columnHeader10.Width = 150;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.lblInfo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1635, 42);
            this.panel1.TabIndex = 2;
            // 
            // lblInfo
            // 
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(1635, 42);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "To select target Timeline controls, select a table on the Table list, then a form" +
    ", then double click on Timeline controls to add/remove them from lists";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tsbOpenForm
            // 
            this.tsbOpenForm.Image = global::MscrmTools.TimelineConfigurationReplicator.Properties.Resources.PowerApps_scalable;
            this.tsbOpenForm.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbOpenForm.Name = "tsbOpenForm";
            this.tsbOpenForm.Size = new System.Drawing.Size(345, 29);
            this.tsbOpenForm.Text = "Open form in Power Apps maker portal";
            this.tsbOpenForm.Click += new System.EventHandler(this.tsbOpenForm_Click);
            // 
            // TargetTimelinesSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTarget);
            this.Controls.Add(this.tsMain);
            this.Name = "TargetTimelinesSelector";
            this.Size = new System.Drawing.Size(1641, 977);
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.gbTarget.ResumeLayout(false);
            this.scMain.Panel1.ResumeLayout(false);
            this.scMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMain)).EndInit();
            this.scMain.ResumeLayout(false);
            this.gbForms.ResumeLayout(false);
            this.scSecondary.Panel1.ResumeLayout(false);
            this.scSecondary.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scSecondary)).EndInit();
            this.scSecondary.ResumeLayout(false);
            this.gbTimelines.ResumeLayout(false);
            this.gbSelectedTimelines.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.GroupBox gbTarget;
        private System.Windows.Forms.SplitContainer scMain;
        private System.Windows.Forms.SplitContainer scSecondary;
        private System.Windows.Forms.GroupBox gbForms;
        private System.Windows.Forms.ListView lvForms;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox gbTimelines;
        private System.Windows.Forms.ListView lvTimelines;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.GroupBox gbSelectedTimelines;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ToolStripButton tsbUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbPublish;
        private System.Windows.Forms.ToolStripButton tsbOpenForm;
    }
}

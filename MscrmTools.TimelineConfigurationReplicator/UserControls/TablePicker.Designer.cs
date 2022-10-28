namespace MscrmTools.TimelineConfigurationReplicator.UserControls
{
    partial class TablePicker
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
            this.tsTable = new System.Windows.Forms.ToolStrip();
            this.gbTables = new System.Windows.Forms.GroupBox();
            this.lvTables = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tsbSourceTable = new System.Windows.Forms.ToolStripButton();
            this.tsTable.SuspendLayout();
            this.gbTables.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsTable
            // 
            this.tsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSourceTable});
            this.tsTable.Location = new System.Drawing.Point(0, 0);
            this.tsTable.Name = "tsTable";
            this.tsTable.Size = new System.Drawing.Size(1065, 57);
            this.tsTable.TabIndex = 0;
            this.tsTable.Text = "tsTablePicker";
            // 
            // gbTables
            // 
            this.gbTables.Controls.Add(this.lvTables);
            this.gbTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTables.Location = new System.Drawing.Point(0, 86);
            this.gbTables.Name = "gbTables";
            this.gbTables.Size = new System.Drawing.Size(1065, 2012);
            this.gbTables.TabIndex = 1;
            this.gbTables.TabStop = false;
            this.gbTables.Text = "Tables";
            // 
            // lvTables
            // 
            this.lvTables.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvTables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvTables.FullRowSelect = true;
            this.lvTables.HideSelection = false;
            this.lvTables.Location = new System.Drawing.Point(3, 22);
            this.lvTables.MultiSelect = false;
            this.lvTables.Name = "lvTables";
            this.lvTables.Size = new System.Drawing.Size(1059, 1987);
            this.lvTables.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvTables.TabIndex = 0;
            this.lvTables.UseCompatibleStateImageBehavior = false;
            this.lvTables.View = System.Windows.Forms.View.Details;
            this.lvTables.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.lvTables_ColumnClick);
            this.lvTables.SelectedIndexChanged += new System.EventHandler(this.lvTables_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Display name";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Logical name";
            this.columnHeader2.Width = 200;
            // 
            // tsbSourceTable
            // 
            this.tsbSourceTable.Image = global::MscrmTools.TimelineConfigurationReplicator.Properties.Resources.Notification_Confirmation_16;
            this.tsbSourceTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSourceTable.Name = "tsbSourceTable";
            this.tsbSourceTable.Size = new System.Drawing.Size(188, 52);
            this.tsbSourceTable.Text = "Set as source table";
            this.tsbSourceTable.Click += new System.EventHandler(this.tsbSourceTable_Click);
            // 
            // TablePicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbTables);
            this.Controls.Add(this.tsTable);
            this.Name = "TablePicker";
            this.Size = new System.Drawing.Size(710, 1398);
            this.tsTable.ResumeLayout(false);
            this.tsTable.PerformLayout();
            this.gbTables.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsTable;
        private System.Windows.Forms.GroupBox gbTables;
        private System.Windows.Forms.ListView lvTables;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripButton tsbSourceTable;
    }
}

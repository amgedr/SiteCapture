namespace SiteCapture
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            this.restoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sysTrayContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.websitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.settingsToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteAllURLsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripButton = new System.Windows.Forms.ToolStripSplitButton();
            this.editToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.capturesDataGridView = new System.Windows.Forms.DataGridView();
            this.Url = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrowserWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrowserHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrowserColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImageColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Captured = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UrlId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.captureButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.sitesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sitecaputreDataSet = new SiteCapture.sitecaptureDataSet();
            this.sitesTableAdapter = new SiteCapture.sitecaptureDataSetTableAdapters.sitesTableAdapter();
            this.sysTrayContextMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.websitesBindingSource)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitecaputreDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // restoreToolStripMenuItem
            // 
            this.restoreToolStripMenuItem.Name = "restoreToolStripMenuItem";
            this.restoreToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.restoreToolStripMenuItem.Text = "&Restore";
            this.restoreToolStripMenuItem.Click += new System.EventHandler(this.restoreToolStripMenuItem_Click);
            // 
            // sysTrayContextMenu
            // 
            this.sysTrayContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.restoreToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.sysTrayContextMenu.Name = "sysTrayContextMenu";
            this.sysTrayContextMenu.Size = new System.Drawing.Size(114, 48);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.sysTrayContextMenu;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "SiteCapture";
            this.notifyIcon.DoubleClick += new System.EventHandler(this.notifyIcon_DoubleClick);
            // 
            // websitesBindingSource
            // 
            this.websitesBindingSource.DataMember = "sites";
            // 
            // aboutToolStripButton
            // 
            this.aboutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("aboutToolStripButton.Image")));
            this.aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.aboutToolStripButton.Name = "aboutToolStripButton";
            this.aboutToolStripButton.Size = new System.Drawing.Size(60, 22);
            this.aboutToolStripButton.Text = "About";
            this.aboutToolStripButton.Click += new System.EventHandler(this.aboutToolStripButton_Click);
            // 
            // settingsToolStripButton
            // 
            this.settingsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("settingsToolStripButton.Image")));
            this.settingsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.settingsToolStripButton.Name = "settingsToolStripButton";
            this.settingsToolStripButton.Size = new System.Drawing.Size(69, 22);
            this.settingsToolStripButton.Text = "Settings";
            this.settingsToolStripButton.Click += new System.EventHandler(this.settingsToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // deleteAllURLsToolStripMenuItem
            // 
            this.deleteAllURLsToolStripMenuItem.Name = "deleteAllURLsToolStripMenuItem";
            this.deleteAllURLsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.deleteAllURLsToolStripMenuItem.Text = "Delete All URLs";
            this.deleteAllURLsToolStripMenuItem.Click += new System.EventHandler(this.deleteAllURLsToolStripMenuItem_Click);
            // 
            // deleteToolStripButton
            // 
            this.deleteToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteAllURLsToolStripMenuItem});
            this.deleteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripButton.Image")));
            this.deleteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteToolStripButton.Name = "deleteToolStripButton";
            this.deleteToolStripButton.Size = new System.Drawing.Size(72, 22);
            this.deleteToolStripButton.Text = "Delete";
            this.deleteToolStripButton.ButtonClick += new System.EventHandler(this.deleteToolStripButton_ButtonClick);
            // 
            // editToolStripButton
            // 
            this.editToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripButton.Image")));
            this.editToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editToolStripButton.Name = "editToolStripButton";
            this.editToolStripButton.Size = new System.Drawing.Size(47, 22);
            this.editToolStripButton.Text = "Edit";
            this.editToolStripButton.Click += new System.EventHandler(this.editToolStripButton_Click);
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(51, 22);
            this.newToolStripButton.Text = "New";
            this.newToolStripButton.Click += new System.EventHandler(this.newToolStripButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.editToolStripButton,
            this.deleteToolStripButton,
            this.toolStripSeparator1,
            this.settingsToolStripButton,
            this.aboutToolStripButton});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(727, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // capturesDataGridView
            // 
            this.capturesDataGridView.AllowUserToAddRows = false;
            this.capturesDataGridView.AllowUserToDeleteRows = false;
            this.capturesDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.capturesDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.capturesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.capturesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.capturesDataGridView.ColumnHeadersHeight = 26;
            this.capturesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.capturesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Url,
            this.BrowserWidth,
            this.BrowserHeight,
            this.ImageWidth,
            this.ImageHeight,
            this.BrowserColumn,
            this.ImageColumn,
            this.Captured,
            this.UrlId,
            this.captureButtonColumn});
            this.capturesDataGridView.DataSource = this.sitesBindingSource;
            this.capturesDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.capturesDataGridView.Location = new System.Drawing.Point(0, 25);
            this.capturesDataGridView.Name = "capturesDataGridView";
            this.capturesDataGridView.ReadOnly = true;
            this.capturesDataGridView.RowHeadersVisible = false;
            this.capturesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.capturesDataGridView.Size = new System.Drawing.Size(727, 383);
            this.capturesDataGridView.TabIndex = 4;
            this.capturesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.capturesDataGridView_CellClick);
            this.capturesDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.capturesDataGridView_CellFormatting);
            this.capturesDataGridView.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.capturesDataGridView_ColumnHeaderMouseClick);
            // 
            // Url
            // 
            this.Url.DataPropertyName = "Url";
            this.Url.Frozen = true;
            this.Url.HeaderText = "URL";
            this.Url.Name = "Url";
            this.Url.ReadOnly = true;
            this.Url.Width = 340;
            // 
            // BrowserWidth
            // 
            this.BrowserWidth.DataPropertyName = "BrowserWidth";
            this.BrowserWidth.HeaderText = "Browser Width";
            this.BrowserWidth.Name = "BrowserWidth";
            this.BrowserWidth.ReadOnly = true;
            this.BrowserWidth.Visible = false;
            this.BrowserWidth.Width = 110;
            // 
            // BrowserHeight
            // 
            this.BrowserHeight.DataPropertyName = "BrowserHeight";
            this.BrowserHeight.HeaderText = "Browser Height";
            this.BrowserHeight.Name = "BrowserHeight";
            this.BrowserHeight.ReadOnly = true;
            this.BrowserHeight.Visible = false;
            this.BrowserHeight.Width = 110;
            // 
            // ImageWidth
            // 
            this.ImageWidth.DataPropertyName = "ImageWidth";
            this.ImageWidth.HeaderText = "Image Width";
            this.ImageWidth.Name = "ImageWidth";
            this.ImageWidth.ReadOnly = true;
            this.ImageWidth.Visible = false;
            this.ImageWidth.Width = 110;
            // 
            // ImageHeight
            // 
            this.ImageHeight.DataPropertyName = "ImageHeight";
            this.ImageHeight.HeaderText = "Image Height";
            this.ImageHeight.Name = "ImageHeight";
            this.ImageHeight.ReadOnly = true;
            this.ImageHeight.Visible = false;
            this.ImageHeight.Width = 110;
            // 
            // BrowserColumn
            // 
            this.BrowserColumn.HeaderText = "Browser";
            this.BrowserColumn.Name = "BrowserColumn";
            this.BrowserColumn.ReadOnly = true;
            this.BrowserColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // ImageColumn
            // 
            this.ImageColumn.HeaderText = "Image";
            this.ImageColumn.Name = "ImageColumn";
            this.ImageColumn.ReadOnly = true;
            // 
            // Captured
            // 
            this.Captured.DataPropertyName = "Captured";
            this.Captured.HeaderText = "Last Captured";
            this.Captured.Name = "Captured";
            this.Captured.ReadOnly = true;
            this.Captured.Width = 130;
            // 
            // UrlId
            // 
            this.UrlId.DataPropertyName = "UrlId";
            this.UrlId.HeaderText = "UrlId";
            this.UrlId.Name = "UrlId";
            this.UrlId.ReadOnly = true;
            this.UrlId.Visible = false;
            // 
            // captureButtonColumn
            // 
            this.captureButtonColumn.HeaderText = "";
            this.captureButtonColumn.MinimumWidth = 20;
            this.captureButtonColumn.Name = "captureButtonColumn";
            this.captureButtonColumn.ReadOnly = true;
            this.captureButtonColumn.Text = "...";
            this.captureButtonColumn.ToolTipText = "Recapture this URL";
            this.captureButtonColumn.Width = 30;
            // 
            // sitesBindingSource
            // 
            this.sitesBindingSource.DataMember = "sites";
            this.sitesBindingSource.DataSource = this.sitecaputreDataSet;
            // 
            // sitecaputreDataSet
            // 
            this.sitecaputreDataSet.DataSetName = "sitecaputreDataSet";
            this.sitecaputreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sitesTableAdapter
            // 
            this.sitesTableAdapter.ClearBeforeFill = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 408);
            this.Controls.Add(this.capturesDataGridView);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "SiteCapture";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.SizeChanged += new System.EventHandler(this.MainForm_SizeChanged);
            this.sysTrayContextMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.websitesBindingSource)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.capturesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sitecaputreDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem restoreToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip sysTrayContextMenu;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.BindingSource websitesBindingSource;
        private System.Windows.Forms.ToolStripButton aboutToolStripButton;
        private System.Windows.Forms.ToolStripButton settingsToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem deleteAllURLsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton deleteToolStripButton;
        private System.Windows.Forms.ToolStripButton editToolStripButton;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView capturesDataGridView;
        private sitecaptureDataSet sitecaputreDataSet;
        private System.Windows.Forms.BindingSource sitesBindingSource;
        private sitecaptureDataSetTableAdapters.sitesTableAdapter sitesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Url;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrowserWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrowserHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrowserColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Captured;
        private System.Windows.Forms.DataGridViewTextBoxColumn UrlId;
        private System.Windows.Forms.DataGridViewButtonColumn captureButtonColumn;
    }
}
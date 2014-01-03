namespace SiteCapture
{
    partial class SettingsForm
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
            this.browseFoldersButton = new System.Windows.Forms.Button();
            this.maximizePreviewCheckBox = new System.Windows.Forms.CheckBox();
            this.defaultFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.autoSaveRadioButton = new System.Windows.Forms.RadioButton();
            this.showPreviewRadioButton = new System.Windows.Forms.RadioButton();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.sysTrayCheckBox = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // browseFoldersButton
            // 
            this.browseFoldersButton.Location = new System.Drawing.Point(217, 19);
            this.browseFoldersButton.Name = "browseFoldersButton";
            this.browseFoldersButton.Size = new System.Drawing.Size(75, 23);
            this.browseFoldersButton.TabIndex = 11;
            this.browseFoldersButton.Text = "Browse";
            this.browseFoldersButton.UseVisualStyleBackColor = true;
            this.browseFoldersButton.Click += new System.EventHandler(this.browseFoldersButton_Click);
            // 
            // maximizePreviewCheckBox
            // 
            this.maximizePreviewCheckBox.AutoSize = true;
            this.maximizePreviewCheckBox.Location = new System.Drawing.Point(27, 106);
            this.maximizePreviewCheckBox.Name = "maximizePreviewCheckBox";
            this.maximizePreviewCheckBox.Size = new System.Drawing.Size(183, 17);
            this.maximizePreviewCheckBox.TabIndex = 14;
            this.maximizePreviewCheckBox.Text = "Always maximize preview window";
            this.maximizePreviewCheckBox.UseVisualStyleBackColor = true;
            // 
            // defaultFolderTextBox
            // 
            this.defaultFolderTextBox.Location = new System.Drawing.Point(9, 21);
            this.defaultFolderTextBox.Name = "defaultFolderTextBox";
            this.defaultFolderTextBox.Size = new System.Drawing.Size(202, 20);
            this.defaultFolderTextBox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Default Folder";
            // 
            // autoSaveRadioButton
            // 
            this.autoSaveRadioButton.AutoSize = true;
            this.autoSaveRadioButton.Location = new System.Drawing.Point(9, 129);
            this.autoSaveRadioButton.Name = "autoSaveRadioButton";
            this.autoSaveRadioButton.Size = new System.Drawing.Size(189, 17);
            this.autoSaveRadioButton.TabIndex = 15;
            this.autoSaveRadioButton.TabStop = true;
            this.autoSaveRadioButton.Text = "Save after capture to default folder";
            this.autoSaveRadioButton.UseVisualStyleBackColor = true;
            // 
            // showPreviewRadioButton
            // 
            this.showPreviewRadioButton.AutoSize = true;
            this.showPreviewRadioButton.Location = new System.Drawing.Point(9, 83);
            this.showPreviewRadioButton.Name = "showPreviewRadioButton";
            this.showPreviewRadioButton.Size = new System.Drawing.Size(186, 17);
            this.showPreviewRadioButton.TabIndex = 13;
            this.showPreviewRadioButton.TabStop = true;
            this.showPreviewRadioButton.Text = "Show image preview after captrue";
            this.showPreviewRadioButton.UseVisualStyleBackColor = true;
            this.showPreviewRadioButton.CheckedChanged += new System.EventHandler(this.showPreviewRadioButton_CheckedChanged);
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(217, 164);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 17;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(136, 164);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 16;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // sysTrayCheckBox
            // 
            this.sysTrayCheckBox.AutoSize = true;
            this.sysTrayCheckBox.Location = new System.Drawing.Point(9, 60);
            this.sysTrayCheckBox.Name = "sysTrayCheckBox";
            this.sysTrayCheckBox.Size = new System.Drawing.Size(151, 17);
            this.sysTrayCheckBox.TabIndex = 12;
            this.sysTrayCheckBox.Text = "Minimize to the system tray";
            this.sysTrayCheckBox.UseVisualStyleBackColor = true;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Select the default folder";
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.okButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(304, 199);
            this.Controls.Add(this.browseFoldersButton);
            this.Controls.Add(this.maximizePreviewCheckBox);
            this.Controls.Add(this.defaultFolderTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.autoSaveRadioButton);
            this.Controls.Add(this.showPreviewRadioButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.sysTrayCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button browseFoldersButton;
        private System.Windows.Forms.CheckBox maximizePreviewCheckBox;
        private System.Windows.Forms.TextBox defaultFolderTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton autoSaveRadioButton;
        private System.Windows.Forms.RadioButton showPreviewRadioButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.CheckBox sysTrayCheckBox;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}
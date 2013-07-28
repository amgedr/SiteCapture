namespace SiteCapture
{
    partial class EditSiteForm
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
            this.autoExpandCheckBox = new System.Windows.Forms.CheckBox();
            this.urlValidatorBackgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.browserWidthTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.browserHeightTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.label5 = new System.Windows.Forms.Label();
            this.imageWidthTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.imageHeightTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.captureButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // autoExpandCheckBox
            // 
            this.autoExpandCheckBox.AutoSize = true;
            this.autoExpandCheckBox.Location = new System.Drawing.Point(62, 33);
            this.autoExpandCheckBox.Name = "autoExpandCheckBox";
            this.autoExpandCheckBox.Size = new System.Drawing.Size(191, 17);
            this.autoExpandCheckBox.TabIndex = 9;
            this.autoExpandCheckBox.Text = "Expand image to size of web page.";
            this.autoExpandCheckBox.UseVisualStyleBackColor = true;
            this.autoExpandCheckBox.CheckedChanged += new System.EventHandler(this.autoExpandCheckBox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Height:";
            // 
            // browserWidthTextBox
            // 
            this.browserWidthTextBox.Location = new System.Drawing.Point(62, 24);
            this.browserWidthTextBox.Name = "browserWidthTextBox";
            this.browserWidthTextBox.Size = new System.Drawing.Size(79, 20);
            this.browserWidthTextBox.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Width:";
            // 
            // browserHeightTextBox
            // 
            this.browserHeightTextBox.Location = new System.Drawing.Point(62, 50);
            this.browserHeightTextBox.Name = "browserHeightTextBox";
            this.browserHeightTextBox.Size = new System.Drawing.Size(79, 20);
            this.browserHeightTextBox.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.browserWidthTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.browserHeightTextBox);
            this.groupBox2.Location = new System.Drawing.Point(7, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(163, 88);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Browser";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Height:";
            // 
            // imageWidthTextBox
            // 
            this.imageWidthTextBox.Location = new System.Drawing.Point(62, 24);
            this.imageWidthTextBox.Name = "imageWidthTextBox";
            this.imageWidthTextBox.Size = new System.Drawing.Size(79, 20);
            this.imageWidthTextBox.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Width:";
            // 
            // imageHeightTextBox
            // 
            this.imageHeightTextBox.Location = new System.Drawing.Point(62, 50);
            this.imageHeightTextBox.Name = "imageHeightTextBox";
            this.imageHeightTextBox.Size = new System.Drawing.Size(79, 20);
            this.imageHeightTextBox.TabIndex = 3;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.imageWidthTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.imageHeightTextBox);
            this.groupBox1.Location = new System.Drawing.Point(185, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(163, 88);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output Image";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(62, 7);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(277, 20);
            this.urlTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Website:";
            // 
            // captureButton
            // 
            this.captureButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.captureButton.Location = new System.Drawing.Point(192, 164);
            this.captureButton.Name = "captureButton";
            this.captureButton.Size = new System.Drawing.Size(75, 23);
            this.captureButton.TabIndex = 12;
            this.captureButton.Text = "OK";
            this.captureButton.UseVisualStyleBackColor = true;
            this.captureButton.Click += new System.EventHandler(this.captureButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closeButton.Location = new System.Drawing.Point(273, 164);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 13;
            this.closeButton.Text = "Cancel";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // EditSiteForm
            // 
            this.AcceptButton = this.captureButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.closeButton;
            this.ClientSize = new System.Drawing.Size(355, 194);
            this.Controls.Add(this.autoExpandCheckBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.captureButton);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditSiteForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Capture Details";
            this.Load += new System.EventHandler(this.EditSiteForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox autoExpandCheckBox;
        private System.ComponentModel.BackgroundWorker urlValidatorBackgroundWorker;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox browserWidthTextBox;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox browserHeightTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox imageWidthTextBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox imageHeightTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button captureButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label1;
    }
}
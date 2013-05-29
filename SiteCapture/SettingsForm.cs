using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace SiteCapture
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            sysTrayCheckBox.Checked = Properties.Settings.Default.minimizeToTray;
            defaultFolderTextBox.Text = Properties.Settings.Default.defaultFolder;
            showPreviewRadioButton.Checked = Properties.Settings.Default.displayPreviewWindow;
            autoSaveRadioButton.Checked = !Properties.Settings.Default.displayPreviewWindow;
            maximizePreviewCheckBox.Checked = Properties.Settings.Default.maximizePreviewWindow;

            showPreviewRadioButton_CheckedChanged(null, null);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.minimizeToTray = sysTrayCheckBox.Checked;
            Properties.Settings.Default.defaultFolder = defaultFolderTextBox.Text;
            Properties.Settings.Default.displayPreviewWindow = showPreviewRadioButton.Checked;
            Properties.Settings.Default.maximizePreviewWindow = maximizePreviewCheckBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void browseFoldersButton_Click(object sender, EventArgs e)
        {
            if (defaultFolderTextBox.Text != "" && Directory.Exists(defaultFolderTextBox.Text))
                folderBrowserDialog.SelectedPath = defaultFolderTextBox.Text;

            if (folderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
                defaultFolderTextBox.Text = folderBrowserDialog.SelectedPath;
        }

        private void showPreviewRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            maximizePreviewCheckBox.Enabled = showPreviewRadioButton.Checked;
        }
    }
}

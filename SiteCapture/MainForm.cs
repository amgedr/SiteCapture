using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiteCapture
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.sitesTableAdapter.Fill(this.sitecaputreDataSet.sites);
        }

        private void editToolStripButton_Click(object sender, EventArgs e)
        {
            if (capturesDataGridView.SelectedRows.Count != 1)
                return;

            EditSiteForm editSiteForm = new EditSiteForm();
            DataGridViewRow currentRow = capturesDataGridView.SelectedRows[0];

            editSiteForm.urlTextBox.Text = currentRow.Cells[0].Value.ToString();
            editSiteForm.browserWidthTextBox.Text = currentRow.Cells["BrowserWidth"].Value.ToString();
            editSiteForm.browserHeightTextBox.Text = currentRow.Cells["BrowserHeight"].Value.ToString();
            editSiteForm.imageWidthTextBox.Text = currentRow.Cells["ImageWidth"].Value.ToString();
            editSiteForm.imageHeightTextBox.Text = currentRow.Cells["ImageHeight"].Value.ToString();

            editSiteForm.urlTextBox.ReadOnly = true;
            editSiteForm.urlTextBox.TabStop = false;
            editSiteForm.browserWidthTextBox.Focus();

            editSiteForm.ShowDialog(this);

            SaveToDB((long)currentRow.Cells["UrlId"].Value,
                editSiteForm.urlTextBox.Text,
                Convert.ToInt32(editSiteForm.browserWidthTextBox.Text),
                Convert.ToInt32(editSiteForm.browserHeightTextBox.Text),
                Convert.ToInt32(editSiteForm.imageWidthTextBox.Text),
                Convert.ToInt32(editSiteForm.imageHeightTextBox.Text));

            RefreshGrid(capturesDataGridView.SelectedRows[0].Index);
        }

        private void SaveToDB(long urlId, string url, int browserWidth, int browserHeight, int imageWidth, int imageHeight)
        {
            if (sitecaputreDataSet.sites.Select("UrlId = " + urlId.ToString()).Count() == 0)
            {
                int retval = sitesTableAdapter.Insert(url, browserWidth, browserHeight,
                    imageWidth, imageHeight, DateTime.Now);
            }
            else
            {
                sitesTableAdapter.Update(url, browserWidth, browserHeight,
                    imageWidth, imageHeight, DateTime.Now, urlId);
            }
        }

        private void RefreshGrid(int selectionPosition)
        {
            this.sitesTableAdapter.Fill(this.sitecaputreDataSet.sites);
            capturesDataGridView.Refresh();

            if (capturesDataGridView.Rows.Count < 1)
                return;

            capturesDataGridView.Rows[0].Selected = false;  //first row is selected automatically

            if (selectionPosition == -1)  //if selectionPosition == -1 then move to the last record
            {
                capturesDataGridView.Rows[capturesDataGridView.Rows.Count - 1].Selected = true;
            }
            else
            {
                if (selectionPosition < capturesDataGridView.Rows.Count)
                    capturesDataGridView.Rows[selectionPosition].Selected = true;
                else
                    capturesDataGridView.Rows[capturesDataGridView.Rows.Count - 1].Selected = true;
            }
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            EditSiteForm editSiteForm = new EditSiteForm();

            if (editSiteForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SaveToDB(0, editSiteForm.urlTextBox.Text,
                    Convert.ToInt32(editSiteForm.browserWidthTextBox.Text),
                    Convert.ToInt32(editSiteForm.browserHeightTextBox.Text),
                    Convert.ToInt32(editSiteForm.imageWidthTextBox.Text),
                    Convert.ToInt32(editSiteForm.imageHeightTextBox.Text));

                RefreshGrid(-1);
                CaptureScreen(capturesDataGridView.Rows.Count - 1);
            }
        }

        private void capturesDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                e.FormattingApplied = true;
                e.Value = capturesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() + " x " +
                    capturesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            }

            if (e.ColumnIndex == 6)
            {
                e.FormattingApplied = true;
                e.Value = capturesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString() + " x " +
                    capturesDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void deleteToolStripButton_ButtonClick(object sender, EventArgs e)
        {
            if (capturesDataGridView.SelectedRows.Count != 1)
                return;

            long UrlId = Convert.ToInt64(
                capturesDataGridView.SelectedRows[0].Cells["UrlId"].Value.ToString());
            string url = capturesDataGridView.SelectedRows[0].Cells["Url"].Value.ToString();

            DialogResult retVal = MessageBox.Show("Are you sure you want to delete: \n" + url +
                "'?", "SiteCapture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retVal == DialogResult.No)
                return;

            int selectionPosition = capturesDataGridView.SelectedRows[0].Index;

            sitesTableAdapter.Delete(UrlId);
            RefreshGrid(selectionPosition);

        }

        private void deleteAllURLsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult retVal = MessageBox.Show("Are you sure you want to delete ALL the saved links?",
                "SiteCapture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (retVal != DialogResult.Yes)
                return;

            try
            {
                //SqlCeConnection con = sitesTableAdapter.Connection;
                //con.Open();

                //SqlCeCommand cmd = con.CreateCommand();
                //cmd.CommandText = "DELETE FROM sites";
                //cmd.ExecuteNonQuery();

                //con.Close();
                RefreshGrid(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "SiteCapture", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void aboutToolStripButton_Click(object sender, EventArgs e)
        {
            AboutBoxForm aboutBoxForm = new AboutBoxForm();
            aboutBoxForm.ShowDialog(this);
        }

        private void capturesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 9 && e.RowIndex >= 0)
                CaptureScreen(e.RowIndex);
        }

        private void CaptureScreen(int row)
        {
            DataGridViewRow currentRow = capturesDataGridView.Rows[row];

            CaptureForm captureForm = new CaptureForm(
                capturesDataGridView.Rows[row].Cells["Url"].Value.ToString(),
                (int)currentRow.Cells["BrowserWidth"].Value,
                (int)currentRow.Cells["BrowserHeight"].Value,
                (int)currentRow.Cells["ImageWidth"].Value,
                (int)currentRow.Cells["ImageHeight"].Value);

            if (captureForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SaveToDB((long)currentRow.Cells["UrlId"].Value,
                    currentRow.Cells["Url"].Value.ToString(),
                    (int)currentRow.Cells["BrowserWidth"].Value,
                    (int)currentRow.Cells["BrowserHeight"].Value,
                    (int)currentRow.Cells["ImageWidth"].Value,
                    (int)currentRow.Cells["ImageHeight"].Value);

                RefreshGrid(currentRow.Index);
            }

            PreviewForm previewForm = new PreviewForm(captureForm.Screenshot, captureForm.DocumentTitle);

            if (Properties.Settings.Default.maximizePreviewWindow == true)
                previewForm.WindowState = FormWindowState.Maximized;

            previewForm.ShowDialog(this);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {

            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized && Properties.Settings.Default.minimizeToTray)
            {
                notifyIcon.Visible = true;
                this.Visible = false;
            }
        }

        private void restoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            notifyIcon.Visible = false;
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {
            restoreToolStripMenuItem_Click(null, null);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sitecaputreDataSet.sites' table. You can move, or remove it, as needed.
            this.sitesTableAdapter.Fill(this.sitecaputreDataSet.sites);
        }

        private void capturesDataGridView_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 5)
                if (sitesBindingSource.Sort == "BrowserWidth ASC")
                    sitesBindingSource.Sort = "BrowserWidth DESC";
                else
                    sitesBindingSource.Sort = "BrowserWidth ASC";

            if (e.ColumnIndex == 6)
                if (sitesBindingSource.Sort == "ImageWidth ASC")
                    sitesBindingSource.Sort = "ImageWidth DESC";
                else
                    sitesBindingSource.Sort = "ImageWidth ASC";
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CodeCoverageGenerationTool.UserControls
{
    public partial class FolderDialog : UserControl
    {
        public FolderDialog()
        {
            InitializeComponent();
        }

        public string Title
        {
            get { return this.lb_Title.Text; }
            set { this.lb_Title.Text = value; }
        }

        public string ButtonTitle
        {
            get { return this.btn_Browse.Text; }
            set { this.btn_Browse.Text = value; }
        }

        public string FolderPath
        {
            get { return this.txt_FolderPath.Text; }
            set { this.txt_FolderPath.Text = value; }
        }

        public event EventHandler FolderOpened;
        protected virtual void OnFolderOpened(EventArgs e)
        {
            if (this.FolderOpened != null)
                this.FolderOpened(this, e);
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            this.folderBrowserDialog1.SelectedPath = this.txt_FolderPath.Text;
            if (this.folderBrowserDialog1.ShowDialog() != DialogResult.OK) return;
            this.txt_FolderPath.Text = this.folderBrowserDialog1.SelectedPath;
            this.OnFolderOpened(e);
        }

        private void txt_FolderPath_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(this.txt_FolderPath.Text) || System.IO.Directory.Exists(this.txt_FolderPath.Text))
            {
                this.OnFolderOpened(e);
            }
            else this.errorProvider1.SetError(this.txt_FolderPath, "Folder is not found.");
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.txt_FolderPath.Focus();
        }
    }
}

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
    public partial class FilePickupDialog : UserControl
    {
        public FilePickupDialog()
        {
            InitializeComponent();
            this.Height = this.txt_FilePath.Height + this.Margin.Top * 2;
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

        public string FilePath
        {
            get { return this.txt_FilePath.Text; }
            set { this.txt_FilePath.Text = value; }
        }

        public string Filter { get; set; }

        public event EventHandler FileOpened;
        protected virtual void OnFileOpened(EventArgs e)
        {
            if (this.FileOpened != null)
                this.FileOpened(this, e);
        }

        private void btn_Browse_Click(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            this.openFileDialog1.Filter = this.Filter ?? this.openFileDialog1.Filter;
            this.openFileDialog1.FileName = this.txt_FilePath.Text;
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK) return;
            this.txt_FilePath.Text = this.openFileDialog1.FileName;
            this.OnFileOpened(e);
        }

        private void txt_FilePath_Leave(object sender, EventArgs e)
        {
            this.errorProvider1.Clear();
            if (string.IsNullOrWhiteSpace(this.txt_FilePath.Text) || System.IO.File.Exists(this.txt_FilePath.Text))
            {
                this.OnFileOpened(e);
            }
            else this.errorProvider1.SetError(this.txt_FilePath, "File is not found.");
        }

        protected override void OnGotFocus(EventArgs e)
        {
            base.OnGotFocus(e);
            this.txt_FilePath.Focus();
        }
    }
}

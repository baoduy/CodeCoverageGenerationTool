using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCoverageGenerationTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void filePickup1_FileOpened(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.filePickup1.FilePath)) return;
            this.folderDialog1.FolderPath = this.filePickup1.FilePath.Substring(0, this.filePickup1.FilePath.LastIndexOf("\\"));
            var file = Path.GetFileNameWithoutExtension(this.filePickup1.FilePath);
            this.txt_NamespaceFilter.Text = file.Contains(".") ? file.Substring(0, file.LastIndexOf(".")) : file;
        }

        private async void btn_Generate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.filePickup1.FilePath))
            {
                MessageBox.Show("Binary File", "Please provide binary file.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.filePickup1.Focus();
                return;
            }

            if (string.IsNullOrEmpty(this.folderDialog1.FolderPath))
            {
                MessageBox.Show("Output Folder", "Please provide output folder.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.folderDialog1.Focus();
                return;
            }

            this.grInput.Enabled = false;
            this.btn_Generate.Enabled = false;

            this.txt_Output.Text = "Generating Report...";
            this.txt_Output.Text = await ReportGenerationHelper.GenerateReport(this.filePickup1.FilePath, this.txt_NamespaceFilter.Text, this.folderDialog1.FolderPath);

            this.grInput.Enabled = true;
            this.btn_Generate.Enabled = true;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            using (var about = new frAbout())
            {
                about.ShowDialog(this);
            }
        }
    }
}

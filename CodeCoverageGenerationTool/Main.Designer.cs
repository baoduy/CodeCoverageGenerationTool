namespace CodeCoverageGenerationTool
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_About = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Generate = new System.Windows.Forms.Button();
            this.grInput = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_NamespaceFilter = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.folderDialog1 = new CodeCoverageGenerationTool.UserControls.FolderDialog();
            this.filePickup1 = new CodeCoverageGenerationTool.UserControls.FilePickupDialog();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_About});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(683, 48);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_About
            // 
            this.btn_About.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btn_About.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_About.Image = ((System.Drawing.Image)(resources.GetObject("btn_About.Image")));
            this.btn_About.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(44, 45);
            this.btn_About.Text = "toolStripButton1";
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Generate);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(0, 656);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(683, 51);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btn_Generate
            // 
            this.btn_Generate.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Generate.Location = new System.Drawing.Point(605, 16);
            this.btn_Generate.Name = "btn_Generate";
            this.btn_Generate.Size = new System.Drawing.Size(75, 32);
            this.btn_Generate.TabIndex = 0;
            this.btn_Generate.Text = "Generate";
            this.btn_Generate.UseVisualStyleBackColor = true;
            this.btn_Generate.Click += new System.EventHandler(this.btn_Generate_Click);
            // 
            // grInput
            // 
            this.grInput.Controls.Add(this.tableLayoutPanel1);
            this.grInput.Controls.Add(this.folderDialog1);
            this.grInput.Controls.Add(this.filePickup1);
            this.grInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.grInput.Location = new System.Drawing.Point(0, 48);
            this.grInput.Name = "grInput";
            this.grInput.Size = new System.Drawing.Size(683, 98);
            this.grInput.TabIndex = 2;
            this.grInput.TabStop = false;
            this.grInput.Text = "Inputs";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txt_NamespaceFilter, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 70);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(677, 25);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Namespace Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_NamespaceFilter
            // 
            this.txt_NamespaceFilter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_NamespaceFilter.Location = new System.Drawing.Point(113, 3);
            this.txt_NamespaceFilter.Margin = new System.Windows.Forms.Padding(3, 3, 45, 3);
            this.txt_NamespaceFilter.Name = "txt_NamespaceFilter";
            this.txt_NamespaceFilter.Size = new System.Drawing.Size(519, 20);
            this.txt_NamespaceFilter.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_Output);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(683, 510);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // txt_Output
            // 
            this.txt_Output.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Output.Location = new System.Drawing.Point(3, 16);
            this.txt_Output.Multiline = true;
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ReadOnly = true;
            this.txt_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Output.Size = new System.Drawing.Size(677, 491);
            this.txt_Output.TabIndex = 0;
            // 
            // folderDialog1
            // 
            this.folderDialog1.ButtonTitle = "...";
            this.folderDialog1.Dock = System.Windows.Forms.DockStyle.Top;
            this.folderDialog1.FolderPath = "";
            this.folderDialog1.Location = new System.Drawing.Point(3, 42);
            this.folderDialog1.Name = "folderDialog1";
            this.folderDialog1.Size = new System.Drawing.Size(677, 28);
            this.folderDialog1.TabIndex = 1;
            this.folderDialog1.Title = "Output Folder   ";
            // 
            // filePickup1
            // 
            this.filePickup1.ButtonTitle = "...";
            this.filePickup1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filePickup1.FilePath = "";
            this.filePickup1.Filter = "Binary|*.dll";
            this.filePickup1.Location = new System.Drawing.Point(3, 16);
            this.filePickup1.Name = "filePickup1";
            this.filePickup1.Size = new System.Drawing.Size(677, 26);
            this.filePickup1.TabIndex = 0;
            this.filePickup1.Title = "Unit Test Binary";
            this.filePickup1.FileOpened += new System.EventHandler(this.filePickup1_FileOpened);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 707);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grInput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Code Coverage Report Generator";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.grInput.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Generate;
        private System.Windows.Forms.GroupBox grInput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_Output;
        private UserControls.FilePickupDialog filePickup1;
        private UserControls.FolderDialog folderDialog1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_NamespaceFilter;
        private System.Windows.Forms.ToolStripButton btn_About;
    }
}


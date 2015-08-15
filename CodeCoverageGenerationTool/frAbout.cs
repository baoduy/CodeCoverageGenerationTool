using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Services.Protocols;
using System.Windows.Forms;

namespace CodeCoverageGenerationTool
{
    public partial class frAbout : Form
    {
        public frAbout()
        {
            InitializeComponent();
        }

        private void frAbout_Load(object sender, EventArgs e)
        {
            var attribute = Assembly.GetExecutingAssembly()
                    .GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false)
                    .Cast<AssemblyDescriptionAttribute>().FirstOrDefault();
            this.lb_Version.Text = attribute?.Description;

            if (System.IO.File.Exists("Thirdparties.html"))
            {
                var html = System.IO.File.ReadAllText("Thirdparties.html");
                this.webBrowser1.DocumentText = html;
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.webBrowser1.Visible = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Nomlyzer
{
    public partial class SignificadoExt : Form
    {
        public SignificadoExt(string Nombre)
        {
            InitializeComponent();
            Uri nomurl = new Uri("http://www.misabueso.com/nombres/nombre.php?nombre=" + Nombre, UriKind.Absolute);
            Sigex.Url = nomurl;
        }

        private void SignificadoExt_Load(object sender, EventArgs e)
        {
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(Sigex.Url.AbsoluteUri);
        }

        private void SignificadoExt_Load_1(object sender, EventArgs e)
        {

        }
    }
}

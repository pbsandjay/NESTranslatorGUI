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

namespace NES_Decom_GUI
{
    public partial class Documentation : Form
    {
        public Documentation()
        {
            InitializeComponent();
        }

        private void Documentation_Load(object sender, EventArgs e)
        {
            webBrowser2.Navigate(new Uri(Environment.CurrentDirectory + @"/Documentation.html"));
        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace NES_Decom_GUI
{
    public partial class NESForm : Form
    {
        public NESForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextDirectory.Text = "";
            ROMDirectory.Text = "";

        }

        private void TextFile_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ROMSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ROMSel = new OpenFileDialog();
            ROMSel.Filter = "NES ROM Files (*.nes)|*.nes|All Files (*.*|*.*";

            if (ROMSel.ShowDialog() == DialogResult.OK)
            {
                ROMDirectory.Text = ROMSel.FileName;

            }
        }

        private void TextSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog TextSel = new OpenFileDialog();
            TextSel.Filter = "Text Files (*.txt)|*.txt|All Files (*.*|*.*";

            if (TextSel.ShowDialog() == DialogResult.OK)
            {
                TextDirectory.Text = TextSel.FileName;

            }
        }

        private void TextLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

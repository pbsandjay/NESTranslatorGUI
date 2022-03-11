using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NES_Decom;


namespace NES_Decom_GUI
{
    public partial class NESForm : Form
    {
        public NESForm()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {

            TextDirectory.Text = ""; //Text File Directory?
            ROMDirectory.Text = ""; //ROM Directory?
            gameName_Lb.Text = ""; //ROM Name?
            ROMType_Lb.Text = ""; //Type of ROM?
            mirroring_Lb.Text = ""; //Type of mirroring?         
            sram_Lb.Text = ""; //SRAM?
            trainer_Lb.Text = ""; //Trainer?
            vram_Lb.Text = ""; //VRAM type?

        }

        public void TextFile_Click(object sender, EventArgs e)
        {

        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void label2_Click(object sender, EventArgs e)
        {

        }

        public void ROMSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog ROMSel = new OpenFileDialog();
            ROMSel.Filter = "NES ROM Files (*.nes)|*.nes|All Files (*.*|*.*";

            if (ROMSel.ShowDialog() == DialogResult.OK)
            {
                ROMDirectory.Text = ROMSel.FileName;

            }

            string filename = Path.GetFileNameWithoutExtension(ROMSel.FileName);
            string upper = filename.ToUpper();
            gameName_Lb.Text = upper;

        }

        public void TextSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog TextSel = new OpenFileDialog();
            TextSel.Filter = "Text Files (*.txt)|*.txt|All Files (*.*|*.*";

            if (TextSel.ShowDialog() == DialogResult.OK)
            {
                TextDirectory.Text = TextSel.FileName;

            }
        }

        public void sram_Lb_Click(object sender, EventArgs e)
        {

        }

        public void TextLabel_Click(object sender, EventArgs e)
        {

        }

        public void mirroring_Lb_Click(object sender, EventArgs e)
        {

        }

        public void gameName_Lb_Click(object sender, EventArgs e)
        {

        }

        public void ROMType_Lb_Click(object sender, EventArgs e)
        {

        }

        public void romInfo_Lb_Click(object sender, EventArgs e)
        {

        }
        public void trainer_Lb_Click(object sender, EventArgs e)
        {

        }
        public void vram_Lb_Click(object sender, EventArgs e)
        {

        }

        unsafe private void translate_Btn_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream(ROMDirectory.Text, FileMode.Open))
            {


                IList<byte> hexBuffer = new List<byte>();
                int hex;

                fs.Seek(0, SeekOrigin.Current);


                for (int i = 0; i < fs.Length; i++)
                {
                    hex = fs.ReadByte();
                    hexBuffer.Add((byte)hex);
                }

                byte[] byteArray = hexBuffer.ToArray();
                //bool NESFormat = false;

                int NESheader = 16; //size of the iNES Header. 16 bytes (0x10 OR 10h)
                int defaultPRG = 16384; //default size of the PRG ROM data, increases by a multiplication of ROM[4] (list how many PRG banks there are at this area of ROM)
                int defaultCHR = 8192; //default size of the CHR ROM data, increases by a multiplication of ROM[5] (list how many CHR banks there are at this area of CHR)

                byte PRGLoc = byteArray[4]; //takes this number and multiplies it by defaultPRG to get the size of the Program Data.
                byte CHRLoc = byteArray[5]; //takes the number stored at this index and multiplies it by the defaultCHR to get the Character Data.
                int PRGSize = defaultPRG * PRGLoc; //get the size in bytes of the PRG 
                int CHRSize = defaultCHR * CHRLoc; //get the size in bytes of the CHR

                int flag6 = byteArray[6];
                string flag6Convert = Convert.ToString(flag6, 2);

                char[] flag6Char = flag6Convert.ToCharArray();


                using (StreamWriter sr = new StreamWriter(TextDirectory.Text, false, Encoding.ASCII))
                {


                    if (flag6Char[4] == '0')
                    {
                        sr.WriteLine(mirroring_Lb.Text = gameName_Lb.Text + " uses Horizontal Mirroring");
                        mirroring_Lb.Text = gameName_Lb.Text + " uses Horizontal Mirroring";

                    }
                    else
                    {
                        sr.WriteLine(mirroring_Lb.Text = gameName_Lb.Text + " uses Vertical Mirroring");
                        mirroring_Lb.Text = gameName_Lb.Text + " uses Vertical Mirroring";


                    }

                    if (flag6Char[3] == '0')
                    {
                        sr.WriteLine(sram_Lb.Text = gameName_Lb.Text + " does not use SRAM");
                        sram_Lb.Text = gameName_Lb.Text + " does not use SRAM";
                    }
                    else
                    {
                        sr.WriteLine(sram_Lb.Text = gameName_Lb.Text + " uses SRAM");
                        sram_Lb.Text = gameName_Lb.Text + " uses SRAM";
                    }

                    if (flag6Char[2] == '0')
                    {
                        sr.WriteLine(trainer_Lb.Text = gameName_Lb.Text + " does not use a Trainer");
                        trainer_Lb.Text = gameName_Lb.Text + " does not use a Trainer";
                    }
                    else
                    {
                        sr.WriteLine(trainer_Lb.Text = gameName_Lb.Text + " uses a Trainer");
                        trainer_Lb.Text = gameName_Lb.Text + " uses a Trainer";
                    }

                    if (flag6Char[1] == '0')
                    {
                        sr.WriteLine(vram_Lb.Text = gameName_Lb.Text + " does not use four-screen VRAM");
                        vram_Lb.Text = gameName_Lb.Text + " does not use four-screen VRAM";
                    }
                    else
                    {
                        sr.WriteLine(vram_Lb.Text = gameName_Lb.Text + " uses four-screen VRAM");
                        vram_Lb.Text = gameName_Lb.Text + " uses four-screen VRAM";

                    }

                    bool iNESFormat = false;
                    if (Convert.ToChar(byteArray[0]) == 'N' && Convert.ToChar(byteArray[1]) == 'E' && Convert.ToChar(byteArray[2]) == 'S' && byteArray[3] == 0x1A)
                    {
                        sr.WriteLine(ROMType_Lb.Text = gameName_Lb.Text + " uses the iNES 1.0 ROM header");
                        ROMType_Lb.Text = gameName_Lb.Text + " uses the iNES 1.0 ROM header";
                        sr.WriteLine("--------------------START OF CODE----------------");
                        iNESFormat = true;
                    }
                    if (iNESFormat == true && (byteArray[7] & 0x0c) == 0x08)
                    {
                        sr.WriteLine(ROMType_Lb.Text = gameName_Lb.Text + " uses the iNES 2.0 ROM header");
                        ROMType_Lb.Text = gameName_Lb.Text + " uses the iNES 2.0 ROM header";
                        sr.WriteLine("--------------------START OF CODE----------------");
                    }


                    sr.AutoFlush = true;
                }


                fixed (byte* ToArrayBytes = byteArray)
                {

                    NESDisassemble nes = new NESDisassemble();

                    int pc = NESheader; //we want to start the PC at where the the header ends. 

                    while (pc < byteArray.Length - (CHRSize + pc))  //16 -> end of PRG ROM
                    {
                        pc += nes.Disassembler(ToArrayBytes, pc, TextDirectory.Text);
                    }
                }

                outputBox.Text = File.ReadAllText(TextDirectory.Text);

            }
        }
    }
}
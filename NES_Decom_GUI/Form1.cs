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
            translate_Btn.Enabled = false;


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
            ROMSel.Filter = "NES ROM Files (*.nes)|*.nes";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string RomNotSelected = "ROM file not selected, try again?";
            string RomError = "ERROR";

            bool RomSelector = true;
            while (RomSelector == true)
            {
                if (ROMSel.ShowDialog() == DialogResult.OK)
                {
                    ROMDirectory.Text = ROMSel.FileName;
                    RomSelector = false;
                }
                else
                {
                    DialogResult result = MessageBox.Show(RomNotSelected, RomError, buttons);
                    if (result == DialogResult.Yes)
                    {
                        RomSelector = true;
                    }

                    else
                    {
                        RomSelector = false;
                    }
                }
            }
            string filename = Path.GetFileNameWithoutExtension(ROMSel.FileName);
            string upper = filename.ToUpper();
            gameTxt.Text = upper;
        }


        public void TextSel_Click(object sender, EventArgs e)
        {
            OpenFileDialog TextSel = new OpenFileDialog();
            SaveFileDialog TextSave = new SaveFileDialog();
            TextSel.Filter = "Text Files (*.txt)|*.txt";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            string TxtNotSelected = "Text file not selected! Would you like to create one?";
            string TxtError = "ERROR";

            bool TxtSelector = true;

            while (TxtSelector == true)
            {

                if (TextSel.ShowDialog() == DialogResult.OK)
                {
                    TextDirectory.Text = TextSel.FileName;
                    TxtSelector = false;
                    translate_Btn.Enabled = true;
                }


                else
                {
                    DialogResult result = MessageBox.Show(TxtNotSelected, TxtError, buttons);
                    if (result == DialogResult.Yes)
                    {
                        TextSave.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                        TextSave.Filter = "Text Files (*.txt)|*.txt";
                        TextSave.ShowDialog();
                        TextSel.FileName = TextSave.FileName;

                        FileStream fs = new FileStream(TextSave.FileName, FileMode.Create);
                        fs.Close();

                        //Console.WriteLine(TextDirectory.Text);

                    }
                    if (result == DialogResult.No)
                    {
                        TxtSelector = false;
                    }
                    translate_Btn.Enabled = false;
                }
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

                PRGtxt.Text = Convert.ToString(PRGSize) + " bytes";
                CHRtxt.Text = Convert.ToString(CHRSize) + " bytes";


                //Fix everything from here....
                uint flag6 = byteArray[6];
                uint flag7 = byteArray[7];
                string flag6Convert = Convert.ToString(flag6, 2).PadLeft(8, '0');
                string flag7Convert = Convert.ToString(flag7, 2).PadLeft(8, '0');

                uint lowerNybble = flag6 >> 4;
                string flag6Binary = Convert.ToString(lowerNybble, 2).PadLeft(4, '0');
                uint upperNybble = flag7 >> 4;
                string flag7Binary = Convert.ToString(upperNybble, 2).PadLeft(4, '0');

                string binaryAppend = flag7Binary + flag6Binary;
                int mapperNumber = Convert.ToInt32(binaryAppend, 2);
                Mappertxt.Text = Convert.ToString(mapperNumber);

                MapperList MapList = new MapperList();
                string Mapper = "";
                string MapperComp = MapList.Mappers(mapperNumber, Mapper);
                Mappertxt.Text = Convert.ToString(mapperNumber) + "/" + MapperComp;
                //To here. This is way too damn messy and hacky. 


                char[] flag6Char = flag6Convert.ToCharArray();


                


                


                using (StreamWriter sr = new StreamWriter(TextDirectory.Text, false, Encoding.ASCII))
                {


                    if (flag6Char[7] == '0')
                    {
                        sr.WriteLine(gameTxt.Text + " uses Horizontal Mirroring");
                        mirrorTxt.Text = "Horizontal";

                    }
                    else
                    {
                        sr.WriteLine(gameTxt.Text + " uses Vertical Mirroring");
                        mirrorTxt.Text = "Vertical";


                    }

                    if (flag6Char[6] == '0')
                    {
                        sr.WriteLine(gameTxt.Text + " does not use SRAM");
                        SRAMtxt.Text = "No";
                    }
                    else
                    {
                        sr.WriteLine(sram_Lb.Text = gameTxt.Text + " uses SRAM");
                        SRAMtxt.Text = "Yes";
                    }

                    if (flag6Char[5] == '0')
                    {
                        sr.WriteLine(gameTxt.Text + " does not use a Trainer");
                        Trainertxt.Text = "No";
                    }
                    else
                    {
                        sr.WriteLine(gameTxt.Text + " uses a Trainer");
                        Trainertxt.Text = "Yes";
                    }

                    if (flag6Char[4] == '0')
                    {
                        sr.WriteLine(gameTxt.Text + " does not use four-screen VRAM");
                        VRAMtxt.Text = "No";
                    }
                    else
                    {
                        sr.WriteLine(gameTxt.Text + " uses four-screen VRAM");
                        VRAMtxt.Text = "Yes";

                    }

                    sr.WriteLine(gameTxt.Text + " PRG size is " + PRGSize + " bytes");
                    sr.WriteLine(gameTxt.Text + " CHR size is " + CHRSize + " bytes");

                    bool iNESFormat = false;
                    if (Convert.ToChar(byteArray[0]) == 'N' && Convert.ToChar(byteArray[1]) == 'E' && Convert.ToChar(byteArray[2]) == 'S' && byteArray[3] == 0x1A)
                    {
                        sr.WriteLine(gameTxt.Text + " uses the iNES 1.0 ROM header");
                        ROMHeadertxt.Text = "iNES 1.0";
                        sr.WriteLine("------------------------------START OF CODE--------------------------");
                        iNESFormat = true;
                    }
                    if (iNESFormat == true && (byteArray[7] & 0x0c) == 0x08)
                    {
                        sr.WriteLine(gameTxt.Text + " uses the iNES 2.0 ROM header");
                        ROMHeadertxt.Text = "iNES 2.0";
                        sr.WriteLine("------------------------------START OF CODE--------------------------");
                    }


                    sr.AutoFlush = true;
                }


                fixed (byte* ToArrayBytes = byteArray)
                {

                    NESDisassemble nes = new NESDisassemble();

                    int pc = NESheader; //we want to start the PC at where the the header ends. 

                    while (pc < PRGSize - pc)  //16 -> end of PRG ROM (Could go back to "byteArray.Length - (CHRSize + pc)" later...) 
                    {
                        pc += nes.Disassembler(ToArrayBytes, pc, TextDirectory.Text);
                    }
                }

                outputBox.Text = File.ReadAllText(TextDirectory.Text);

            }
        }

        private void CreateFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void gameTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
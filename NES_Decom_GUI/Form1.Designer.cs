
namespace NES_Decom_GUI
{
    partial class NESForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NESForm));
            this.label1 = new System.Windows.Forms.Label();
            this.TextFile = new System.Windows.Forms.Label();
            this.ROMSel = new System.Windows.Forms.Button();
            this.TextSel = new System.Windows.Forms.Button();
            this.ROMDirectory = new System.Windows.Forms.Label();
            this.TextDirectory = new System.Windows.Forms.Label();
            this.OpenROMDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenTextDialog = new System.Windows.Forms.OpenFileDialog();
            this.ROMHeader_lb = new System.Windows.Forms.Label();
            this.gameName_Lb = new System.Windows.Forms.Label();
            this.romInfo_Lb = new System.Windows.Forms.Label();
            this.translate_Btn = new System.Windows.Forms.Button();
            this.mirroring_Lb = new System.Windows.Forms.Label();
            this.sram_Lb = new System.Windows.Forms.Label();
            this.vram_Lb = new System.Windows.Forms.Label();
            this.trainer_Lb = new System.Windows.Forms.Label();
            this.outputBox = new System.Windows.Forms.TextBox();
            this.CHR_Lb = new System.Windows.Forms.Label();
            this.Prg_Lb = new System.Windows.Forms.Label();
            this.mapperLb = new System.Windows.Forms.Label();
            this.gameTxt = new System.Windows.Forms.TextBox();
            this.mirrorTxt = new System.Windows.Forms.TextBox();
            this.SRAMtxt = new System.Windows.Forms.TextBox();
            this.Trainertxt = new System.Windows.Forms.TextBox();
            this.VRAMtxt = new System.Windows.Forms.TextBox();
            this.ROMHeadertxt = new System.Windows.Forms.TextBox();
            this.PRGtxt = new System.Windows.Forms.TextBox();
            this.CHRtxt = new System.Windows.Forms.TextBox();
            this.Mappertxt = new System.Windows.Forms.TextBox();
            this.CreateFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.hexBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROM File: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextFile
            // 
            this.TextFile.AutoSize = true;
            this.TextFile.Location = new System.Drawing.Point(93, 57);
            this.TextFile.Name = "TextFile";
            this.TextFile.Size = new System.Drawing.Size(53, 13);
            this.TextFile.TabIndex = 1;
            this.TextFile.Text = "Text File: ";
            this.TextFile.Click += new System.EventHandler(this.TextFile_Click);
            // 
            // ROMSel
            // 
            this.ROMSel.Location = new System.Drawing.Point(12, 9);
            this.ROMSel.Name = "ROMSel";
            this.ROMSel.Size = new System.Drawing.Size(75, 23);
            this.ROMSel.TabIndex = 2;
            this.ROMSel.Text = "Select ROM";
            this.ROMSel.UseVisualStyleBackColor = true;
            this.ROMSel.Click += new System.EventHandler(this.ROMSel_Click);
            // 
            // TextSel
            // 
            this.TextSel.Location = new System.Drawing.Point(12, 52);
            this.TextSel.Name = "TextSel";
            this.TextSel.Size = new System.Drawing.Size(75, 23);
            this.TextSel.TabIndex = 3;
            this.TextSel.Text = "Select Text";
            this.TextSel.UseVisualStyleBackColor = true;
            this.TextSel.Click += new System.EventHandler(this.TextSel_Click);
            // 
            // ROMDirectory
            // 
            this.ROMDirectory.AutoSize = true;
            this.ROMDirectory.Location = new System.Drawing.Point(152, 14);
            this.ROMDirectory.Name = "ROMDirectory";
            this.ROMDirectory.Size = new System.Drawing.Size(49, 13);
            this.ROMDirectory.TabIndex = 4;
            this.ROMDirectory.Text = "Directory";
            this.ROMDirectory.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextDirectory
            // 
            this.TextDirectory.AutoSize = true;
            this.TextDirectory.Location = new System.Drawing.Point(152, 57);
            this.TextDirectory.Name = "TextDirectory";
            this.TextDirectory.Size = new System.Drawing.Size(49, 13);
            this.TextDirectory.TabIndex = 5;
            this.TextDirectory.Text = "Directory";
            this.TextDirectory.Click += new System.EventHandler(this.TextLabel_Click);
            // 
            // OpenROMDialog
            // 
            this.OpenROMDialog.FileName = "openFileDialog1";
            // 
            // OpenTextDialog
            // 
            this.OpenTextDialog.FileName = "openFileDialog1";
            // 
            // ROMHeader_lb
            // 
            this.ROMHeader_lb.AutoSize = true;
            this.ROMHeader_lb.Location = new System.Drawing.Point(399, 171);
            this.ROMHeader_lb.Name = "ROMHeader_lb";
            this.ROMHeader_lb.Size = new System.Drawing.Size(45, 13);
            this.ROMHeader_lb.TabIndex = 7;
            this.ROMHeader_lb.Text = "Header:";
            this.ROMHeader_lb.Click += new System.EventHandler(this.ROMType_Lb_Click);
            // 
            // gameName_Lb
            // 
            this.gameName_Lb.AutoSize = true;
            this.gameName_Lb.Location = new System.Drawing.Point(406, 41);
            this.gameName_Lb.Name = "gameName_Lb";
            this.gameName_Lb.Size = new System.Drawing.Size(38, 13);
            this.gameName_Lb.TabIndex = 8;
            this.gameName_Lb.Text = "Game:";
            this.gameName_Lb.Click += new System.EventHandler(this.gameName_Lb_Click);
            // 
            // romInfo_Lb
            // 
            this.romInfo_Lb.AutoSize = true;
            this.romInfo_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romInfo_Lb.Location = new System.Drawing.Point(458, 14);
            this.romInfo_Lb.Name = "romInfo_Lb";
            this.romInfo_Lb.Size = new System.Drawing.Size(165, 20);
            this.romInfo_Lb.TabIndex = 9;
            this.romInfo_Lb.Text = "ROM INFORMATION:";
            this.romInfo_Lb.Click += new System.EventHandler(this.romInfo_Lb_Click);
            // 
            // translate_Btn
            // 
            this.translate_Btn.Location = new System.Drawing.Point(12, 83);
            this.translate_Btn.Name = "translate_Btn";
            this.translate_Btn.Size = new System.Drawing.Size(314, 23);
            this.translate_Btn.TabIndex = 10;
            this.translate_Btn.Text = "TRANSLATE";
            this.translate_Btn.UseVisualStyleBackColor = true;
            this.translate_Btn.Click += new System.EventHandler(this.translate_Btn_Click);
            // 
            // mirroring_Lb
            // 
            this.mirroring_Lb.AutoSize = true;
            this.mirroring_Lb.Location = new System.Drawing.Point(394, 67);
            this.mirroring_Lb.Name = "mirroring_Lb";
            this.mirroring_Lb.Size = new System.Drawing.Size(50, 13);
            this.mirroring_Lb.TabIndex = 11;
            this.mirroring_Lb.Text = "Mirroring:";
            this.mirroring_Lb.Click += new System.EventHandler(this.mirroring_Lb_Click);
            // 
            // sram_Lb
            // 
            this.sram_Lb.AutoSize = true;
            this.sram_Lb.Location = new System.Drawing.Point(403, 93);
            this.sram_Lb.Name = "sram_Lb";
            this.sram_Lb.Size = new System.Drawing.Size(41, 13);
            this.sram_Lb.TabIndex = 13;
            this.sram_Lb.Text = "SRAM:";
            this.sram_Lb.Click += new System.EventHandler(this.sram_Lb_Click);
            // 
            // vram_Lb
            // 
            this.vram_Lb.AutoSize = true;
            this.vram_Lb.Location = new System.Drawing.Point(342, 145);
            this.vram_Lb.Name = "vram_Lb";
            this.vram_Lb.Size = new System.Drawing.Size(102, 13);
            this.vram_Lb.TabIndex = 15;
            this.vram_Lb.Text = "Four Screen VRAM:";
            this.vram_Lb.Click += new System.EventHandler(this.vram_Lb_Click);
            // 
            // trainer_Lb
            // 
            this.trainer_Lb.AutoSize = true;
            this.trainer_Lb.Location = new System.Drawing.Point(401, 119);
            this.trainer_Lb.Name = "trainer_Lb";
            this.trainer_Lb.Size = new System.Drawing.Size(43, 13);
            this.trainer_Lb.TabIndex = 16;
            this.trainer_Lb.Text = "Trainer:";
            this.trainer_Lb.Click += new System.EventHandler(this.trainer_Lb_Click);
            // 
            // outputBox
            // 
            this.outputBox.Location = new System.Drawing.Point(12, 112);
            this.outputBox.Multiline = true;
            this.outputBox.Name = "outputBox";
            this.outputBox.ReadOnly = true;
            this.outputBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outputBox.Size = new System.Drawing.Size(314, 210);
            this.outputBox.TabIndex = 17;
            this.outputBox.TextChanged += new System.EventHandler(this.outputBox_TextChanged);
            // 
            // CHR_Lb
            // 
            this.CHR_Lb.AutoSize = true;
            this.CHR_Lb.Location = new System.Drawing.Point(388, 219);
            this.CHR_Lb.Name = "CHR_Lb";
            this.CHR_Lb.Size = new System.Drawing.Size(56, 13);
            this.CHR_Lb.TabIndex = 18;
            this.CHR_Lb.Text = "CHR Size:";
            // 
            // Prg_Lb
            // 
            this.Prg_Lb.AutoSize = true;
            this.Prg_Lb.Location = new System.Drawing.Point(388, 196);
            this.Prg_Lb.Name = "Prg_Lb";
            this.Prg_Lb.Size = new System.Drawing.Size(56, 13);
            this.Prg_Lb.TabIndex = 19;
            this.Prg_Lb.Text = "PRG Size:";
            // 
            // mapperLb
            // 
            this.mapperLb.AutoSize = true;
            this.mapperLb.Location = new System.Drawing.Point(398, 245);
            this.mapperLb.Name = "mapperLb";
            this.mapperLb.Size = new System.Drawing.Size(46, 13);
            this.mapperLb.TabIndex = 20;
            this.mapperLb.Text = "Mapper:";
            // 
            // gameTxt
            // 
            this.gameTxt.Location = new System.Drawing.Point(450, 38);
            this.gameTxt.Name = "gameTxt";
            this.gameTxt.ReadOnly = true;
            this.gameTxt.Size = new System.Drawing.Size(173, 20);
            this.gameTxt.TabIndex = 21;
            this.gameTxt.TextChanged += new System.EventHandler(this.gameTxt_TextChanged);
            // 
            // mirrorTxt
            // 
            this.mirrorTxt.Location = new System.Drawing.Point(450, 64);
            this.mirrorTxt.Name = "mirrorTxt";
            this.mirrorTxt.ReadOnly = true;
            this.mirrorTxt.Size = new System.Drawing.Size(173, 20);
            this.mirrorTxt.TabIndex = 22;
            // 
            // SRAMtxt
            // 
            this.SRAMtxt.Location = new System.Drawing.Point(450, 90);
            this.SRAMtxt.Name = "SRAMtxt";
            this.SRAMtxt.ReadOnly = true;
            this.SRAMtxt.Size = new System.Drawing.Size(173, 20);
            this.SRAMtxt.TabIndex = 23;
            // 
            // Trainertxt
            // 
            this.Trainertxt.Location = new System.Drawing.Point(450, 116);
            this.Trainertxt.Name = "Trainertxt";
            this.Trainertxt.ReadOnly = true;
            this.Trainertxt.Size = new System.Drawing.Size(173, 20);
            this.Trainertxt.TabIndex = 24;
            // 
            // VRAMtxt
            // 
            this.VRAMtxt.Location = new System.Drawing.Point(450, 142);
            this.VRAMtxt.Name = "VRAMtxt";
            this.VRAMtxt.ReadOnly = true;
            this.VRAMtxt.Size = new System.Drawing.Size(173, 20);
            this.VRAMtxt.TabIndex = 25;
            // 
            // ROMHeadertxt
            // 
            this.ROMHeadertxt.Location = new System.Drawing.Point(450, 168);
            this.ROMHeadertxt.Name = "ROMHeadertxt";
            this.ROMHeadertxt.ReadOnly = true;
            this.ROMHeadertxt.Size = new System.Drawing.Size(173, 20);
            this.ROMHeadertxt.TabIndex = 26;
            // 
            // PRGtxt
            // 
            this.PRGtxt.Location = new System.Drawing.Point(450, 193);
            this.PRGtxt.Name = "PRGtxt";
            this.PRGtxt.ReadOnly = true;
            this.PRGtxt.Size = new System.Drawing.Size(173, 20);
            this.PRGtxt.TabIndex = 27;
            // 
            // CHRtxt
            // 
            this.CHRtxt.Location = new System.Drawing.Point(450, 216);
            this.CHRtxt.Name = "CHRtxt";
            this.CHRtxt.ReadOnly = true;
            this.CHRtxt.Size = new System.Drawing.Size(173, 20);
            this.CHRtxt.TabIndex = 28;
            // 
            // Mappertxt
            // 
            this.Mappertxt.Location = new System.Drawing.Point(450, 242);
            this.Mappertxt.Name = "Mappertxt";
            this.Mappertxt.ReadOnly = true;
            this.Mappertxt.Size = new System.Drawing.Size(173, 20);
            this.Mappertxt.TabIndex = 29;
            // 
            // CreateFileDialog
            // 
            this.CreateFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.CreateFileDialog_FileOk);
            // 
            // hexBtn
            // 
            this.hexBtn.Location = new System.Drawing.Point(450, 268);
            this.hexBtn.Name = "hexBtn";
            this.hexBtn.Size = new System.Drawing.Size(173, 59);
            this.hexBtn.TabIndex = 30;
            this.hexBtn.Text = "Hex Viewer";
            this.hexBtn.UseVisualStyleBackColor = true;
            this.hexBtn.Click += new System.EventHandler(this.hexBtn_Click);
            // 
            // NESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(630, 337);
            this.Controls.Add(this.hexBtn);
            this.Controls.Add(this.Mappertxt);
            this.Controls.Add(this.CHRtxt);
            this.Controls.Add(this.PRGtxt);
            this.Controls.Add(this.ROMHeadertxt);
            this.Controls.Add(this.VRAMtxt);
            this.Controls.Add(this.Trainertxt);
            this.Controls.Add(this.SRAMtxt);
            this.Controls.Add(this.mirrorTxt);
            this.Controls.Add(this.gameTxt);
            this.Controls.Add(this.mapperLb);
            this.Controls.Add(this.Prg_Lb);
            this.Controls.Add(this.CHR_Lb);
            this.Controls.Add(this.outputBox);
            this.Controls.Add(this.trainer_Lb);
            this.Controls.Add(this.vram_Lb);
            this.Controls.Add(this.sram_Lb);
            this.Controls.Add(this.mirroring_Lb);
            this.Controls.Add(this.translate_Btn);
            this.Controls.Add(this.romInfo_Lb);
            this.Controls.Add(this.gameName_Lb);
            this.Controls.Add(this.ROMHeader_lb);
            this.Controls.Add(this.TextDirectory);
            this.Controls.Add(this.ROMDirectory);
            this.Controls.Add(this.TextSel);
            this.Controls.Add(this.ROMSel);
            this.Controls.Add(this.TextFile);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NESForm";
            this.Text = "NES Translator ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextFile;
        private System.Windows.Forms.Button ROMSel;
        private System.Windows.Forms.Button TextSel;
        private System.Windows.Forms.OpenFileDialog OpenROMDialog;
        private System.Windows.Forms.OpenFileDialog OpenTextDialog;
        private System.Windows.Forms.Label romInfo_Lb;
        private System.Windows.Forms.Button translate_Btn;
        private System.Windows.Forms.Label gameName_Lb;
        private System.Windows.Forms.Label ROMDirectory;
        private System.Windows.Forms.Label TextDirectory;
        private System.Windows.Forms.Label ROMHeader_lb;
        private System.Windows.Forms.Label mirroring_Lb;
        private System.Windows.Forms.Label sram_Lb;
        private System.Windows.Forms.Label vram_Lb;
        private System.Windows.Forms.Label trainer_Lb;
        private System.Windows.Forms.TextBox outputBox;
        private System.Windows.Forms.Label CHR_Lb;
        private System.Windows.Forms.Label Prg_Lb;
        private System.Windows.Forms.Label mapperLb;
        private System.Windows.Forms.TextBox gameTxt;
        private System.Windows.Forms.TextBox mirrorTxt;
        private System.Windows.Forms.TextBox SRAMtxt;
        private System.Windows.Forms.TextBox Trainertxt;
        private System.Windows.Forms.TextBox VRAMtxt;
        private System.Windows.Forms.TextBox ROMHeadertxt;
        private System.Windows.Forms.TextBox PRGtxt;
        private System.Windows.Forms.TextBox CHRtxt;
        private System.Windows.Forms.TextBox Mappertxt;
        private System.Windows.Forms.SaveFileDialog CreateFileDialog;
        private System.Windows.Forms.Button hexBtn;
    }
}



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
            this.label1 = new System.Windows.Forms.Label();
            this.TextFile = new System.Windows.Forms.Label();
            this.ROMSel = new System.Windows.Forms.Button();
            this.TextSel = new System.Windows.Forms.Button();
            this.ROMDirectory = new System.Windows.Forms.Label();
            this.TextDirectory = new System.Windows.Forms.Label();
            this.OpenROMDialog = new System.Windows.Forms.OpenFileDialog();
            this.OpenTextDialog = new System.Windows.Forms.OpenFileDialog();
            this.ROMType_Lb = new System.Windows.Forms.Label();
            this.gameName_Lb = new System.Windows.Forms.Label();
            this.romInfo_Lb = new System.Windows.Forms.Label();
            this.translate_Btn = new System.Windows.Forms.Button();
            this.mirroring_Lb = new System.Windows.Forms.Label();
            this.sram_Lb = new System.Windows.Forms.Label();
            this.vram_Lb = new System.Windows.Forms.Label();
            this.trainer_Lb = new System.Windows.Forms.Label();
            this.testBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(432, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ROM File: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextFile
            // 
            this.TextFile.AutoSize = true;
            this.TextFile.Location = new System.Drawing.Point(432, 52);
            this.TextFile.Name = "TextFile";
            this.TextFile.Size = new System.Drawing.Size(53, 13);
            this.TextFile.TabIndex = 1;
            this.TextFile.Text = "Text File: ";
            this.TextFile.Click += new System.EventHandler(this.TextFile_Click);
            // 
            // ROMSel
            // 
            this.ROMSel.Location = new System.Drawing.Point(351, 14);
            this.ROMSel.Name = "ROMSel";
            this.ROMSel.Size = new System.Drawing.Size(75, 23);
            this.ROMSel.TabIndex = 2;
            this.ROMSel.Text = "Select ROM";
            this.ROMSel.UseVisualStyleBackColor = true;
            this.ROMSel.Click += new System.EventHandler(this.ROMSel_Click);
            // 
            // TextSel
            // 
            this.TextSel.Location = new System.Drawing.Point(351, 47);
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
            this.ROMDirectory.Location = new System.Drawing.Point(495, 19);
            this.ROMDirectory.Name = "ROMDirectory";
            this.ROMDirectory.Size = new System.Drawing.Size(49, 13);
            this.ROMDirectory.TabIndex = 4;
            this.ROMDirectory.Text = "Directory";
            this.ROMDirectory.Click += new System.EventHandler(this.label2_Click);
            // 
            // TextDirectory
            // 
            this.TextDirectory.AutoSize = true;
            this.TextDirectory.Location = new System.Drawing.Point(495, 52);
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
            // ROMType_Lb
            // 
            this.ROMType_Lb.AutoSize = true;
            this.ROMType_Lb.Location = new System.Drawing.Point(348, 249);
            this.ROMType_Lb.Name = "ROMType_Lb";
            this.ROMType_Lb.Size = new System.Drawing.Size(109, 13);
            this.ROMType_Lb.TabIndex = 7;
            this.ROMType_Lb.Text = "RomTypePlaceholder";
            this.ROMType_Lb.Click += new System.EventHandler(this.ROMType_Lb_Click);
            // 
            // gameName_Lb
            // 
            this.gameName_Lb.AutoSize = true;
            this.gameName_Lb.Location = new System.Drawing.Point(348, 184);
            this.gameName_Lb.Name = "gameName_Lb";
            this.gameName_Lb.Size = new System.Drawing.Size(91, 13);
            this.gameName_Lb.TabIndex = 8;
            this.gameName_Lb.Text = "NamePlaceholder";
            this.gameName_Lb.Click += new System.EventHandler(this.gameName_Lb_Click);
            // 
            // romInfo_Lb
            // 
            this.romInfo_Lb.AutoSize = true;
            this.romInfo_Lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.romInfo_Lb.Location = new System.Drawing.Point(347, 149);
            this.romInfo_Lb.Name = "romInfo_Lb";
            this.romInfo_Lb.Size = new System.Drawing.Size(165, 20);
            this.romInfo_Lb.TabIndex = 9;
            this.romInfo_Lb.Text = "ROM INFORMATION:";
            this.romInfo_Lb.Click += new System.EventHandler(this.romInfo_Lb_Click);
            // 
            // translate_Btn
            // 
            this.translate_Btn.Location = new System.Drawing.Point(385, 89);
            this.translate_Btn.Name = "translate_Btn";
            this.translate_Btn.Size = new System.Drawing.Size(159, 23);
            this.translate_Btn.TabIndex = 10;
            this.translate_Btn.Text = "TRANSLATE";
            this.translate_Btn.UseVisualStyleBackColor = true;
            this.translate_Btn.Click += new System.EventHandler(this.translate_Btn_Click);
            // 
            // mirroring_Lb
            // 
            this.mirroring_Lb.AutoSize = true;
            this.mirroring_Lb.Location = new System.Drawing.Point(348, 197);
            this.mirroring_Lb.Name = "mirroring_Lb";
            this.mirroring_Lb.Size = new System.Drawing.Size(103, 13);
            this.mirroring_Lb.TabIndex = 11;
            this.mirroring_Lb.Text = "MirroringPlaceholder";
            this.mirroring_Lb.Click += new System.EventHandler(this.mirroring_Lb_Click);
            // 
            // sram_Lb
            // 
            this.sram_Lb.AutoSize = true;
            this.sram_Lb.Location = new System.Drawing.Point(348, 210);
            this.sram_Lb.Name = "sram_Lb";
            this.sram_Lb.Size = new System.Drawing.Size(94, 13);
            this.sram_Lb.TabIndex = 13;
            this.sram_Lb.Text = "SRAMPlaceholder";
            this.sram_Lb.Click += new System.EventHandler(this.sram_Lb_Click);
            // 
            // vram_Lb
            // 
            this.vram_Lb.AutoSize = true;
            this.vram_Lb.Location = new System.Drawing.Point(348, 236);
            this.vram_Lb.Name = "vram_Lb";
            this.vram_Lb.Size = new System.Drawing.Size(94, 13);
            this.vram_Lb.TabIndex = 15;
            this.vram_Lb.Text = "VRAMPlaceholder";
            this.vram_Lb.Click += new System.EventHandler(this.vram_Lb_Click);
            // 
            // trainer_Lb
            // 
            this.trainer_Lb.AutoSize = true;
            this.trainer_Lb.Location = new System.Drawing.Point(348, 223);
            this.trainer_Lb.Name = "trainer_Lb";
            this.trainer_Lb.Size = new System.Drawing.Size(96, 13);
            this.trainer_Lb.TabIndex = 16;
            this.trainer_Lb.Text = "TrainerPlaceholder";
            this.trainer_Lb.Click += new System.EventHandler(this.trainer_Lb_Click);
            // 
            // testBox
            // 
            this.testBox.Location = new System.Drawing.Point(21, 12);
            this.testBox.Multiline = true;
            this.testBox.Name = "testBox";
            this.testBox.ReadOnly = true;
            this.testBox.Size = new System.Drawing.Size(286, 250);
            this.testBox.TabIndex = 17;
            this.testBox.TextChanged += new System.EventHandler(this.testBox_TextChanged_2);
            // 
            // NESForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.testBox);
            this.Controls.Add(this.trainer_Lb);
            this.Controls.Add(this.vram_Lb);
            this.Controls.Add(this.sram_Lb);
            this.Controls.Add(this.mirroring_Lb);
            this.Controls.Add(this.translate_Btn);
            this.Controls.Add(this.romInfo_Lb);
            this.Controls.Add(this.gameName_Lb);
            this.Controls.Add(this.ROMType_Lb);
            this.Controls.Add(this.TextDirectory);
            this.Controls.Add(this.ROMDirectory);
            this.Controls.Add(this.TextSel);
            this.Controls.Add(this.ROMSel);
            this.Controls.Add(this.TextFile);
            this.Controls.Add(this.label1);
            this.Name = "NESForm";
            this.Text = "NES Translator GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TextFile;
        private System.Windows.Forms.Button ROMSel;
        private System.Windows.Forms.Button TextSel;
        private System.Windows.Forms.Label ROMDirectory;
        private System.Windows.Forms.Label TextDirectory;
        private System.Windows.Forms.OpenFileDialog OpenROMDialog;
        private System.Windows.Forms.OpenFileDialog OpenTextDialog;
        private System.Windows.Forms.Label ROMType_Lb;
        private System.Windows.Forms.Label gameName_Lb;
        private System.Windows.Forms.Label romInfo_Lb;
        private System.Windows.Forms.Button translate_Btn;
        private System.Windows.Forms.Label mirroring_Lb;
        private System.Windows.Forms.Label sram_Lb;
        private System.Windows.Forms.Label vram_Lb;
        private System.Windows.Forms.Label trainer_Lb;
        public System.Windows.Forms.TextBox testBox;
    }
}


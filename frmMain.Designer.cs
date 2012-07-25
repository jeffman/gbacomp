namespace gbacomp
{
    partial class frmMain
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
            this.grpDecomp = new System.Windows.Forms.GroupBox();
            this.btnDecomp = new System.Windows.Forms.Button();
            this.txtDecompAddr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDecompSource = new System.Windows.Forms.Button();
            this.txtDecompSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.opnDecompSource = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblSpace = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAbout = new System.Windows.Forms.ToolStripStatusLabel();
            this.savDecomp = new System.Windows.Forms.SaveFileDialog();
            this.grpComp = new System.Windows.Forms.GroupBox();
            this.txtCompDestAddr = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCompDest = new System.Windows.Forms.Button();
            this.txtCompDest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCompress = new System.Windows.Forms.Button();
            this.btnCompSource = new System.Windows.Forms.Button();
            this.txtCompSource = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opnCompSource = new System.Windows.Forms.OpenFileDialog();
            this.savComp = new System.Windows.Forms.SaveFileDialog();
            this.rdoNewFile = new System.Windows.Forms.RadioButton();
            this.rdoExistingFile = new System.Windows.Forms.RadioButton();
            this.opnCompDest = new System.Windows.Forms.OpenFileDialog();
            this.grpDecomp.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.grpComp.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpDecomp
            // 
            this.grpDecomp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpDecomp.Controls.Add(this.btnDecomp);
            this.grpDecomp.Controls.Add(this.txtDecompAddr);
            this.grpDecomp.Controls.Add(this.label2);
            this.grpDecomp.Controls.Add(this.btnDecompSource);
            this.grpDecomp.Controls.Add(this.txtDecompSource);
            this.grpDecomp.Controls.Add(this.label1);
            this.grpDecomp.Location = new System.Drawing.Point(12, 12);
            this.grpDecomp.Name = "grpDecomp";
            this.grpDecomp.Size = new System.Drawing.Size(559, 78);
            this.grpDecomp.TabIndex = 0;
            this.grpDecomp.TabStop = false;
            this.grpDecomp.Text = "Decompress";
            // 
            // btnDecomp
            // 
            this.btnDecomp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecomp.Location = new System.Drawing.Point(454, 46);
            this.btnDecomp.Name = "btnDecomp";
            this.btnDecomp.Size = new System.Drawing.Size(99, 23);
            this.btnDecomp.TabIndex = 5;
            this.btnDecomp.Text = "Decompress...";
            this.btnDecomp.UseVisualStyleBackColor = true;
            this.btnDecomp.Click += new System.EventHandler(this.btnDecomp_Click);
            // 
            // txtDecompAddr
            // 
            this.txtDecompAddr.Location = new System.Drawing.Point(100, 45);
            this.txtDecompAddr.MaxLength = 7;
            this.txtDecompAddr.Name = "txtDecompAddr";
            this.txtDecompAddr.Size = new System.Drawing.Size(88, 20);
            this.txtDecompAddr.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Source address: 0x";
            // 
            // btnDecompSource
            // 
            this.btnDecompSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecompSource.Location = new System.Drawing.Point(527, 17);
            this.btnDecompSource.Name = "btnDecompSource";
            this.btnDecompSource.Size = new System.Drawing.Size(26, 23);
            this.btnDecompSource.TabIndex = 2;
            this.btnDecompSource.Text = "...";
            this.btnDecompSource.UseVisualStyleBackColor = true;
            this.btnDecompSource.Click += new System.EventHandler(this.btnDecompSource_Click);
            // 
            // txtDecompSource
            // 
            this.txtDecompSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDecompSource.Location = new System.Drawing.Point(75, 19);
            this.txtDecompSource.Name = "txtDecompSource";
            this.txtDecompSource.Size = new System.Drawing.Size(446, 20);
            this.txtDecompSource.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Source:";
            // 
            // opnDecompSource
            // 
            this.opnDecompSource.Filter = "All files|*.*|GBA files|*.gba|Data files|*.bin;*.dat";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblSpace,
            this.lblAbout});
            this.statusStrip.Location = new System.Drawing.Point(0, 220);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(583, 22);
            this.statusStrip.SizingGrip = false;
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // lblSpace
            // 
            this.lblSpace.Name = "lblSpace";
            this.lblSpace.Size = new System.Drawing.Size(519, 17);
            this.lblSpace.Spring = true;
            // 
            // lblAbout
            // 
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(49, 17);
            this.lblAbout.Text = "About...";
            this.lblAbout.Click += new System.EventHandler(this.lblAbout_Click);
            // 
            // grpComp
            // 
            this.grpComp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.grpComp.Controls.Add(this.rdoExistingFile);
            this.grpComp.Controls.Add(this.rdoNewFile);
            this.grpComp.Controls.Add(this.txtCompDestAddr);
            this.grpComp.Controls.Add(this.label6);
            this.grpComp.Controls.Add(this.btnCompDest);
            this.grpComp.Controls.Add(this.txtCompDest);
            this.grpComp.Controls.Add(this.label5);
            this.grpComp.Controls.Add(this.btnCompress);
            this.grpComp.Controls.Add(this.btnCompSource);
            this.grpComp.Controls.Add(this.txtCompSource);
            this.grpComp.Controls.Add(this.label4);
            this.grpComp.Location = new System.Drawing.Point(12, 96);
            this.grpComp.Name = "grpComp";
            this.grpComp.Size = new System.Drawing.Size(559, 103);
            this.grpComp.TabIndex = 2;
            this.grpComp.TabStop = false;
            this.grpComp.Text = "Compress";
            // 
            // txtCompDestAddr
            // 
            this.txtCompDestAddr.Location = new System.Drawing.Point(119, 71);
            this.txtCompDestAddr.MaxLength = 7;
            this.txtCompDestAddr.Name = "txtCompDestAddr";
            this.txtCompDestAddr.Size = new System.Drawing.Size(88, 20);
            this.txtCompDestAddr.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 74);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Destination address: 0x";
            // 
            // btnCompDest
            // 
            this.btnCompDest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompDest.Location = new System.Drawing.Point(527, 43);
            this.btnCompDest.Name = "btnCompDest";
            this.btnCompDest.Size = new System.Drawing.Size(26, 23);
            this.btnCompDest.TabIndex = 8;
            this.btnCompDest.Text = "...";
            this.btnCompDest.UseVisualStyleBackColor = true;
            this.btnCompDest.Click += new System.EventHandler(this.btnCompDest_Click);
            // 
            // txtCompDest
            // 
            this.txtCompDest.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompDest.Location = new System.Drawing.Point(75, 45);
            this.txtCompDest.Name = "txtCompDest";
            this.txtCompDest.Size = new System.Drawing.Size(446, 20);
            this.txtCompDest.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Destination:";
            // 
            // btnCompress
            // 
            this.btnCompress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompress.Location = new System.Drawing.Point(454, 71);
            this.btnCompress.Name = "btnCompress";
            this.btnCompress.Size = new System.Drawing.Size(99, 23);
            this.btnCompress.TabIndex = 5;
            this.btnCompress.Text = "Compress...";
            this.btnCompress.UseVisualStyleBackColor = true;
            this.btnCompress.Click += new System.EventHandler(this.btnCompress_Click);
            // 
            // btnCompSource
            // 
            this.btnCompSource.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCompSource.Location = new System.Drawing.Point(527, 17);
            this.btnCompSource.Name = "btnCompSource";
            this.btnCompSource.Size = new System.Drawing.Size(26, 23);
            this.btnCompSource.TabIndex = 2;
            this.btnCompSource.Text = "...";
            this.btnCompSource.UseVisualStyleBackColor = true;
            this.btnCompSource.Click += new System.EventHandler(this.btnCompSource_Click);
            // 
            // txtCompSource
            // 
            this.txtCompSource.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCompSource.Location = new System.Drawing.Point(75, 19);
            this.txtCompSource.Name = "txtCompSource";
            this.txtCompSource.Size = new System.Drawing.Size(446, 20);
            this.txtCompSource.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Source:";
            // 
            // opnCompSource
            // 
            this.opnCompSource.Filter = "All files|*.*|GBA files|*.gba|Data files|*.bin;*.dat";
            // 
            // rdoNewFile
            // 
            this.rdoNewFile.AutoSize = true;
            this.rdoNewFile.Checked = true;
            this.rdoNewFile.Location = new System.Drawing.Point(213, 72);
            this.rdoNewFile.Name = "rdoNewFile";
            this.rdoNewFile.Size = new System.Drawing.Size(63, 17);
            this.rdoNewFile.TabIndex = 11;
            this.rdoNewFile.TabStop = true;
            this.rdoNewFile.Text = "New file";
            this.rdoNewFile.UseVisualStyleBackColor = true;
            this.rdoNewFile.CheckedChanged += new System.EventHandler(this.rdoNewFile_CheckedChanged);
            // 
            // rdoExistingFile
            // 
            this.rdoExistingFile.AutoSize = true;
            this.rdoExistingFile.Location = new System.Drawing.Point(282, 72);
            this.rdoExistingFile.Name = "rdoExistingFile";
            this.rdoExistingFile.Size = new System.Drawing.Size(77, 17);
            this.rdoExistingFile.TabIndex = 12;
            this.rdoExistingFile.Text = "Existing file";
            this.rdoExistingFile.UseVisualStyleBackColor = true;
            // 
            // opnCompDest
            // 
            this.opnCompDest.Filter = "All files|*.*|GBA files|*.gba|Data files|*.bin;*.dat";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 242);
            this.Controls.Add(this.grpComp);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpDecomp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "GBA compressor";
            this.grpDecomp.ResumeLayout(false);
            this.grpDecomp.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.grpComp.ResumeLayout(false);
            this.grpComp.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDecomp;
        private System.Windows.Forms.Button btnDecompSource;
        private System.Windows.Forms.TextBox txtDecompSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog opnDecompSource;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.Button btnDecomp;
        private System.Windows.Forms.TextBox txtDecompAddr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.SaveFileDialog savDecomp;
        private System.Windows.Forms.GroupBox grpComp;
        private System.Windows.Forms.TextBox txtCompDestAddr;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCompDest;
        private System.Windows.Forms.TextBox txtCompDest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCompress;
        private System.Windows.Forms.Button btnCompSource;
        private System.Windows.Forms.TextBox txtCompSource;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripStatusLabel lblSpace;
        private System.Windows.Forms.ToolStripStatusLabel lblAbout;
        private System.Windows.Forms.OpenFileDialog opnCompSource;
        private System.Windows.Forms.SaveFileDialog savComp;
        private System.Windows.Forms.RadioButton rdoExistingFile;
        private System.Windows.Forms.RadioButton rdoNewFile;
        private System.Windows.Forms.OpenFileDialog opnCompDest;
    }
}


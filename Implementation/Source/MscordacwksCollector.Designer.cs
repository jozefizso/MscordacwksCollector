namespace MscordacwksCollector
{
    partial class MscordacwksCollector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MscordacwksCollector));
            this.btnFindDebuggingDlls = new System.Windows.Forms.Button();
            this.txtMscorwksDestination = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lblFullPath = new System.Windows.Forms.Label();
            this.lblOutputDirectory = new System.Windows.Forms.Label();
            this.lblDirectoryHint = new System.Windows.Forms.Label();
            this.chkNetFramework = new System.Windows.Forms.CheckBox();
            this.chk64BitNetFramework = new System.Windows.Forms.CheckBox();
            this.chkSxSDirectories = new System.Windows.Forms.CheckBox();
            this.lstResults = new System.Windows.Forms.ListView();
            this.colHdrType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrBitness = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colHdrPath = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtStructureMscordacWks = new System.Windows.Forms.TextBox();
            this.txtStructureSOS = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFlatStructure = new System.Windows.Forms.Button();
            this.btnDefaultStructure = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFindDebuggingDlls
            // 
            this.btnFindDebuggingDlls.Location = new System.Drawing.Point(12, 12);
            this.btnFindDebuggingDlls.Name = "btnFindDebuggingDlls";
            this.btnFindDebuggingDlls.Size = new System.Drawing.Size(134, 26);
            this.btnFindDebuggingDlls.TabIndex = 0;
            this.btnFindDebuggingDlls.Text = "&Find Debugging DLLs";
            this.btnFindDebuggingDlls.UseVisualStyleBackColor = true;
            this.btnFindDebuggingDlls.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMscorwksDestination
            // 
            this.txtMscorwksDestination.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMscorwksDestination.Location = new System.Drawing.Point(85, 419);
            this.txtMscorwksDestination.Name = "txtMscorwksDestination";
            this.txtMscorwksDestination.Size = new System.Drawing.Size(542, 20);
            this.txtMscorwksDestination.TabIndex = 15;
            this.txtMscorwksDestination.Text = ".\\";
            this.txtMscorwksDestination.TextChanged += new System.EventHandler(this.OnOutputFolderChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Location = new System.Drawing.Point(633, 416);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(109, 23);
            this.btnCopy.TabIndex = 16;
            this.btnCopy.Text = "&Copy files there";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblFullPath
            // 
            this.lblFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFullPath.AutoSize = true;
            this.lblFullPath.Location = new System.Drawing.Point(85, 442);
            this.lblFullPath.Name = "lblFullPath";
            this.lblFullPath.Size = new System.Drawing.Size(15, 13);
            this.lblFullPath.TabIndex = 17;
            this.lblFullPath.Text = ".\\";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDirectory.Location = new System.Drawing.Point(85, 391);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(98, 13);
            this.lblOutputDirectory.TabIndex = 13;
            this.lblOutputDirectory.Text = "&Output directory";
            // 
            // lblDirectoryHint
            // 
            this.lblDirectoryHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDirectoryHint.AutoSize = true;
            this.lblDirectoryHint.BackColor = System.Drawing.SystemColors.Control;
            this.lblDirectoryHint.Location = new System.Drawing.Point(85, 404);
            this.lblDirectoryHint.Name = "lblDirectoryHint";
            this.lblDirectoryHint.Size = new System.Drawing.Size(176, 13);
            this.lblDirectoryHint.TabIndex = 14;
            this.lblDirectoryHint.Text = "You can use environment variables.";
            // 
            // chkNetFramework
            // 
            this.chkNetFramework.AutoSize = true;
            this.chkNetFramework.Checked = true;
            this.chkNetFramework.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNetFramework.Location = new System.Drawing.Point(152, 18);
            this.chkNetFramework.Name = "chkNetFramework";
            this.chkNetFramework.Size = new System.Drawing.Size(146, 17);
            this.chkNetFramework.TabIndex = 1;
            this.chkNetFramework.Text = ".NET framework &directory";
            this.chkNetFramework.UseVisualStyleBackColor = true;
            // 
            // chk64BitNetFramework
            // 
            this.chk64BitNetFramework.AutoSize = true;
            this.chk64BitNetFramework.Checked = true;
            this.chk64BitNetFramework.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk64BitNetFramework.Location = new System.Drawing.Point(304, 18);
            this.chk64BitNetFramework.Name = "chk64BitNetFramework";
            this.chk64BitNetFramework.Size = new System.Drawing.Size(175, 17);
            this.chk64BitNetFramework.TabIndex = 2;
            this.chk64BitNetFramework.Text = "&64 bit .NET framework directory";
            this.chk64BitNetFramework.UseVisualStyleBackColor = true;
            // 
            // chkSxSDirectories
            // 
            this.chkSxSDirectories.AutoSize = true;
            this.chkSxSDirectories.Checked = true;
            this.chkSxSDirectories.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSxSDirectories.Location = new System.Drawing.Point(485, 18);
            this.chkSxSDirectories.Name = "chkSxSDirectories";
            this.chkSxSDirectories.Size = new System.Drawing.Size(96, 17);
            this.chkSxSDirectories.TabIndex = 3;
            this.chkSxSDirectories.Text = "&SxS directories";
            this.chkSxSDirectories.UseVisualStyleBackColor = true;
            // 
            // lstResults
            // 
            this.lstResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHdrType,
            this.colHdrBitness,
            this.colHdrVersion,
            this.colHdrPath});
            this.lstResults.Location = new System.Drawing.Point(15, 44);
            this.lstResults.MultiSelect = false;
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(757, 285);
            this.lstResults.TabIndex = 4;
            this.lstResults.UseCompatibleStateImageBehavior = false;
            this.lstResults.View = System.Windows.Forms.View.Details;
            // 
            // colHdrType
            // 
            this.colHdrType.Text = "Type";
            this.colHdrType.Width = 88;
            // 
            // colHdrBitness
            // 
            this.colHdrBitness.Text = "Bitness";
            // 
            // colHdrVersion
            // 
            this.colHdrVersion.Text = "Version";
            this.colHdrVersion.Width = 141;
            // 
            // colHdrPath
            // 
            this.colHdrPath.Text = "Directory";
            this.colHdrPath.Width = 463;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 394);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Output &structure";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "mscordacwks.dll";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "SOS.dll";
            // 
            // txtStructureMscordacWks
            // 
            this.txtStructureMscordacWks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStructureMscordacWks.Location = new System.Drawing.Point(190, 346);
            this.txtStructureMscordacWks.Name = "txtStructureMscordacWks";
            this.txtStructureMscordacWks.Size = new System.Drawing.Size(258, 20);
            this.txtStructureMscordacWks.TabIndex = 7;
            this.txtStructureMscordacWks.Text = "$A\\$V\\$T_$A_$A_$V.dll";
            // 
            // txtStructureSOS
            // 
            this.txtStructureSOS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtStructureSOS.Location = new System.Drawing.Point(190, 369);
            this.txtStructureSOS.Name = "txtStructureSOS";
            this.txtStructureSOS.Size = new System.Drawing.Size(258, 20);
            this.txtStructureSOS.TabIndex = 9;
            this.txtStructureSOS.Text = "$A\\$V\\$T.dll";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(454, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "$T: Type (mscordacwks or SOS)\r\n$A: Architecture (x86 or AMD64)\r\n$N: Architecture " +
    "(32 or 64)\r\n$V: Version";
            // 
            // btnFlatStructure
            // 
            this.btnFlatStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlatStructure.Location = new System.Drawing.Point(633, 367);
            this.btnFlatStructure.Name = "btnFlatStructure";
            this.btnFlatStructure.Size = new System.Drawing.Size(75, 23);
            this.btnFlatStructure.TabIndex = 12;
            this.btnFlatStructure.Text = "&Flat";
            this.btnFlatStructure.UseVisualStyleBackColor = true;
            this.btnFlatStructure.Click += new System.EventHandler(this.OnFlatStructureClick);
            // 
            // btnDefaultStructure
            // 
            this.btnDefaultStructure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDefaultStructure.Location = new System.Drawing.Point(633, 341);
            this.btnDefaultStructure.Name = "btnDefaultStructure";
            this.btnDefaultStructure.Size = new System.Drawing.Size(75, 23);
            this.btnDefaultStructure.TabIndex = 11;
            this.btnDefaultStructure.Text = "&Default";
            this.btnDefaultStructure.UseVisualStyleBackColor = true;
            this.btnDefaultStructure.Click += new System.EventHandler(this.OnDefaultStructureClick);
            // 
            // MscordacwksCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 462);
            this.Controls.Add(this.btnDefaultStructure);
            this.Controls.Add(this.btnFlatStructure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStructureSOS);
            this.Controls.Add(this.txtStructureMscordacWks);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lstResults);
            this.Controls.Add(this.chkSxSDirectories);
            this.Controls.Add(this.chk64BitNetFramework);
            this.Controls.Add(this.chkNetFramework);
            this.Controls.Add(this.lblDirectoryHint);
            this.Controls.Add(this.lblOutputDirectory);
            this.Controls.Add(this.lblFullPath);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.txtMscorwksDestination);
            this.Controls.Add(this.btnFindDebuggingDlls);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(675, 400);
            this.Name = "MscordacwksCollector";
            this.Text = "WelliSolutions MsCorDacWks / SOS Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFindDebuggingDlls;
        private System.Windows.Forms.TextBox txtMscorwksDestination;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lblFullPath;
        private System.Windows.Forms.Label lblOutputDirectory;
        private System.Windows.Forms.Label lblDirectoryHint;
        private System.Windows.Forms.CheckBox chkNetFramework;
        private System.Windows.Forms.CheckBox chk64BitNetFramework;
        private System.Windows.Forms.CheckBox chkSxSDirectories;
        private System.Windows.Forms.ListView lstResults;
        private System.Windows.Forms.ColumnHeader colHdrType;
        private System.Windows.Forms.ColumnHeader colHdrBitness;
        private System.Windows.Forms.ColumnHeader colHdrVersion;
        private System.Windows.Forms.ColumnHeader colHdrPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtStructureMscordacWks;
        private System.Windows.Forms.TextBox txtStructureSOS;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFlatStructure;
        private System.Windows.Forms.Button btnDefaultStructure;
    }
}


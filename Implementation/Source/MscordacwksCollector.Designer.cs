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
            this.button1 = new System.Windows.Forms.Button();
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 26);
            this.button1.TabIndex = 0;
            this.button1.Text = "&Find Debugging DLLs";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtMscorwksDestination
            // 
            this.txtMscorwksDestination.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtMscorwksDestination.Location = new System.Drawing.Point(85, 430);
            this.txtMscorwksDestination.Name = "txtMscorwksDestination";
            this.txtMscorwksDestination.Size = new System.Drawing.Size(371, 20);
            this.txtMscorwksDestination.TabIndex = 7;
            this.txtMscorwksDestination.Text = ".\\";
            this.txtMscorwksDestination.TextChanged += new System.EventHandler(this.OnOutputFolderChanged);
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCopy.Location = new System.Drawing.Point(462, 428);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(109, 23);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "&Copy files there";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lblFullPath
            // 
            this.lblFullPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFullPath.AutoSize = true;
            this.lblFullPath.Location = new System.Drawing.Point(85, 453);
            this.lblFullPath.Name = "lblFullPath";
            this.lblFullPath.Size = new System.Drawing.Size(15, 13);
            this.lblFullPath.TabIndex = 8;
            this.lblFullPath.Text = ".\\";
            // 
            // lblOutputDirectory
            // 
            this.lblOutputDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblOutputDirectory.AutoSize = true;
            this.lblOutputDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputDirectory.Location = new System.Drawing.Point(85, 402);
            this.lblOutputDirectory.Name = "lblOutputDirectory";
            this.lblOutputDirectory.Size = new System.Drawing.Size(98, 13);
            this.lblOutputDirectory.TabIndex = 5;
            this.lblOutputDirectory.Text = "&Output directory";
            // 
            // lblDirectoryHint
            // 
            this.lblDirectoryHint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDirectoryHint.AutoSize = true;
            this.lblDirectoryHint.BackColor = System.Drawing.SystemColors.Control;
            this.lblDirectoryHint.Location = new System.Drawing.Point(85, 415);
            this.lblDirectoryHint.Name = "lblDirectoryHint";
            this.lblDirectoryHint.Size = new System.Drawing.Size(176, 13);
            this.lblDirectoryHint.TabIndex = 6;
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
            this.lstResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHdrType,
            this.colHdrBitness,
            this.colHdrVersion,
            this.colHdrPath});
            this.lstResults.Location = new System.Drawing.Point(15, 44);
            this.lstResults.MultiSelect = false;
            this.lstResults.Name = "lstResults";
            this.lstResults.Size = new System.Drawing.Size(765, 355);
            this.lstResults.TabIndex = 10;
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
            this.colHdrVersion.Width = 92;
            // 
            // colHdrPath
            // 
            this.colHdrPath.Text = "Directory";
            this.colHdrPath.Width = 512;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 405);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // MscordacwksCollector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 473);
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
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MscordacwksCollector";
            this.Text = "WelliSolutions MsCorDacWks / SOS Finder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
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
    }
}


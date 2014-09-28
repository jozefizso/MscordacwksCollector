using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MscordacwksCollector
{
    public partial class MscordacwksCollector : Form
    {
        public MscordacwksCollector()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateOutputFolder();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            IList<DirectoryInfo> dirs = new List<DirectoryInfo>();
            if (chkNetFramework.Checked)
            {
                dirs.Add(MscordacwksPaths.NetFramework64);
            }
            if (chk64BitNetFramework.Checked)
            {
                dirs.Add(MscordacwksPaths.NetFramework);
            }
            if (chkSxSDirectories.Checked)
            {
                dirs.Add(MscordacwksPaths.WinSxs);
            }

            Cursor = Cursors.WaitCursor;
            lstResults.Enabled = false;
            var finder = new MscordacWksFinder(OnItemFound);
            finder.Find(dirs);
            lstResults.Enabled = true;
            Cursor = Cursors.Default;
        }

        private delegate void MyDelegate(MscordacInfo mscordacinfo);

        void OnItemFound(MscordacInfo mscordacinfo)
        {
            if (InvokeRequired)
            {
                Invoke(new MyDelegate(OnItemFound), mscordacinfo);
                return;
            }

            ListViewItem item = lstResults.Items.Add(((IMscordacInfo) mscordacinfo).Type);
            item.SubItems.Add(((IMscordacInfo) mscordacinfo).Architecture);
            item.SubItems.Add(((IMscordacInfo) mscordacinfo).Version.ToString());
            item.SubItems.Add(((IMscordacInfo) mscordacinfo).Source.DirectoryName);
            item.Tag = mscordacinfo;
            lstResults.Refresh();
        }

        StructureResolver structureResolver = new StructureResolver();

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var destinationDir = DirectoryResolver.Expand(txtMscorwksDestination.Text);
            
            foreach (ListViewItem item in lstResults.Items)
            {
                var mscordacInfo = (MscordacInfo) item.Tag;
                string destinationFileName = mscordacInfo.DebuggerName;
                
                switch (((IMscordacInfo) mscordacInfo).Type.ToLowerInvariant())
                {
                    case "sos":
                        destinationFileName = Path.Combine(destinationDir.FullName,
                            structureResolver.Expand(txtStructureSOS.Text, mscordacInfo));
                        break;
                    case "mscordacwks":
                        destinationFileName = Path.Combine(destinationDir.FullName,
                            structureResolver.Expand(txtStructureMscordacWks.Text, mscordacInfo));
                        break;
                }

                if (!File.Exists(destinationFileName))
                {
                    Directory.CreateDirectory(new FileInfo(destinationFileName).DirectoryName);
                    File.Copy(((IMscordacInfo) mscordacInfo).Source.FullName, destinationFileName);
                }
            }
        }

        private void OnOutputFolderChanged(object sender, EventArgs e)
        {
            UpdateOutputFolder();
        }

        private void UpdateOutputFolder()
        {
            lblFullPath.Text = DirectoryResolver.Expand(txtMscorwksDestination.Text).FullName;
        }

        private void OnDefaultStructureClick(object sender, EventArgs e)
        {
            txtStructureMscordacWks.Text = @"$A\$V\$T_$A_$A_$V.dll";
            txtStructureSOS.Text = @"$A\$V\$T.dll";
        }

        private void OnFlatStructureClick(object sender, EventArgs e)
        {
            txtStructureMscordacWks.Text = @"$T_$A_$A_$V.dll";
            txtStructureSOS.Text = @"$T_$A_$A_$V.dll";
        }
    }
}

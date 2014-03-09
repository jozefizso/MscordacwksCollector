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
            lstResults.Items.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstResults.Items.Clear();

            IList<DirectoryInfo> dirs = new List<DirectoryInfo>();
            dirs.Add(MscordacwksPaths.NetFramework64);
            dirs.Add(MscordacwksPaths.NetFramework);
            dirs.Add(MscordacwksPaths.WinSxs);

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

            lstResults.Items.Add(mscordacinfo);
            lstResults.Refresh();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            var destinationDir = new DirectoryInfo(txtMscorwksDestination.Text);
            
            foreach (MscordacInfo item in lstResults.Items)
            {
                if (destinationDir.GetFiles(item.DebuggerName).Length == 0)
                {
                    File.Copy(item.Source.FullName, Path.Combine(destinationDir.FullName, item.DebuggerName));
                }
            }
        }
    }
}

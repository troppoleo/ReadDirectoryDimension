using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadDirectoryDimension
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            List<clsDir> myDirList = new List<ReadDirectoryDimension.clsDir>();
            clsDir myD = null;

            var myRoot = txtPath.Text.Trim();

            DirectoryInfo di = new DirectoryInfo(myRoot);

            foreach (var i in di.GetDirectories())
            {
                myD = new ReadDirectoryDimension.clsDir();
                myD.DirName = i.Name;

                foreach (var f in i.GetFiles())
                {
                    myD.byteSum += f.Length;
                }
                myDirList.Add(myD);
            }

            

            dgvRead.DataSource = myDirList;
        }
    }
}

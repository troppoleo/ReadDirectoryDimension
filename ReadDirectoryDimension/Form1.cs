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
                    myD.ByteSum += f.Length;
                }
                myDirList.Add(myD);
            }

            

            dgvRead.DataSource = myDirList;
        }

        private void btnFindMax_Click(object sender, EventArgs e)
        {
            //clsMaxFile myMaxFile = new ReadDirectoryDimension.clsMaxFile();

            //var myRoot = txtPath.Text.Trim();

            //DirectoryInfo di = new DirectoryInfo(myRoot);

            //foreach (var i in di.GetDirectories())
            //{
            //    clsFiles myf = new clsFiles();
            //    myf.DirName = i.Name;

            //    foreach (var f in i.GetFiles())
            //    {
            //        if (myMaxFile.FilesArr.Contains(f.Name))
            //        {
            //            myf.fileName = f.Name;
            //            myf.ByteSum = f.Length;

            //            myMaxFile.SetMaxFile(myf);
            //        }
            //    }                
            //}

            dataGridView1.DataSource = GetMaxList();
        }

        private List<clsFiles> GetMaxList()
        {
            clsMaxFile myMaxFile = new ReadDirectoryDimension.clsMaxFile();

            var myRoot = txtPath.Text.Trim();

            DirectoryInfo di = new DirectoryInfo(myRoot);

            foreach (var i in di.GetDirectories())
            {
                clsFiles myf = new clsFiles();
                myf.DirName = i.Name;

                foreach (var f in i.GetFiles())
                {
                    if (myMaxFile.FilesArr.Contains(f.Name))
                    {
                        myf.fileName = f.Name;
                        myf.ByteSum = f.Length;

                        myMaxFile.SetMaxFile(myf);
                    }
                }
            }

            return  myMaxFile.GetFileList;
        }

        private void btnCopyIt_Click(object sender, EventArgs e)
        {
            var myRoot = txtPath.Text.Trim();
            var myPath = txtMaxFiles.Text.Trim();

            var myListFile = GetMaxList();
            foreach (var f in myListFile)
            {
                if (f.ByteSum > 0)
                {
                    var myOrig = Path.Combine(myRoot, f.GetFullName());
                    var myDest = Path.Combine(myPath, f.fileName);
                    File.Copy(myOrig , myDest );
                }
            }

            MessageBox.Show("Done");
        }
    }
}

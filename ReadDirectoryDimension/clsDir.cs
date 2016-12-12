using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDirectoryDimension
{
    class clsMaxFile
    {
        public string DirName { get; set; }
        public string[] FilesArr =
        {
            "0.DBList.csv",
            "1.InstanceInfo.csv",
            "2.InstanceLinkedServers.csv",
            "3.InstanceLogins.csv",
            "4.InstancePort.csv",
            "5.InstanceDTSX.csv",
            "6.InstanceDTS.csv",
            "7.InstanceJobs.csv",
            "8.InstanceMaintenancePlans.csv",
            "9.Performance.csv"
        };

        private List<clsFiles> _listFile = new List<clsFiles>();

        public List<clsFiles> GetFileList
        {
            get
            { return _listFile; }
        }

        internal List<clsFiles> ListFile
        {
            get
            {
                return _listFile;
            }

            set
            {
                _listFile = value;
            }
        }

        /// <summary>
        /// inizializza la lista
        /// </summary>
        public clsMaxFile()
        {
            foreach (var f in FilesArr)
            {
                clsFiles myfi = new ReadDirectoryDimension.clsFiles();
                myfi.fileName = f;

                _listFile.Add(myfi);
            }
        }


        /// <summary>
        /// salva il file maggiore nella lista
        /// </summary>
        /// <param name="pFile"></param>
        public void SetMaxFile(clsFiles pFile)
        {
            clsFiles myFile = _listFile.Where(f => f.fileName == pFile.fileName).FirstOrDefault();
            if (myFile.ByteSum < pFile.ByteSum)
            {
                myFile.ByteSum = pFile.ByteSum;
                myFile.DirName = pFile.DirName;
            }
        }


        internal void Concatenate(clsFiles myf, List<string> myL, string myPath)
        {
            string path = Path.Combine(myPath, myf.fileName);

            //// This text is added only once to the file.
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine(string.Join(Environment.NewLine, myL));
                }
            }
            else
            {
                // rimuovo l'intestazione
                myL.RemoveAt(0);

                // This text is always added, making the file longer over time
                // if it is not deleted.
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine(string.Join(Environment.NewLine, myL));
                }
            }
        }
    }




    class clsFiles: clsDir
    {
        public string fileName { get; set; }
        public string FullName { get; internal set; }

        internal string GetFullName()
        {
            return System.IO.Path.Combine(DirName, fileName);
        }
    }


    class clsDir
    {
        public string DirName { get; set; }

        private long _byteSum =0;
        public long ByteSum
        {
            get { return _byteSum; }
            set { _byteSum = value; }
        }

    }
}

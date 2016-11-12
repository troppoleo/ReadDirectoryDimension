using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadDirectoryDimension
{
    class clsDir
    {
        public string DirName { get; set; }

        private long _byteSum =0;
        public long byteSum
        {
            get { return _byteSum; }
            set { _byteSum = value; }
        }

    }
}

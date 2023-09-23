using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class File
    {

        private string fileName;

        public File(string fileName)
        {
            this.fileName = fileName;
        }

        public string getfilename()
        {
            return fileName;
        }
    }
}

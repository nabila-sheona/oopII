using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class Buffer
    {
        private string content;
        public Buffer(string content)
        {
            this.content = content;
        }

        public string getcontent()
        {
            return content;
        }
    }
}

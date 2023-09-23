using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class texteditor
    {
        private Buffer buffer;
        private File file;
        public texteditor(File file)
        {
            this.file = file;
            this.buffer = new Buffer("");


        }
        public void open()
        {
            Console.WriteLine(" Opening file : " + file.getfilename());
            // Load file content into buffer
            buffer = new Buffer(" Content of " + file.getfilename());
        }

        public void edit(string newContent)
        {
            Console.WriteLine(" Editing content ... ");
            buffer = new Buffer(newContent);
        }





        public void save()
        {

            Console.WriteLine("Saving changes to file: " + file.getfilename());
        }

        public void close()
        {
            Console.WriteLine(" Closing file : " + file.getfilename());
            buffer = null;

        }

        public string getcontent()
        {
            return buffer.getcontent();

        }
    }
}

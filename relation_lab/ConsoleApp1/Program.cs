using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            File file = new File(" document . txt ");
            texteditor textEditor = new texteditor(file);

            textEditor.open();
            Console.WriteLine(" Initial Content : " + textEditor.getcontent());

            textEditor.edit(" Updated content .");
            Console.WriteLine(" Updated Content : " + textEditor.getcontent());

            textEditor.save();
            textEditor.close();
        }

    }
}

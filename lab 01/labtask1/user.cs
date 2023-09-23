using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    public class user
    {
        public void play(types title)
        {
            Console.WriteLine("Now playing");
        }
        public void pause()
        {
            Console.WriteLine("song paused");
        }
        public void resume() { Console.WriteLine("playing again!"); }
        public void stop() { Console.WriteLine("song stopped"); }
    }
}

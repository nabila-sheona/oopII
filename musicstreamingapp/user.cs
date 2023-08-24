using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicstreamingapp
{
    public class user
    {
        public string Username { get; set; }
        public List<playlist> playlist { get; }=new List<playlist>();

        public void Play()
        {
            Console.WriteLine($"Now playing");
        }

        public void Pause()
        {
            Console.WriteLine($"Paused");
        }

        public void Stop()
        {
            Console.WriteLine($"Stopped");
        }
    }
}

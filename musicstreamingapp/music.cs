using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicstreamingapp
{
    public class music
    {

        public string Title { get; set; }
        public TimeSpan Duration { get; set; }

        public void Play()
        {
            Console.WriteLine($"Now playing {Title}");
        }

        public void Stop()
        {
            Console.WriteLine($"{Title} Stopped");
        }
        public void Pause()
        {
            Console.WriteLine($"{Title} Paused");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicstreamingapp
{
    public class playlist
    {
        public string Title { get; set; }
        public List<music> Contents { get; } = new List<music>();
        public void AddContent(music content)
        {
            Contents.Add(content);
        }
        public void PlayAll()
        {
            Console.WriteLine("Playling playlist");
            foreach (var contents in Contents)
            {
                contents.Play();

            }
        }
        public void Play()
        {

            Console.WriteLine("Playling playlist");
            foreach (var contents in Contents)
            {
                contents.Play();

            }
        }

        public void Pause()
        {

            Console.WriteLine("pausing playlist");
            foreach (var contents in Contents)
            {
                contents.Pause();

            }
        }
        public void Stopall()
        {

            Console.WriteLine("stopping playlist");
            foreach (var contents in Contents)
            {
                contents.Stop();
            }

        }
    }
}

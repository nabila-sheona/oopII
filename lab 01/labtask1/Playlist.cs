using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    public class Playlist
    {
       
       
            public string Name { get; set; }
            public List<types> Contents { get; set; } = new List<types>();

            public void AddContent(types content)
            {
                Contents.Add(content);
            }

            public void PlayAll()
            {
                foreach (var content in Contents)
                {
                    Console.WriteLine($"Playing {content.title}");
              
                }
            }
        

    }
}

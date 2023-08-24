using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace musicstreamingapp
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            songs song = new songs { Title = "Speak now", Artist = "taylor swift", Duration = TimeSpan.FromMinutes(3) };
            podcast podcast = new podcast { Title = "life", Host = "ykw", episodenumber = 1, Duration = TimeSpan.FromMinutes(30) };
            audiobook audiobook = new audiobook { Title = "acotar", Narrator = "sarah", Duration = TimeSpan.FromHours(4) };

            // Console.WriteLine("Choose your componet:" + "\n" + "songs" + "\n" + "podcasts" + "\n" + "audiobooks");
        
            //int s = 1;



            playlist playlists = new playlist { Title = "my playlist"};
  
            //foreach (songs s in song) {
              //  Console.WriteLine(s);
            //}

            //string name= Console.ReadLine();
            playlists.AddContent(song);
            playlists.AddContent(podcast);
            playlists.AddContent(audiobook);
           

            Console.WriteLine("enter username");

            user user = new user { Username = Console.ReadLine()};
        mon:
         


            // Create a user and add the playlist

            user.playlist.Add(playlists);
            // Play the playlist
            Console.WriteLine("play songs?  yes if yes or no if no");
            string key= Console.ReadLine();
            if (key == "yes")
            {
                Console.WriteLine("\n loading playlist...");

                playlists.PlayAll();
                elegible:
                Console.WriteLine("\nchoose opretation: p-play  k-pause s-stop");
                //play pause stop not working
                string b = Console.ReadLine();
                if (b == "p")
                {
                 

                    playlists.Play();
                    goto elegible;
                }
                else if (b == "k")
                {
                    
                    playlists.Pause();
                    goto elegible;
                }
                else if (b == "s")
                {
                   
                    playlists.Stopall();

                    Console.WriteLine("\n operation done \n");

                    goto non;
                }
                
            }


            else if(key == "no")
            {
                //not working
                playlists.Stopall();

                Console.WriteLine("\n operation done \n");

                goto non;
            }

        non:
            Console.WriteLine("again?");
            string stuck = Console.ReadLine();
            if (stuck != "yes")
            {
                user.Stop();

            }
            else
            {
                goto mon;
            }

        }
    }
}

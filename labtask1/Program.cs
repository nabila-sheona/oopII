using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace labtask1
{
    internal class Program
    {

        

        

        Playlist myPlaylist = new Playlist { Name = "My Playlist" };

        
       
        static void Main(string[] args)
        {
            List<string> Song = new List<string>();
            List<string> Podcast = new List<string>();
            List<string> Audiobook = new List<string>();
            List<string> Playlist = new List<string>();

            string title, album, artist,type;
            string host;
            int epnum;
            int duration;
            string narrator;
            string a;
            Console.WriteLine("User or Creator");
            a= Console.ReadLine();
            if (a == "User")
            {
                Console.WriteLine("Choose your type: ");
                Console.WriteLine("Song");
                Console.WriteLine("Podcast");
                Console.WriteLine("Audiobook");
                Console.WriteLine("playlist");
                type = Console.ReadLine();
                if (type == "Song")
                {

                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter the artist: ");
                    artist = Console.ReadLine();


                    foreach (string s in Song)
                    {
                        if (s == title)
                        {
                            //public void play(title);
                        }
                    }

                }

                else if (type == "Podcast")
                {

                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter the host: ");
                    host = Console.ReadLine();


                    foreach (string s in Song)
                    {
                        if (s == title)
                        {
                            //public void play(title);
                        }
                    }

                }


                else if (type == "Audiobook")
                {

                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter the narrator: ");
                    narrator = Console.ReadLine();

                    foreach (string s in Song)
                    {
                        if (s == title)
                        {
                            //   public void play(title);
                        }
                    }

                }

                else if (type == "playlist")
                {

                    Console.WriteLine("existed or new:");
                    a = Console.ReadLine();
                    if (a == "existed")
                    {

                        string name=Console.ReadLine();

                        foreach (string s in Playlist)
                        {
                            if (s == name)
                            {
                                Console.WriteLine("playing");

                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("");
                        //add name;
                        //add type;
                        //addsong constructor;

                    }
                }

                



            }

            else
            {
                Console.WriteLine("Choose your type: ");
                Console.WriteLine("Song");
                Console.WriteLine("Podcast");
                Console.WriteLine("Audiobook");
                type = Console.ReadLine();
                if (type == "Song")
                {

                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter the artist: ");
                    artist = Console.ReadLine();


                    Console.WriteLine("Enter the album: ");
                    album = Console.ReadLine();


                    Console.WriteLine("Enter duration: ");
                    duration = Convert.ToInt32(Console.ReadLine());
                    //Song song1 = new Song { title, album, artist, duration };
                }

                else if (type == "Podcast")
                {

                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter the host: ");
                    host = Console.ReadLine();


                    Console.WriteLine("Enter number of episode: ");
                    epnum = Convert.ToInt32(Console.ReadLine());
                    Podcast podcast1 = new Podcast { title = "Podcast 1", host = "Host 1", epnum = 1, duration = 3 };


                }


                else if (type == "Audiobook")
                {

                    Console.WriteLine("Enter the title: ");
                    title = Console.ReadLine();

                    Console.WriteLine("Enter the narrator: ");
                    narrator = Console.ReadLine();
                    Audiobook audiobook1 = new Audiobook { title = "Audiobook 1", narrator = "Narrator 1", duration = 3 };


                }
            }

        }


  

       
       // Song song1 = new Song { title, artist, duration };
       // Podcast podcast1 = new Podcast { title = "Podcast 1", host = "Host 1", epnum = 1, duration = TimeSpan.FromMinutes(45) };
       // Audiobook audiobook1 = new Audiobook { title = "Audiobook 1", narrator = "Narrator 1", duration = TimeSpan.FromHours(2) };

        //myPlaylist.AddContent(song1);
        //myPlaylist.AddContent(podcast1);
        //myPlaylist.AddContent(audiobook1);

        //myPlaylist.PlayAll();
    }
}
    
            
     



    

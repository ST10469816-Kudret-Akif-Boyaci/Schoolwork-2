using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCollections
{
    public class LinkedListExample
    {
        //for data that is related and should be linked
        //for example an album in a music player where songs should be linked one after another

        public void linkedlistmethod()
        {
           // object of a linked list where we need to use the object for a playlist
           LinkedList<string> playlist = new LinkedList<string>();

            //adding songs to the playlist using addlast method
            //called addlast method because the new object comes after the previous object

            //adding songs to the playlists
            playlist.AddLast("Song 1 - Artist 1");
            playlist.AddLast("Song 2 - Artist 2");
            playlist.AddLast("Song 3 - Artist 3");

            //display the song
            Console.WriteLine("playlist");
            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }

            //removing a song fromn playlist
            playlist.Remove("Song 2 - Artist 2");

            //display the playlist after removal
            Console.WriteLine("\n Playlsit after removal");
            foreach (var song in playlist)
            {
                Console.WriteLine(song);
            }
        }
    }
}

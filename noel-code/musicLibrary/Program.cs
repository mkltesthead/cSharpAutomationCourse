using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace musicLibrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> songs = new Dictionary<string, List<string>>();
            songs.Add("ArtistA", new List<string>()
            {
                "SongAA",
                "SongAB",
                "SongAC",
                "SongAD",
                "SongAE"
            });
            songs.Add("ArtistB", new List<string>()
            {
                "SongBA",
                "SongBB",
                "SongBC",
                "SongBD",
                "SongBE"
            });
            songs.Add("ArtistC", new List<string>()
            {
                "SongCA",
                "SongCB",
                "SongCC",
                "SongCD",
                "SongCE"
            });
            songs.Add("ArtistD", new List<string>()
            {
                "SongDA",
                "SongDB",
                "SongDC",
                "SongDD",
                "SongDE"
            });
            songs.Add("ArtistE", new List<string>()
            {
                "SongEA",
                "SongEB",
                "SongEC",
                "SongED",
                "SongEE"
            });

            Dictionary<string, ArrayList> playlists = new Dictionary<string, ArrayList>();
            playlists.Add("PlaylistA", new ArrayList()
            {
                "SongAA",
                "SongBA",
                "SongCA",
                "SongDA",
                "SongEA"
            });
            playlists.Add("PlaylistB", new ArrayList()
            {
                "SongAB",
                "SongBB",
                "SongCB",
                "SongDB",
                "SongEB"
            });
            playlists.Add("PlaylistC", new ArrayList()
            {
                "SongAC",
                "SongBC",
                "SongCC",
                "SongDC",
                "SongEC"
            });
            playlists.Add("PlaylistD", new ArrayList()
            {
                "SongAD",
                "SongBD",
                "SongCD",
                "SongDD",
                "SongED"
            });
            playlists.Add("PlaylistE", new ArrayList()
            {
                "SongAE",
                "SongBE",
                "SongCE",
                "SongDE",
                "SongEE"
            });

            Console.WriteLine("Display all songs");
            foreach (var artist in songs.Keys)
            {
                Console.WriteLine($"{artist}:\r\n    {String.Join("\r\n    ", songs[artist].ToArray())}");
            }
            Console.WriteLine();

            Console.WriteLine("Display all playlists");
            foreach (var playlist in playlists.Keys)
            {
                Console.WriteLine($"{playlist}:\r\n    {String.Join("\r\n    ", playlists[playlist].ToArray())}");
            }
            Console.WriteLine();

            string myArtist = "ArtistC";
            Console.WriteLine($"Display all songs by {myArtist}");
            Console.WriteLine($"{myArtist}:\r\n    {String.Join("\r\n    ", songs[myArtist].ToArray())}");
            Console.WriteLine();

            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
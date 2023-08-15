namespace AssignmentMusicLibraryApp
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    //public class Songs
    //{
    //    public string Title { get; set; }
    //    public string Artist { get; set; }
    //}

    public class Library
    {
        private string? title;
        private string? artist;
        public Dictionary<string, string> songs;
        //private List<songs> musicLibrary;
        private Dictionary<string, ArrayList> playlists;

        public Library()
        {
            songs = new Dictionary<string, string>();
            //musicLibrary = new List<Songs>();
            playlists = new Dictionary<string, ArrayList>();
        }

        public void AddSong(string artist, string title)
        {
            songs.Add(artist, title);

        }

        public void CreatePlaylist(string playlistName)
        {
            playlists[playlistName] = new ArrayList();
        }

        public void AddSongToPlaylist(string playlistName, Dictionary<string, string> songs)
        {
            if (playlists.ContainsKey(playlistName))
            {
                playlists[playlistName].Add(songs);
            }
            else
            {
                Console.WriteLine($"Playlist '{playlistName}' does not exist.");
            }
        }


        public void DisplayPlaylist()
        {
            Console.WriteLine("Playlists:");
            foreach (var playlist in playlists)
            {
                Console.WriteLine($"Playlist: {playlist.Key}");
                Console.WriteLine("Songs:");
                foreach (var song in playlist.Value)
                {
                    Console.WriteLine(song);
                }
                Console.WriteLine();
            }
        }

        public void FindSongsByArtist(string artist)
        {
            Console.WriteLine($"Songs by artist '{artist}':");
            HashSet<string> displayedSongs = new HashSet<string>(); // Keep track of displayed songs

            foreach (var song in songs)
            {
                if (song.Key.Equals(artist))
                {
                    Console.WriteLine(song);
                }
                else
                {
                    Console.WriteLine("No songs found by this artist");
                }
            }

            Console.WriteLine();
        }


        public void DisplayAllSongs()
        {
            Console.WriteLine("All Songs:");

            Console.WriteLine("Music Library:");
            foreach (var song in songs)
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();
        }
    }

    public class AssignmentMusicLibrary
    {
        //public static object songs { get; private set; }

        public static void Main(string[] args)
        {
            Library musicLibrary = new Library();

            while (true)
            {
                Console.WriteLine("Enter '1' to add a song to the library.");
                Console.WriteLine("Enter '2' to create a playlist and add songs to it.");
                Console.WriteLine("Enter '3' to display all playlists");
                Console.WriteLine("Enter '4' to find songs by a specific artist.");
                Console.WriteLine("Enter '5' to search for all songs.");
                Console.WriteLine("Enter '0' to exit.");
                Console.WriteLine();

                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        Console.Write("Enter the title of the song: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter the artist of the song: ");
                        string artist = Console.ReadLine();
                        musicLibrary.AddSong(artist, title);
                        break;

                    case "2":
                        Console.Write("Enter the name of the playlist: ");
                        string playlistName = Console.ReadLine();
                        musicLibrary.CreatePlaylist(playlistName);

                        Console.WriteLine("Enter the songs to add to the playlist (type 'done' when finished): ");
                        while (true)
                        {
                            Console.Write("Enter the title of the song: ");
                            string songTitle = Console.ReadLine();
                            if (songTitle.ToLower() == "done")
                                break;

                            Console.Write("Enter the artist of the song: ");
                            string songArtist = Console.ReadLine();
                            var song = new Dictionary<string, string>();
                            song.Add(songArtist, songTitle);
                            musicLibrary.AddSongToPlaylist(playlistName, song);
                        }
                        break;

                    case "3":
                        musicLibrary.DisplayPlaylist();
                        break;

                    case "4":
                        Console.Write("Enter the artist name to find songs: ");
                        string artistName = Console.ReadLine();
                        musicLibrary.FindSongsByArtist(artistName);
                        break;

                    case "5":
                        musicLibrary.DisplayAllSongs();
                        break;

                    case "0":
                        Console.WriteLine("Exit");
                        return;

                    default:
                        Console.WriteLine("Invalid input. Try again.");
                        break;
                }
            }
        }
    }

}
using System;
using System.Collections.Generic;

public class Song
{
    public string Title { get; set; }
    public string Artist { get; set; }

    public override string ToString()
    {
        return $"{Title} - {Artist}";
    }
}

public class Library
{
    private List<Song> musicLibrary;
    private Dictionary<string, List<Song>> playlists;

    public Library()
    {
        musicLibrary = new List<Song>();
        playlists = new Dictionary<string, List<Song>>();
    }

    public void AddSong(Song song)
    {
        musicLibrary.Add(song);
    }

    public void CreatePlaylist(string playlistName)
    {
        playlists[playlistName] = new List<Song>();
    }

    public void AddSongToPlaylist(string playlistName, Song song)
    {
        if (playlists.ContainsKey(playlistName))
        {
            playlists[playlistName].Add(song);
        }
        else
        {
            Console.WriteLine($"Playlist '{playlistName}' does not exist.");
        }
    }

    public bool DisplayPlaylist(string playlistName)
    {
        if (playlists.ContainsKey(playlistName))
        {
            Console.WriteLine($"Playlist: {playlistName}");
            Console.WriteLine("Songs:");
            foreach (var song in playlists[playlistName])
            {
                Console.WriteLine(song);
            }
            Console.WriteLine();
            return true;
        }
        else
        {
            Console.WriteLine($"Playlist '{playlistName}' does not exist.");
            return false;
        }
    }

    public bool MoveSongBetweenPlaylists(string sourcePlaylistName, string destinationPlaylistName, string songTitleToMove)
    {
        if (playlists.ContainsKey(sourcePlaylistName) && playlists.ContainsKey(destinationPlaylistName))
        {
            var sourcePlaylist = playlists[sourcePlaylistName];
            var destinationPlaylist = playlists[destinationPlaylistName];

            Song songToMove = sourcePlaylist.Find(song => song.Title.Equals(songTitleToMove, StringComparison.OrdinalIgnoreCase));
            if (songToMove != null)
            {
                if (destinationPlaylist.Exists(song => song.Title.Equals(songTitleToMove, StringComparison.OrdinalIgnoreCase)))
                {
                    return false; // Song already exists in the destination playlist
                }

                sourcePlaylist.Remove(songToMove);
                destinationPlaylist.Add(songToMove);
                return true;
            }
        }

        return false; // Song not found in the source playlist or playlists do not exist
    }

    public void DisplayLibrary()
    {
        Console.WriteLine("Music Library:");
        foreach (var song in musicLibrary)
        {
            Console.WriteLine(song);
        }
        Console.WriteLine();

        // Display songs in all playlists
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


    public void DisplayPlaylists()
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

        // Search in the music library
        foreach (var song in musicLibrary)
        {
            if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase) && !displayedSongs.Contains(song.Title))
            {
                Console.WriteLine(song);
                displayedSongs.Add(song.Title);
            }
        }

        // Search in all playlists
        foreach (var playlist in playlists)
        {
            foreach (var song in playlist.Value)
            {
                if (song.Artist.Equals(artist, StringComparison.OrdinalIgnoreCase) && !displayedSongs.Contains(song.Title))
                {
                    Console.WriteLine(song);
                    displayedSongs.Add(song.Title);
                }
            }
        }

        if (displayedSongs.Count == 0)
        {
            Console.WriteLine("No songs found by this artist.");
        }
        Console.WriteLine();
    }


    public void DisplayAllSongs()
    {
        Console.WriteLine("All Songs:");

        Console.WriteLine("Music Library:");
        foreach (var song in musicLibrary)
        {
            Console.WriteLine(song);
        }
        Console.WriteLine();

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
}

public class CollectionsMusicLibrary
{
    public static void Main(string[] args)
    {
        Library musicLibrary = new Library();

        while (true)
        {
            Console.WriteLine("Enter '1' to add a song to the library.");
            Console.WriteLine("Enter '2' to create a playlist and add songs to it.");
            Console.WriteLine("Enter '3' to display all songs in the music library.");
            Console.WriteLine("Enter '4' to display all playlists and their associated songs.");
            Console.WriteLine("Enter '5' to find songs by a specific artist.");
            Console.WriteLine("Enter '6' to add a song to an existing playlist.");
            Console.WriteLine("Enter '7' to move a song from one playlist to another.");
            Console.WriteLine("Enter '8' to search for all songs, whether they are part of a playlist or not.");
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
                    musicLibrary.AddSong(new Song { Title = title, Artist = artist });
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

                        Song songToAdd = new Song { Title = songTitle, Artist = songArtist };
                        musicLibrary.AddSongToPlaylist(playlistName, songToAdd);
                    }
                    break;

                case "3":
                    musicLibrary.DisplayLibrary();
                    break;

                case "4":
                    musicLibrary.DisplayPlaylists();
                    break;

                case "5":
                    Console.Write("Enter the artist name to find songs: ");
                    string searchArtist = Console.ReadLine();
                    musicLibrary.FindSongsByArtist(searchArtist);
                    break;

                case "6":
                    Console.Write("Enter the name of the playlist to add the song: ");
                    string existingPlaylistName = Console.ReadLine();
                    if (musicLibrary.DisplayPlaylist(existingPlaylistName))
                    {
                        Console.Write("Enter the title of the song: ");
                        string songTitle = Console.ReadLine();
                        Console.Write("Enter the artist of the song: ");
                        string songArtist = Console.ReadLine();

                        Song songToAdd = new Song { Title = songTitle, Artist = songArtist };
                        musicLibrary.AddSongToPlaylist(existingPlaylistName, songToAdd);
                        Console.WriteLine($"Song added to playlist '{existingPlaylistName}' successfully.");
                    }
                    break;

                case "7":
                    Console.Write("Enter the name of the playlist to move the song from: ");
                    string sourcePlaylistName = Console.ReadLine();
                    if (musicLibrary.DisplayPlaylist(sourcePlaylistName))
                    {
                        Console.Write("Enter the name of the playlist to move the song to: ");
                        string destinationPlaylistName = Console.ReadLine();

                        Console.Write("Enter the title of the song: ");
                        string songTitleToMove = Console.ReadLine();

                        bool movedSuccessfully = musicLibrary.MoveSongBetweenPlaylists(sourcePlaylistName, destinationPlaylistName, songTitleToMove);
                        if (movedSuccessfully)
                        {
                            Console.WriteLine($"Song '{songTitleToMove}' moved from '{sourcePlaylistName}' to '{destinationPlaylistName}' successfully.");
                        }
                        else
                        {
                            Console.WriteLine($"Song '{songTitleToMove}' not found in '{sourcePlaylistName}' or '{destinationPlaylistName}' already contains the song.");
                        }
                    }
                    break;

                case "8":
                    musicLibrary.DisplayAllSongs();
                    break;

                case "0":
                    Console.WriteLine("Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid input. Try again.");
                    break;
            }
        }
    }
}

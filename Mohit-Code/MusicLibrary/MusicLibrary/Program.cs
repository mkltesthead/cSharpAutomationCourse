using System;
using System.Collections.Generic;
using System.Linq;

// Define the Song class to represent individual songs
class Song
{
    public string SongTitle { get; }
    public string Artist { get; }
    public int DurationInSeconds { get; }

    public Song(string songTitle, string artist, int durationInSeconds)
    {
        SongTitle = songTitle;
        Artist = artist;
        DurationInSeconds = durationInSeconds;
    }
}


class Playlist
{
    public string Name { get; }
    private List<Song> songsList = new List<Song>();

    public Playlist(string name)
    {
        Name = name;
    }

    public void AddSong(Song song)
    {
        songsList.Add(song);
    }

    public void DisplaySongs()
    {
        Console.WriteLine($"Playlist: {Name}");
        foreach (var song in songsList)
        {
            Console.WriteLine($"Song Title: {song.SongTitle}, Artist: {song.Artist},  Duration of Song: {song.DurationInSeconds} seconds");
        }
        Console.WriteLine();
    }
}

// class to manage songs and playlists
class Library
{
    private List<Song> musicLibrary = new List<Song>();
    private List<Playlist> playlists = new List<Playlist>();

    public void AddSong(Song song)
    {
        musicLibrary.Add(song);
    }

    public void CreatePlaylist(string name)
    {
        var playlist = new Playlist(name);
        playlists.Add(playlist);
    }

    public void AddSongToPlaylist(string playlistName, Song song)
    {
        var playlist = playlists.FirstOrDefault(p => p.Name.ToLower().Equals(playlistName.ToLower()));
        if (playlist != null)
        {
            playlist.AddSong(song);
        }
        else
        {
            Console.WriteLine($"Playlist '{playlistName}' not found.");
        }
    }

    public void DisplayAllSongs()
    {
        Console.WriteLine("All Songs in the Music Library:");
        foreach (var song in musicLibrary)
        {
            Console.WriteLine($"Song Title: {song.SongTitle}, Artist: {song.Artist},  Duration of Song: {song.DurationInSeconds} seconds");
        }
        Console.WriteLine();
    }

    public void DisplayAllPlaylists()
    {
        Console.WriteLine("All Playlists:");
        foreach (var playlist in playlists)
        {
            playlist.DisplaySongs();
        }
    }

    public List<Song> FindSongsByArtist(string artist)
    {
        return musicLibrary.Where(song => song.Artist.ToLower().Equals(artist.ToLower())).ToList();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Library musicLibrary = new Library();

        // Adding sample songs
        musicLibrary.AddSong(new Song("Calm Down", "Selena Gomez", 200));
        musicLibrary.AddSong(new Song("Baby", "Justin Bieber", 250));
        musicLibrary.AddSong(new Song("You Belong With Me", "Taylor Swift", 190));

        // Creating playlists and adding songs to them
        musicLibrary.CreatePlaylist("Playlist1");
        musicLibrary.AddSongToPlaylist("Playlist1", new Song("Calm Down", "Selena Gomez", 200));
        musicLibrary.AddSongToPlaylist("Playlist1", new Song("Baby", "Justin Bieber", 250));

        // Displaying all songs in the music library
        musicLibrary.DisplayAllSongs();

        // Displaying all playlists and their associated songs
        musicLibrary.DisplayAllPlaylists();

        Console.WriteLine("Enter name of artist to search song:");
        string artistName = Console.ReadLine();

        // Search all songs by a specific artist
        List<Song> songsByArtist = musicLibrary.FindSongsByArtist(artistName.ToLower());
        if (songsByArtist.Count > 0)
            Console.WriteLine($"All Songs by {artistName}:");
        else 
            Console.WriteLine($"Sorry!! No Song Exists by Artist {artistName}");

        foreach (var song in songsByArtist)
        {
            Console.WriteLine($"Song Title: {song.SongTitle}, Duration of Song: {song.DurationInSeconds} seconds");
        }
    }
}
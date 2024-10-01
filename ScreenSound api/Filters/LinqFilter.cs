

using ScreenSound_api.Models;

namespace ScreenSound_api.Filters;

internal class LinqFilter
{
    public static void FilterAllGenres(List<Music> musics)
    {
        var allGenres = musics.Select(genres => genres.genre).Distinct().ToList();
        foreach (var genre in allGenres)
        {
            Console.WriteLine($"-{genre}");
        }
    }

    public static void FilterArtistsPerMusicGenre(List<Music> musics, string genre)
    {
        var artistsPerMusicalGenre = musics.Where(musics => musics.genre!.Contains(genre)).Select(musics => musics.Artist).Distinct().ToList();
        Console.WriteLine($"Show artists per musical genres >>>> {genre}");
        foreach (var artist in artistsPerMusicalGenre)
        {
            Console.WriteLine($"- {artist}");

        }
    }

    public static void FilterArtistMusic(List<Music> musics, string ArtistName) 
    {
        var artistMusic = musics.Where(musics => musics.Artist!.Equals(ArtistName)).ToList();
        Console.WriteLine(ArtistName);

        foreach (var music in artistMusic) 
        {
            Console.WriteLine($"- {music.Name}");
        }
    }
}

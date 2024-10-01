using ScreenSound_api.Filters;
using ScreenSound_api.Models;
using System.Text.Json;

using (HttpClient client = new HttpClient()) 
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        Console.WriteLine(response);
        var musics = JsonSerializer.Deserialize<List<Music>>(response)!;
        //LinqFilter.FilterAllGenres(musics);
        //LinqOrder.showArtistOrder(musics);
        //LinqFilter.FilterArtistsPerMusicGenre(musics, "hip hop");
        // LinqFilter.FilterArtistMusic(musics, "Michel Teló");

        var favoriteSongs = new favoriteSongs("Vinicius");
        favoriteSongs.addFavoriteMusic(musics[1]);
        favoriteSongs.addFavoriteMusic(musics[377]);
        favoriteSongs.addFavoriteMusic(musics[4]);
        favoriteSongs.addFavoriteMusic(musics[6]);
        favoriteSongs.addFavoriteMusic(musics[1467]);
        
        favoriteSongs.showFavoriteSongs();

        favoriteSongs.createJsonArchive();


    }
    catch (Exception ex)
    {
        Console.WriteLine($"Temos um problema na request: {ex.Message}");
    }
}
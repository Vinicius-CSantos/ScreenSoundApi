using ScreenSound_api.Models;


namespace ScreenSound_api.Filters;

internal class LinqOrder
{
    public static void showArtistOrder(List<Music> music)
    {
        var artistsOrder = music.OrderBy(music => music.Artist).Select(music => music.Artist).Distinct().ToList();
        
        Console.WriteLine("List of artists sorted");

        foreach (var artist in artistsOrder) {
            Console.WriteLine($"- {artist}");
        }
    }
}

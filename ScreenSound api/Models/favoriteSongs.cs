using System.Text.Json;

namespace ScreenSound_api.Models;

internal class favoriteSongs
{
    public string? Name { get; set; }

    public List<Music> ListFavoriteSongs { get; set; }

    public favoriteSongs(string name)
    {

        Name = name;
        ListFavoriteSongs = new List<Music>();
    }

    public void addFavoriteMusic(Music music)
    {
        ListFavoriteSongs.Add(music);
    }

    public void showFavoriteSongs()
    {
        Console.WriteLine($"This is favorite songs --> {Name}");
        foreach (Music music in ListFavoriteSongs)
        {
            Console.WriteLine($"- {music.Name} from {music.Artist}");
        }
    }

    public void createJsonArchive()
    {
        string json = JsonSerializer.Serialize(new
        {
            name = Name,
            musics = ListFavoriteSongs
        });
        string nameOfArchive = $"favorites-songs-{Name}.json";

        File.WriteAllText(nameOfArchive, json);

        Console.WriteLine($"Json created {Path.GetFullPath(nameOfArchive)}");
    }

}

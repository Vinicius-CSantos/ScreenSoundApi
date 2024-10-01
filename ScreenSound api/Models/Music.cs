

using System.Text.Json.Serialization;

namespace ScreenSound_api.Models;

internal class Music
{
    [JsonPropertyName("song")]
    public string Name { get; set; }

    [JsonPropertyName("artist")]
    public string Artist { get; set; }

    [JsonPropertyName("duration_ms")]
    public int Duration { get; set; }

    [JsonPropertyName("genre")]
    public string genre { get; set; }

    public void showMusicDetail ()
    {
        Console.WriteLine($"Artist:{Artist}");
        Console.WriteLine($"Artist:{Name}");
        Console.WriteLine($"Artist:{Duration /1000}");
        Console.WriteLine($"Genre:{genre}");
    }
}

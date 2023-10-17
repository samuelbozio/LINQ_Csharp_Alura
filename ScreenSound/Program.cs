using ScreenSound.Models;
using System.Text.Json;
using ScreenSound.Filters;

using (HttpClient client = new HttpClient())
{

    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musics>>(resposta)!;


        //Console.WriteLine(resposta);
        //LINQ.FiltrarMusicasPorAno(musicas, 2010);
        //LINQ.FiltrarTodosGeneros(musicas);
        //LINQ.ArtistaPorNome(musicas);
        //LINQ.FiltrarArtistaPorGenero(musicas, "hip hop");
        //LINQ.FiltrarMusicasArtista(musicas, "XXXTENTACION");


        Console.WriteLine(musicas[1].ToString());

        var musicasPreferidas = new MusicasPreferidas("Favoritas Samuel");
        musicasPreferidas.AddMusicasFavoritas(musicas[1]);
        musicasPreferidas.AddMusicasFavoritas(musicas[2]);
        musicasPreferidas.AddMusicasFavoritas(musicas[3]);

        musicasPreferidas.ExibirMusicasFavoritas();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }


}
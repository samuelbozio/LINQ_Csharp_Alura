using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound.Models
{
    internal class Musics
    {

        [JsonPropertyName("artist")]
        public string? NomeArtista { get; set; }
        [JsonPropertyName("genre")]
        public string? NomeGenero { get; set; }
        [JsonPropertyName("song")]
        public string? NomeMusica { get; set; }
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("year")]
        public string? AnoLancamento { get; set; }

        public int Ano() => int.Parse(AnoLancamento!);
       
        public void ExibirDetalhesMusica()
        {
            Console.WriteLine($"Artista: {NomeArtista}");
            Console.WriteLine($"Música: {NomeMusica}");
            Console.WriteLine($"Gênero: {NomeGenero}");
            Console.WriteLine($"Duração: {Duracao / 1000}");
            Console.WriteLine($"Lançamento: {AnoLancamento}");
        }

        public static implicit operator string(Musics v)
        {
            throw new NotImplementedException();
        }
    }
}

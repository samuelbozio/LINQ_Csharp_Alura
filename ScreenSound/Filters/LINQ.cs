using ScreenSound.Models;
namespace ScreenSound.Filters
{
    internal class LINQ
    {


        public static void FiltrarTodosGeneros(List<Musics> musicas)
        {
            var todosGenerosMusicais = musicas.Select(genero => genero.NomeGenero).Distinct().ToList();
            foreach (var genero in todosGenerosMusicais)
            {
                Console.WriteLine("Gênero: " + genero);
            }
        }

        public static void ArtistaPorNome(List<Musics> musicas) 
        {
            var artistasPorNome = musicas.OrderBy(nome => nome.NomeArtista).Select(musica => musica.NomeArtista).Distinct().ToList(); 
            foreach(var artist in artistasPorNome)
            {
                Console.WriteLine(artist);
            }
        }

        public static void FiltrarArtistaPorGenero(List<Musics> musicas, string genero)
        {
            var artistasPorGeneroMusical = musicas.Where(musicas => musicas.NomeGenero == genero).Select(nome => nome.NomeArtista).Distinct().ToList();
            foreach(var generoArtistas in artistasPorGeneroMusical)
            {
                Console.WriteLine(generoArtistas);
            }
        }

        public static void FiltrarMusicasArtista(List<Musics> musicas, string nomeArtista)
        {
            var musicasArtista = musicas.Where(nome => nome.NomeArtista == nomeArtista).Select(nomeMusicas => nomeMusicas.NomeMusica).Distinct().ToList();
            foreach(var musicasFiltradas in musicasArtista)
            {
                Console.WriteLine(musicasFiltradas);
            }
        }

        public static void FiltrarMusicasPorAno(List<Musics> musicas, int anoLancamento)
        {
            var musicaFiltroAno = musicas.Where(ano => ano.Ano() == anoLancamento).Select(nomeMusicas => nomeMusicas.NomeMusica).Distinct().ToList();
            foreach(var musicaAno in  musicaFiltroAno)
            {
                Console.WriteLine(musicaAno);
            }
        }


    }

}


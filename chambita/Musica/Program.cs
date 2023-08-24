using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica
{
    public class Program
    {
        static void Main(string[] args)
        {

            Cancion Nightcall = new Cancion();
            Nightcall.NombreCancion = "Nightcall";
            Nightcall.Autor = "Kavinsky";
            Nightcall.GeneroCancion = "Synthwave";
            Nightcall.FechaPublicacion = 2010;
            Nightcall.Duracion = "4:30";
            Nightcall.Album = "Nightcall";

            Cancion MoneyTrees = new Cancion();
            MoneyTrees.NombreCancion = "Money Trees";
            MoneyTrees.Autor = "Kendrick Lamar, Jay Rock";
            MoneyTrees.GeneroCancion = "HipHop";
            MoneyTrees.FechaPublicacion = 2012;
            MoneyTrees.Duracion = "6:26";
            MoneyTrees.Album = "good kid, m.A.A.d city";

            Cancion Hipnotize = new Cancion();
            Hipnotize.NombreCancion = "Hipnotize";
            Hipnotize.Autor = "The Notorious B.I.G.";
            Hipnotize.GeneroCancion = "HipHop";
            Hipnotize.FechaPublicacion = 1997;
            Hipnotize.Duracion = "3:49";
            Hipnotize.Album = "Life After Death";

            Cancion Redbone = new Cancion();
            Redbone.NombreCancion = "Redbone";
            Redbone.Autor = "Childish Gambino";
            Redbone.GeneroCancion = "HipHop";
            Redbone.FechaPublicacion = 2016;
            Redbone.Duracion = "5:26";
            Redbone.Album = "Awaken, My Love";

            Cancion El = new Cancion();
            El.NombreCancion = "El (Him)";
            El.Autor = "Jose Jose";
            El.GeneroCancion = "Balada";
            El.FechaPublicacion = 1992;
            El.Duracion = "3:39";
            El.Album = "Que Es El Amor";




            Artista ADO = new Artista();
            ADO.NombreArtista = "ADO";
            ADO.Nacionalidad = "Japonesa";
            ADO.GeneroArtista = "J-pop";
            ADO.Popularidad = 70;
            ADO.Activo = true;
            ADO.Seguidores = 2884910;

            Artista Gorillaz = new Artista();
            Gorillaz.NombreArtista = "Gorillaz";
            Gorillaz.Nacionalidad = "Britanica";
            Gorillaz.GeneroArtista = "Alt Rock";
            Gorillaz.Popularidad = 77;
            Gorillaz.Activo = true;
            Gorillaz.Seguidores = 10722933;

            Artista PostMalone = new Artista();
            PostMalone.NombreArtista = "Post Malone";
            PostMalone.Nacionalidad = "Canadiense";
            PostMalone.GeneroArtista = "Rap";
            PostMalone.Popularidad = 89;
            PostMalone.Activo = true;
            PostMalone.Seguidores = 41783470;

            Artista LosTigresDelNorte = new Artista();
            LosTigresDelNorte.NombreArtista = "LosTigresDelNorte";
            LosTigresDelNorte.Nacionalidad = "Mexicana";
            LosTigresDelNorte.GeneroArtista = "Ranchera";
            LosTigresDelNorte.Popularidad = 74;
            LosTigresDelNorte.Activo = true;
            LosTigresDelNorte.Seguidores = 4870356;

            Artista Joji = new Artista();
            Joji.NombreArtista = "Joji";
            Joji.Nacionalidad = "Australiana";
            Joji.GeneroArtista = "Viral Pop";
            Joji.Popularidad = 80;
            Joji.Activo = true;
            Joji.Seguidores = 8686638;



            Album HollywoodsBleeding = new Album();
            HollywoodsBleeding.NombreAlbum = "Hollywoods Bleeding";
            HollywoodsBleeding.NoCanciones = 17;
            HollywoodsBleeding.FechaLanzamiento = 2019;
            HollywoodsBleeding.CalificacionAlbum = 6.8f;
            HollywoodsBleeding.Duracion = "51m 4s";
            HollywoodsBleeding.Autor = "Post Malone";

            Album Huracan = new Album();
            Huracan.NombreAlbum = "Huracan";
            Huracan.NoCanciones = 21;
            Huracan.FechaLanzamiento = 2021;
            Huracan.CalificacionAlbum = 6.2f;
            Huracan.Duracion = "1h 6m";
            Huracan.Autor = "Aleman";

            Album MEMORIAFUTURO = new Album();
            MEMORIAFUTURO.NombreAlbum = "MEMORIA FUTURO";
            MEMORIAFUTURO.NoCanciones = 10;
            MEMORIAFUTURO.FechaLanzamiento = 2020;
            MEMORIAFUTURO.CalificacionAlbum = 7.1f;
            MEMORIAFUTURO.Duracion = "35m 49s";
            MEMORIAFUTURO.Autor = "Siddhartha";

            Album MONTERO = new Album();
            MONTERO.NombreAlbum = "MONTERO";
            MONTERO.NoCanciones = 15;
            MONTERO.FechaLanzamiento = 2021;
            MONTERO.CalificacionAlbum = 7.1f;
            MONTERO.Duracion = "41m 17s";
            MONTERO.Autor = "Lil Nas X";

            Album ITEKOMAHITS = new Album();
            ITEKOMAHITS.NombreAlbum = "ITEKOMAHITS";
            ITEKOMAHITS.NoCanciones = 26;
            ITEKOMAHITS.FechaLanzamiento = 2019;
            ITEKOMAHITS.CalificacionAlbum = 7.7f;
            ITEKOMAHITS.Duracion = "26m 34s";
            ITEKOMAHITS.Autor = "Otoboke Beaver";

        }
    }
}

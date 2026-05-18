using Laboratorio__14.Models;

namespace Laboratorio__14.Services
{
    public class AlbumService
    {
        private List<Album> _albums = new()
    {
        new Album
        {
            Id = 1,
            Titulo = "Thriller",
            Artista = "Michael Jackson",
            FechaPublicacion = new DateTime(1982, 11, 30),
            Canciones = new List<Cancion>
            {
                new Cancion { Id = 1, Nombre = "Thriller", Artista = "Michael Jackson", Duracion = TimeSpan.FromMinutes(5.58) },
                new Cancion { Id = 2, Nombre = "Beat It",  Artista = "Michael Jackson", Duracion = TimeSpan.FromMinutes(4.18) }
            }
        }
    };

        private int _nextId = 2;

        public List<Album> GetAll() => _albums;

        public Album? GetById(int id) => _albums.FirstOrDefault(a => a.Id == id);

        public List<Album> GetByArtista(string artista) =>
            _albums.Where(a => a.Artista.Contains(artista, StringComparison.OrdinalIgnoreCase)).ToList();

        public void Add(Album album)
        {
            album.Id = ++_nextId;
            _albums.Add(album);
        }

        public void Update(Album album)
        {
            var index = _albums.FindIndex(a => a.Id == album.Id);
            if (index >= 0) _albums[index] = album;
        }

        public void Delete(int id) => _albums.RemoveAll(a => a.Id == id);
    }
}

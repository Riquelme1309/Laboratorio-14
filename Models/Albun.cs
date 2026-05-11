namespace Laboratorio__14.Models
{
    public class Albun
    {
        public int Id { get; set; }
        public string Titulo { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public DateTime FechaPublicacion { get; set; }
        public List<Cancion> Canciones { get; set; } = new();
    }
}

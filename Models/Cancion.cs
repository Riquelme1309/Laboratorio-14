namespace Laboratorio__14.Models
{
    public class Cancion
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Artista { get; set; } = string.Empty;
        public TimeSpan Duracion { get; set; }
    }
}
